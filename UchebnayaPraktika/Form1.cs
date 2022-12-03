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
        public FormMenu()
        {
            InitializeComponent();
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work2.ShowDialog();
        }
    }
}
