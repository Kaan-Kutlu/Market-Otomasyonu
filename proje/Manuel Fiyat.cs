﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Manuel_Fiyat : Form
    {
        public Manuel_Fiyat()
        {
            InitializeComponent();
        }

        private void Manuel_Fiyat_Load(object sender, EventArgs e)
        {

        }
        public static double ftt;
        public static double eski;
        private void Manuel_Fiyat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBox1.Text == "") { ftt = eski; }
            else
            {
                ftt = Convert.ToDouble(textBox1.Text);
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            catch { MessageBox.Show("Daha fazla silinemez"); }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
