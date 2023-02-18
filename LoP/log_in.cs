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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            log_box.MaxLength = 50;
            pass_box.MaxLength = 50;
        }

        private void crt_btn_Click(object sender, EventArgs e)
        {
            string query = "select id_user FROM register where login_user ='"+log_box.Text+"'and password_user ='"+pass_box.Text+"';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                int result = 0;
                result = Convert.ToInt32(cmDB.ExecuteScalar());
                if (result > 0)
                {
                    menu Win = new menu(result);
                    Win.Owner = this;
                    this.Hide();
                    Win.Show();
                    log_box.Clear();
                    pass_box.Clear();
                }
                else
                    MessageBox.Show("Такого аккаунта не существует");
                log_box.Clear();
                pass_box.Clear();
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка" + Environment.NewLine + ex.Message);
            }
        }


        private void clear_btn_Click(object sender, EventArgs e)
        {
            log_box.Text = "";
            pass_box.Text = "";
        }

        private void pass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_checkBox.Checked)
            {
                pass_box.UseSystemPasswordChar = false;
            }
            else
            {
                pass_box.UseSystemPasswordChar = true;
            }
        }
    }
}
