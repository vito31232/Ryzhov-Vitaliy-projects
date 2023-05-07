using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrVS4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, x, y;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            x = Convert.ToDouble(textBox4.Text);
            y = Math.Pow(a,x) + (b / Math.Pow(x,c));
            DialogResult result= MessageBox.Show("Y =" + Convert.ToString(y),
                "Результат:", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes) textBox1.BackColor = Color.Green;
            if (result == DialogResult.No) label2.BackColor = Color.Red;
            if (result == DialogResult.Cancel) button1.BackColor = Color.Yellow;
        }
    }
}
