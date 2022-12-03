using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UchebnayaPraktika
{
    public partial class FormWork2 : Form
    {
        public FormWork2()
        {
            InitializeComponent();
        }

        private void FormWork2_Load(object sender, EventArgs e)
        {

        }
        
        public class con
        {
            public string host = "chuc.caseum.ru";
            public string port = "33333";
            public string user = "uchebka";
            public string based = "uchebka";
            public string password = "uchebka";
        }

        MySqlConnection conn;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con connection = new con();
                conn = new MySqlConnection($"server={connection.host};port={connection.port};user={connection.user};database={connection.based};password={connection.password};");
                conn.Open();
                MessageBox.Show("Подключение к базе прошло успешно");
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
