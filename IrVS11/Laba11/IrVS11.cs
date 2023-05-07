using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                comboBox1.Items.Add(Convert.ToString(i + 1));
                comboBox2.Items.Add(Convert.ToString(i + 1));
                comboBox3.Items.Add(Convert.ToString(i - 3));
                if (i != 0)
                {
                    comboBox4.Items.Add(Convert.ToString(i));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, n, minZn, maxZn;
            int[,] a = new int[100, 100];
            m = Convert.ToInt32(comboBox1.Text);
            n = Convert.ToInt32(comboBox2.Text);
            dataGridView1.RowCount = m + 1;
            dataGridView1.ColumnCount = n + 1;
            minZn = Convert.ToInt32(comboBox3.Text);
            maxZn = Convert.ToInt32(comboBox4.Text);
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = " ";
                }
            }
            Random rnd = new Random();
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    a[i, j] = rnd.Next(minZn, maxZn);
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
            }
            for (int i = 1; i <= m; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i);
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridView1.Rows[0].Cells[j].Value = Convert.ToString(j);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}