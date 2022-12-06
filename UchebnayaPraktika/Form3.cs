using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UchebnayaPraktika
{

    public partial class FormWork2 : Form
    {
        MySqlConnection conn;
        public FormWork2()
        {
            
        }

        private void FormWork2_Load(object sender, EventArgs e)
        {

        }
        
        public class con
        {
            static public string host = "chuc.caseum.ru";
            static public string port = "33333";
            static public string user = "uchebka";
            static public string based = "uchebka";
            static public string password = "uchebka";
            
            static public MySqlConnection Connection()
            {
                string con = $"server={host};port={port};user={user};database={based};password={password};";
                MySqlConnection conn = new MySqlConnection(con);
                return conn;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = con.Connection();
                conn.Open();
                MessageBox.Show("Всё работает");
            }
            catch
            {
                MessageBox.Show("Подключение не удалось");
            }
            finally 
            {
                conn.Close();
            }
        }
    }
}
