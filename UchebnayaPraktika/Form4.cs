using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
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
using System.Data.SqlClient;

namespace UchebnayaPraktika
{
    public partial class FormWork3 : Form
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


        public FormWork3()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           conn = con.Connection();
            try
            {
                conn.Open();
                string sql = $"SELECT auth_data.id_auth, auth_data.fio_auth, auth_data.login, auth_data.accessed_rooms_auth, auth_data.level_access_auth FROM auth_data INNER JOIN personnel ON auth_data.fio_auth = personnel.id_personnel";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"ID пользователя: {dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()}, ФИО пользователя:{dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()} , доступные комнаты:{dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()} , уровень доступа: {dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()}");
        }
    }
}
