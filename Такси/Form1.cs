using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string connection = "Server=localhost;Database=TAXI;Uid=root;password=192817istra;charset=utf8";
        private MySqlConnection conn; //коннектор к БД
        private MySqlCommand cmd; //
        private MySqlDataAdapter adapter; //Предоставляет выборку из запроса
        private System.Data.DataTable dt; //Отображает, что находится в памяти сейчас
        private BindingSource binding_source;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(connection);
            conn.Open();
        }
        ~Form1()
        {
            conn.Close();
        }
        private void send(string dudik)
        {
            adapter = new MySqlDataAdapter(dudik, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            binding_source = new BindingSource();
            binding_source.DataSource = dt;
            dataGridView1.DataSource = binding_source;
        }
        private void send1(string nahui)
        {
            adapter = new MySqlDataAdapter(nahui, connection);
            MySqlCommandBuilder myCommandBuilder = new MySqlCommandBuilder(adapter as MySqlDataAdapter);
            adapter.InsertCommand = myCommandBuilder.GetInsertCommand();
            adapter.UpdateCommand = myCommandBuilder.GetUpdateCommand();
            adapter.DeleteCommand = myCommandBuilder.GetDeleteCommand();
            dt = new DataTable();   
            adapter.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
        }
        private void button1_Click_1(object sender, EventArgs e) // вывод списка клиентов
        {
            try
            {
                send1("SELECT * FROM taxi.client;");
            }
            catch (Exception lol)
            {
                MessageBox.Show(lol.Message.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e) // вывод списка операторов
        {
            try
            {
                send1("SELECT * FROM taxi.operator;");
            }
            catch (Exception lol)
            {
                MessageBox.Show(lol.Message.ToString());
            }
        }
        private void button3_Click(object sender, EventArgs e) // вывод списка заказов
        {
            try
            {
                send1("SELECT * FROM taxi.orders;");
            }
            catch (Exception lol)
            {
                MessageBox.Show(lol.Message.ToString());
            }
        }
        private void button4_Click(object sender, EventArgs e) // вывод списка водителей
        {
            try
            {
                send1("SELECT * FROM taxi.driver;");
            }
            catch (Exception lol)
            {
                MessageBox.Show(lol.Message.ToString());
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e) // добавление
        {
            try
            {
                adapter.Update(dt);
            }
            catch (Exception lol)
            {
                MessageBox.Show(lol.Message.ToString());
            }
        }
        private void button5_Click(object sender, EventArgs e) // удаление
        {
            if(MessageBox.Show("Удалить?","Удаление",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    adapter.Update(dt);
                }
                catch (Exception lol)
                {
                    MessageBox.Show(lol.Message.ToString());
                }
            }
        }
        private void button6_Click(object sender, EventArgs e) // пользовательский поиск
        {
            try
            {
                send1(textBox1.Text);
            }
            catch (Exception lol)
            {
                MessageBox.Show(lol.Message.ToString());
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) // с
        {

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) // по
        {

        }
        private void button7_Click(object sender, EventArgs e) // вывод заказов за опр промежуток
        {
            try
            {
                send1($"select * from taxi.orders where data between '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' and '{dateTimePicker2.Value.ToString("yyyy-MM-dd")}'");
            }
            catch
            {

            }
        }
        private void button8_Click(object sender, EventArgs e) // вывод заказов с опр клиентом ID
        {
            try
            {
                send1($"select * from taxi.orders where client_ID_client='{textBox2.Text}';");
            }
            catch
            {

            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e) // поле для ввода ID
        {

        }

        private void button10_Click(object sender, EventArgs e) // вывод заказов за опр время
        {
            try
            {
                send($"SELECT SUM(amount) FROM taxi.orders where data between '2022-03-01' and '2022-03-25';"); // забыл сделать datatimepicker но и пофиг
            }
            catch 
            {
               
            }
        }

        private void button11_Click(object sender, EventArgs e) // вывод заработной платы у водителя
        {
            try
            {
                send($"select sum(amount)*0.3 as profit from taxi.orders where driver_ID_driver='{textBox3.Text}' and data between '{dateTimePicker3.Value.ToString("yyyy-MM-dd")}' and '{dateTimePicker3.Value.ToString("yyyy-MM-dd")}';");
            }
            catch 
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // ID водителя для прибыли за день
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e) // дата для прибыли за день
        {

        }

        private void button12_Click(object sender, EventArgs e) // вывод прибыли 
        {
            try
            {
                send($"select sum(amount)*0.7 as profit from taxi.orders;");
            }
            catch
            {

            }
        }
    }
    }
  