﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformdle
{
    public partial class Form3 : Form
    {
        public Form3(string guessWord)
        {
            InitializeComponent();
            label2.Text = guessWord;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            this.Hide();
            this.ResetText();
            form2.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
