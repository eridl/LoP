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
    public partial class menu : Form
    {
        public int ID = 0;
        public menu(int ID_log)
        {
            InitializeComponent();
            ID = ID_log;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                conn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("Не удалось открыть страницу." + Environment.NewLine + ex.Message);
            }
            participants win = new participants(ID);
            win.Owner = this;
            this.Hide();
            win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Памятка работнику, ответственному за учет участников благотворительных акций или иных видов оказания финансовой/волонтерской помощи среди сотрудиков."+Environment.NewLine+""+Environment.NewLine+ "Раз в две недели необходимо обновлять информацию в этой таблице. Предыдущий работник организовал автоматическую рассылку на почту всем сотрудникам. Если будешь делать также, то предупреди всех. Весь необходимый функционал для твоей работы присутствует."+Environment.NewLine+""+Environment.NewLine+ "Если за две недели в таблице произошли какие-либо изменения, то сохраняешь ее в .pdf и высылаешь на почту моему менеджеру, ее адрес висит на стенке справа от ПК на желтом стикере.");
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }
    }
}
