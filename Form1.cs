﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0 && textBox2.Text.Length>0)
            {
                Form2 travel = new Form2();
                travel.Show();
                this.Hide();
            }
            else
            {
                label4.Visible = true;
                label4.Text = ("You enter wrong E-mail or password");
                label4.BackColor = Color.Red;
            }

        }
    }
}
