using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace UchebnayaPraktika
{
    public partial class FormWork4 : Form
    {
        MySqlConnection conn;
        int rows;
        public class con
        {
            static public MySqlConnection Connection()
            {
                string con = $"server=chuc.caseum.ru;port=33333;user=st_1_20_20;database=is_1_20_st20_KURS;password=65218328;";
                MySqlConnection conn = new MySqlConnection(con);
                return conn;
            }
        }
        public FormWork4()
        {
            InitializeComponent();
            conn = con.Connection();
            try
            {
                conn.Open();
                string sql = $"SELECT\r\n\tauth_data.id_auth, \r\n\tauth_data.fio_auth, \r\n\tauth_data.login, \r\n\tauth_data.accessed_rooms_auth, \r\n\tauth_data.level_access_auth, \r\n\tauth_data.photo_auth\r\nFROM\r\n\tauth_data\r\n\tINNER JOIN\r\n\tpersonnel\r\n\tON \r\n\t\tauth_data.fio_auth = personnel.id_personnel";
                //наследуемая таблица / поле наследующей таблицы / поле наследуемой таблицы                                                          
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rows = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rows].Cells[0].Value = reader[0].ToString();
                    dataGridView1.Rows[rows].Cells[1].Value = reader[1].ToString();
                    dataGridView1.Rows[rows].Cells[2].Value = reader[2].ToString();
                    dataGridView1.Rows[rows].Cells[3].Value = reader[3].ToString();
                    dataGridView1.Rows[rows].Cells[4].Value = reader[4].ToString();
                    dataGridView1.Rows[rows].Cells[5].Value = reader[5].ToString();
                    

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var url = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            pictureBox1.ImageLocation = url;
            MessageBox.Show("Выведено");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
