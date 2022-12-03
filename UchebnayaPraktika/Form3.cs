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
        
        public class conn
        {
            public string host = "chuc.caseum.ru";
            public string port = "33333";
            public string user = "uchebka";
            public string based = "uchebka";
            public string password = "uchebka";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
