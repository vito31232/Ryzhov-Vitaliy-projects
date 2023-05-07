using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrVS10
{
    public partial class Form1 : Form
    {
        int[] A = new int[100];
        int[] B = new int[100];
        public Form1()
        {           
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i_A,i_B=0, n;
            n = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (i_A = 0; i_A <= n-1; i_A++)
            {
                A[i_A] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ai=", "Enter array", "")); // заполнение массива
                listBox1.Items.Add(A[i_A]); // вывод массива
            }
            for (i_A = 0; i_A <= n-1; i_A++)
            {
                if (A[i_A] != 0)
                {
                    B[i_B] = A[i_A];
                    i_B++;
                }
            }
            i_B = 0;
            for (i_A = 0; i_A <= n-1; i_A++)
            {
                A[i_A] = B[i_B];
                i_B++;
            }
            for (i_A = 0; i_A <= n-1; i_A++)
            {
                listBox2.Items.Add(A[i_A]);
            }
        }   
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
