using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrVS6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Input n", "Data Input", "0");
            int i, n;
            double sl, s;   
            n = Convert.ToInt32(textBox1.Text);
            sl = 1; s = sl;
            for (i = 1; i <= n; i++)
            {
                sl = Math.Pow(-1, i - 1) * (sl / Math.Pow(i, 4)); s = s + sl;
            }
            MessageBox.Show("S=" + Convert.ToString(s),
                "Результат: ", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n;
            double sl, s;
            n = Convert.ToInt32(textBox1.Text);
            sl = 1; s = sl;
            for (i = 1; i <= n; i++)
            {
                sl = Math.Pow(-1,i-1)*(sl/Math.Pow(i,4)); s = s + sl;
            }
            MessageBox.Show("S=" + Convert.ToString(s),
                "Результат: ", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
    }
}
