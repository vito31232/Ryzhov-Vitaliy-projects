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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IrSV7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Введите точность","Точность =", "0,001");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int n;
            double toch, s, sl;
            toch = Convert.ToDouble(textBox1.Text);
            n = 1; sl = toch +1; s = 0;
            while(sl > toch)
            {
            sl = (1.0 / (n * (n + 2.0))); n++; s = s + sl;
            }
            label3.Text = Convert.ToString(s);
            label5.Text = Convert.ToString(n);
            label7.Text = Convert.ToString(sl);
        }
    }
}

//int n;
//double toch, s, sl;
//toch = Convert.ToDouble(textBox1.Text);
//n = 1; sl = 1; s = sl;
//while (sl > toch)
//{
//    n++; sl = sl / n * (n + 2); s = s + sl;
//}
//label3.Text = Convert.ToString(s);
//label5.Text = Convert.ToString(n);
