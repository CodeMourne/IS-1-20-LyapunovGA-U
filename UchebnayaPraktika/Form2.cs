﻿using System;
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

        class HD : Complects
        {
            public string rpm;
            public string inter;
            public string gig;
            public HD(string cost, string year, string rpm, string inter, string gig) : base(cost, year)
            {
                this.rpm = rpm;
                this.inter = inter;
                this.gig = gig;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                HD hd = new HD(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                listBox1.Items.Clear();
                listBox1.Items.Add($"Цена комплектующей части: {hd.cost}руб. Год выпуска: {hd.year}");
                listBox1.Items.Add($"Количество оборотов жёсткого диска: {hd.rpm}. Интерфейс: {hd.inter}. Объём: {hd.gig}");
            }
            catch
            {
                MessageBox.Show($"Указанные переменные в textbox неверны и не принимаются программой");
            }
        }
    }
}
