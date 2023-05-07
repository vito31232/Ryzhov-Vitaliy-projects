using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrVS9
{
    public partial class Form1 : Form
    {
        int[] a = new int[100];
        double[] b = new double[100];
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i,n;
            double s,s1,s2;
            n = Convert.ToInt32(textBox1.Text);
            listBox2.Items.Clear();
            listBox1.Items.Clear(); 
            Random rnd = new Random();
            for (i = 1; i <= n; i++) 
            {
                a[i] = rnd.Next(-100, 101);
                listBox1.Items.Add(a[i]);
            }
            b[1] = a[1];
            listBox2.Items.Add(b[1]);
            for (i = 2; i <= n; i++) 
            {
                s1 = a[i - 1];
                s2 = a[i];
                s = s1 / s2;
                b[i+1] = s;
                listBox2.Items.Add(b[i + 1]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
