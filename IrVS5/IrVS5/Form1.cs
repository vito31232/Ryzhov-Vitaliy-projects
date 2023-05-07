using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IrVS5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Input x1", "Data Input", "0");
            textBox2.Text = Microsoft.VisualBasic.Interaction.InputBox("Input x2", "Data Input", "0");
            double x1, x2, w;
            x1 = Convert.ToDouble(textBox1.Text);
            x2 = Convert.ToDouble(textBox2.Text);
            if (x1 < 0 && x2 < 0)
            {
                w = Math.Abs(x1 - 2.5 * x2) / 2.3;
            }
            else
            {
                w = 2.5 * x1 + Math.Sqrt(Math.Abs(x2));
            }
            textBox3.Text = Convert.ToString(w);
            if (w < 0) textBox3.ForeColor = Color.Red;
            else textBox3.ForeColor = Color.Blue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, w;       
            x1 = Convert.ToDouble(textBox1.Text);
            x2 = Convert.ToDouble(textBox2.Text);
            if (x1 < 0 && x2 < 0)
            {
                w = Math.Abs(x1 - 2.5 * x2) / 2.3;
            }
            else
            {
                w = 2.5 * x1 + Math.Sqrt(Math.Abs(x2));
            }
            textBox3.Text = Convert.ToString(w);
            if (w < 0) textBox3.ForeColor = Color.Red;
            else textBox3.ForeColor = Color.Blue;
        }   
    }
}