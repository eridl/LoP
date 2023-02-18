using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoP
{
    public partial class partprofile : Form
    {
        public int ID_part = 0;
        public partprofile(int ID_p, string mode, int ID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            if (mode == "chng")
            {
                name_box.Visible = false;
                surname_box.Visible = false;
                patron_box.Visible = false;
                number_box.Visible = false;
                pos_box.Visible = false;
                org_box.Visible = false;
                event_box.Visible = false;
            }
            else if(mode == "add")
            {
                name_label.Visible = false;
                surname_label.Visible = false;
                patron_label.Visible = false;
                number_label.Visible = false;
                pos_label.Visible = false;
                org_label.Visible = false;
                event_label.Visible = false;
                del_btn.Visible = false;
                chng_btn.Text = "Добавить";
            }

            getBoxes("select p_name from participant;", name_box);
            getBoxes("select p_surname from participant;", surname_box);
            getBoxes("select p_patron from participant;", patron_box);
            getBoxes("select p_number from participant;", number_box);
            getBoxes("select position_name from position;", pos_box);
            getBoxes("Select org_name from org;", org_box);
            getBoxes("select event_name from participant", event_box);
            get_Info(ID_p);
            ID_part = ID_p;

        }
        public void getBoxes(string query, ComboBox box)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        box.Items.Add(rd.GetString(0));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки информации!" + Environment.NewLine + ex.Message);
            }
        }

        public void get_Info(int ID)
        {
            string query = "select part.p_name as 'Имя', part.p_surname as 'Фамилия', part.p_patron as 'Отчество', part.p_number as 'Телефон', pos.position_name as 'Должность', org.org_name as 'Организация/Фонд', part.event_name as 'Акция/Событие' from position pos join participant part on pos.id_position = part.id_position join org on org.id_org = part.id_org WHERE id_participant =" + ID.ToString() + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    name_label.Text = rd.GetString(0);
                    surname_label.Text = rd.GetString(1);
                    patron_label.Text = rd.GetString(2);
                    number_label.Text = rd.GetString(3);
                    pos_label.Text = rd.GetString(4);
                    org_label.Text = rd.GetString(5);
                    event_label.Text = rd.GetString(6);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки информации!" + Environment.NewLine + ex.Message);
            }
        }

        private void MonsterProfile_Load(object sender, EventArgs e)
        {

        }

        private void chng_btn_Click(object sender, EventArgs e)
        {
            switch (chng_btn.Text)
            {
                case "Добавить":
                    doAction("insert into participant (p_name, p_surname, p_patron, p_number, id_position, id_org, event_name) values ('"+name_box.Text+"','"+surname_box.Text+"','"+patron_box.Text+"','"+number_box.Text+"',"+(pos_box.SelectedIndex+1).ToString()+","+(org_box.SelectedIndex+1).ToString()+",'"+event_box.Text+"');");
                    name_label.Visible = true;
                    surname_label.Visible = true;
                    patron_label.Visible = true;
                    number_label.Visible = true;
                    pos_label.Visible = true;
                    org_label.Visible = true;
                    event_label.Visible = true;

                    name_box.Visible = false;
                    surname_box.Visible = false;
                    patron_box.Visible = false;
                    number_box.Visible = false;
                    pos_box.Visible = false;
                    org_box.Visible = false;
                    event_box.Visible = false;
                    del_btn.Visible = true;
                    chng_btn.Text = "Изменить данные";
                    string query = "select max(id_participant) from participant;";
                    MySqlConnection conn = DBUtils.GetDBConnection();
                    MySqlCommand cmDB = new MySqlCommand(query, conn);
                    try
                    {
                        conn.Open();
                        ID_part = Convert.ToInt32(cmDB.ExecuteScalar());
                        conn.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                    }
                    get_Info(ID_part);
                    break;
                case "Изменить данные":
                    chng_btn.Text = "Сохранить данные";
                    name_label.Visible = false;
                    surname_label.Visible = false;
                    patron_label.Visible = false;
                    number_label.Visible = false;
                    pos_label.Visible = false;
                    org_label.Visible = false;
                    event_label.Visible = false;
                    
                    name_box.Visible = true;
                    surname_box.Visible = true;
                    patron_box.Visible = true;
                    number_box.Visible = true;
                    pos_box.Visible = true;
                    org_box.Visible = true;
                    event_box.Visible = true;
                    del_btn.Visible = false;
                    
                    name_box.Text = name_label.Text;
                    surname_box.Text = surname_label.Text;
                    patron_box.Text = patron_label.Text;
                    number_box.Text = number_label.Text;
                    pos_box.Text = pos_label.Text;
                    org_box.Text = org_label.Text;
                    event_box.Text = event_label.Text;
                    break;
                case "Сохранить данные":
                    doAction("update participant set p_name='"+name_box.Text+"',p_surname='"+surname_box.Text+"',p_patron='"+patron_box.Text+"',p_number='"+number_box.Text+"',id_position="+(pos_box.SelectedIndex+1).ToString()+",id_org="+(org_box.SelectedIndex+1).ToString()+",event_name='"+event_box.Text+"' where id_participant= "+ID_part.ToString()+";");
                    name_label.Visible = true;
                    surname_label.Visible = true;
                    patron_label.Visible = true;
                    number_label.Visible = true;
                    pos_label.Visible = true;
                    org_label.Visible = true;
                    event_label.Visible = true;

                    name_box.Visible = false;
                    surname_box.Visible = false;
                    patron_box.Visible = false;
                    number_box.Visible = false;
                    pos_box.Visible = false;
                    org_box.Visible = false;
                    event_box.Visible = false;
                    del_btn.Visible = true;
                    chng_btn.Text = "Изменить данные";
                    get_Info(ID_part);
                    break;

            }
        }
        public void doAction(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки информации!" + Environment.NewLine + ex.Message);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить строку?", "", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                doAction("delete from participant where id_participant =" + ID_part + ";");
                Owner.Show();
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void class_box_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void vulnerability_box_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void type_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            pos_box.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void loot_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            org_box.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void name_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void number_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void event_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}
