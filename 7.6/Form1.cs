using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[35];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            
            Random rand = new Random();
            for (int i = 0; i < 35; i++)
            {
                a[i] = rand.Next(-50, 50);

                listBox1.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0, p = 1;
            for (int i = 0; i < 35; i++) 
            {
                if ((a[i] % 2 == 0) && (a[i] < 3))
                    s += a[i];
                if (!(a[i] % 2 == 0) && (a[i] > 1))
                    p += a[i];
            }
            textBox1.Text = (s + p).ToString();
        }
    }
}
