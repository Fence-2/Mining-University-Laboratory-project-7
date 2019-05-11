﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[30];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();           
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                a[i] = rand.Next(-100, 100);

                listBox1.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0;i<30;i++)
            {
                if ((a[i] % 5 == 0) && !(a[i] % 7 == 0))
                    sum += a[i];
            }
            textBox1.Text = sum.ToString();
        }
    }
}
