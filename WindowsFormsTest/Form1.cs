﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<string> words = new List<string>();
            Font f = new Font("", 7);         

            words.Add("te");
            words.Add("[.]");
            Class2 c = new Class2();
            c.CheckKeyword(this.richTextBox1, words, 0, Color.Gray, this.ForeColor, f, this.Font);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
