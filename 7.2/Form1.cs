using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = rand.Next(-100, 100);

                listBox1.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int min = 101;
            for (int i = 0; i < 10; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            for (int i = 0; i < 10; i++)
            {
                if (a[i] == min)
                {
                    int t = a[8];
                    a[8] = a[i];
                    a[i] = t;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());

            }

        }
    }
}
