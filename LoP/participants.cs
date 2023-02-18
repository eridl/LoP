using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace LoP
{
    public partial class participants : Form
    {
        public int ID = 0;
        public participants(int ID_var)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            get_Info("select part.id_participant, part.p_surname as 'Фамилия', part.p_name as 'Имя', part.p_patron as 'Отчество', part.p_number as 'Телефон', pos.position_name as 'Должность', org.org_name as 'Организация/Фонд', part.event_name as 'Акция/Событие' from position pos join participant part on pos.id_position = part.id_position join org on org.id_org = part.id_org;");
            ID = ID_var;
        }


        public void get_Info(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                dataGridView1.Columns[0].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так" + Environment.NewLine + ex.Message);
            }
        }

        private void Monsters_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                partprofile win = new partprofile(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()), "chng", ID);
                win.Owner = this;
                this.Hide();
                win.Show();
            }
        }

        class DoubleBufferedDataGridView : DataGridView
        {
            protected override bool DoubleBuffered { get => true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            partprofile win = new partprofile(0, "add", ID);
            win.Owner = this;
            this.Hide();
            win.Show();
        }


        private void search_TextChanged(object sender, EventArgs e)
        {
            get_Info("select part.id_participant, part.p_name as 'Имя', part.p_surname as 'Фамилия', part.p_patron as 'Отчество', part.p_number as 'Телефон', pos.position_name as 'Должность', org.org_name as 'Организация/Фонд', part.event_name as 'Акция/Событие' from position pos join participant part on pos.id_position = part.id_position join org on org.id_org = part.id_org where concat (part.p_name, part.p_surname, part.p_patron, part.p_number, pos.position_name, org.org_name, part.event_name) like '%" + search.Text + "%'; ");
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            get_Info("select part.id_participant, part.p_name as 'Имя', part.p_surname as 'Фамилия', part.p_patron as 'Отчество', part.p_number as 'Телефон', pos.position_name as 'Должность', org.org_name as 'Организация/Фонд', part.event_name as 'Акция/Событие' from position pos join participant part on pos.id_position = part.id_position join org on org.id_org = part.id_org;");

        }

        private void items_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                DGVPrinter print = new DGVPrinter();
                print.Title = "Список участников благотворительных акций/событий";
                print.PageNumbers = false;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Center;
                dataGridView1.ClearSelection();
                print.PrintDataGridView(dataGridView1);
            }
            else
            {
                MessageBox.Show("Нет информации об участниках");
            }
        }
    }
}
