using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[20];
        private void button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            listBox1.Items.Clear();
            for(int i = 0;i<20;i++)
            {
                a[i] = x.Next(-100, 100);
                listBox1.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int max = -101;
           for (int i = 0; i < 20; i++)
            {
                if (a[i] > max)
                    max = a[i];        
            }
            for (int i = 0; i < 20; i++)
            {
                if (a[i] == max)
                {
                    int t = a[0];
                    a[0] = a[i];
                    a[i] = t;
                    break;
                }
                    
            }
            for (int i = 0; i < 20; i++)
            {
                listBox2.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());

            }


        }
    }
}
