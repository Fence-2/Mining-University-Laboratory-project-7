﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[12];
        int s = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            
            Random rand = new Random();
            for (int i = 0; i < 12; i++)
            {
                a[i] = rand.Next(-50, 50);

                listBox1.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i =0;i<12;i++)
            {
                if (a[i] % 2 == 0)
                    s += a[i];

            }
            textBox1.Text = s.ToString();
        }
    }
}
