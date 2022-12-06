using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchebnayaPraktika
{
    public partial class FormMenu : Form
    {
        FormWork1 Work1 = new FormWork1();
        FormWork2 Work2 = new FormWork2();
        FormWork3 Work3 = new FormWork3();
        FormWork4 Work4 = new FormWork4();
        public FormMenu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Work3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Work4.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
