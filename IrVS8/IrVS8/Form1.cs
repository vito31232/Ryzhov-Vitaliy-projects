using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrVS8
{
    public partial class Form1 : Form
    {
        int[] a = new int[1000];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n;
            listBox1.Items.Clear();
            n = Convert.ToInt32(textBox1.Text);
            listBox1.Text = ""; 
            for (i = 0; i <= n-1; i++)
            {
                a[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ai=", "Enter array", ""));
                listBox1.Items.Add(a[i]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int i, n;
            double s;
            n = Convert.ToInt32(textBox1.Text);
            s = 1;
            for (i = 0; i <= n - 1;) 
            {
                s = s * a[i];
                i = i + 3;
            }
            label3.Text = "";
            label3.Text = "Произведение = " + Convert.ToString(s);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label3.Text = "ИДИ НАХУЙ!";
        }
    }
}
    