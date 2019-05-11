using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._7
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
            listBox1.Items.Clear();


            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                a[i] = rand.Next(-50, 50);

                listBox1.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                if ((a[i] % 7 == 1) || (a[i] % 7 == 2) || (a[i] % 7 == 5))
                    listBox2.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());
            }
        }
    }
}
