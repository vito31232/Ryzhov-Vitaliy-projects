using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrVS3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            button1.Text = "";
            x = Convert.ToDouble(textBox1.Text);
            y = Math.Abs(x);
            button1.Text = button1.Text + Convert.ToString(y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y;
            button2.Text = "";
            x = Convert.ToDouble(textBox2.Text);
            y = Math.PI * x / 180;
            button2.Text = button2.Text + Convert.ToString(y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y;
            button3.Text = "";
            x = Convert.ToDouble(textBox3.Text);
            y = 180*x/Math.PI;
            button3.Text = button3.Text + Convert.ToString(y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y;
            button4.Text = "";
            x = Convert.ToDouble(textBox4.Text);
            y = Math.Log(x);
            button4.Text = button4.Text + Convert.ToString(y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x, y;
            button5.Text = "";
            x = Convert.ToDouble(textBox5.Text);
            y =Math.Log10(x);
            button5.Text = button5.Text + Convert.ToString(y);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x, y;
            button6.Text = "";
            x = Convert.ToDouble(textBox6.Text);
            y = Math.Sin(x);
            button6.Text = button6.Text + Convert.ToString(y);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double x, y;
            button7.Text = "";
            x = Convert.ToDouble(textBox7.Text);
            y = Math.Sqrt(x);
            button7.Text = button7.Text + Convert.ToString(y);   
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double x, y;
            button8.Text = "";
            x = Convert.ToDouble(textBox8.Text);
            y = Math.Exp(x);
            button8.Text = button8.Text + Convert.ToString(y);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a, x, y;
            button9.Text = "";
            a = Convert.ToDouble(textBox10.Text);
            x = Convert.ToDouble(textBox9.Text);
            y = Math.Pow(a, x);
            button9.Text = button9.Text + Convert.ToString(y);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
