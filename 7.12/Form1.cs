using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[15];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

           
           Random rand = new Random();
           for (int i = 0; i < 15; i++)
            {
                a[i] = rand.Next(-50, 50);

                listBox1.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int x = a[0];
            listBox2.Items.Clear();
            for (int i=0;i<15;i++)
            {  
                if (i < 14)
                    a[i] = a[i+1];            
            }
            a[14] = x;
            for (int i = 0; i < 15; i++)
            {
                listBox2.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());
            }
        }
    }
}
