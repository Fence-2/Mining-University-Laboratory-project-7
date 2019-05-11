using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] mas = new int[30];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                mas[i] = rand.Next(-100, 100);
                listBox1.Items.Add("mas[" + i.ToString() + "] = " + mas[i].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0;i<30;i++)
            {
                if ((mas[i] % 2 == -1) && (mas[i] < 0))
                    sum =  sum + mas[i];
            }
            textBox1.Text = sum.ToString();
        }
    }
}
