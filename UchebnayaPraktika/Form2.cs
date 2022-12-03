using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UchebnayaPraktika
{
    public partial class FormWork1 : Form
    {
        public FormWork1()
        {
            InitializeComponent();
        }

        private void FormWork1_Load(object sender, EventArgs e)
        {

        }

        class Complects
        {
            public string cost;
            public string year;
            public Complects(string cost, string year)
            {
                this.cost = cost;
                this.year = year;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Complects work = new Complects(textBox1.Text, textBox2.Text);
                listBox1.Items.Clear();
                listBox1.Items.Add($"Цена комплектующей части: {work.cost}руб. Год выпуска: {work.year}");
            }
            catch
            {
                MessageBox.Show($"Указанные переменные в textbox неверны и не принимаются программой");
            }
        }
    }
}
