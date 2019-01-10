﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() => GetNum(textBox1)); t1.Start();
        }

        Random r = new Random();
        private void GetNum(TextBox t)
        {
            int n = r.Next(1, 46);
            SetText(t, n);
        }
        public void SetText(TextBox t, int n)
        {
            if (t.InvokeRequired)
            {
                Invoke((Action<TextBox, int>)SetText, t, n);
            }
            else
            {
                t.Text = n.ToString();
            }
        }
    }
}