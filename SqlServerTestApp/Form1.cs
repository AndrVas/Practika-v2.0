using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }



        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0) return;
            int x;
            if (int.TryParse(textBox3.Text, out x))
            {
                if (x < 0) textBox3.Text = "0";
                if (x > 10) textBox3.Text = "30";
            }
            else
                textBox3.Text = "";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }


        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            {
                char l = e.KeyChar;
                if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                {
                    e.Handled = true;
                }
            }
        }
        private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length == 0) return;
            int x;
            if (int.TryParse(textBox7.Text, out x))
            {
                if (x < 0) textBox7.Text = "0";
                if (x > 10) textBox7.Text = "10";
            }
            else
                textBox7.Text = "";
        }
        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string tb3 = textBox3.Text;
            string tb4 = textBox4.Text;
            string tb5 = textBox5.Text;
            string tb6 = textBox6.Text;
            string tb7 = textBox7.Text;
            string tb8 = textBox8.Text;

            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int u = Convert.ToInt32(textBox3.Text);
            int i = Convert.ToInt32(textBox4.Text);
            int o = Convert.ToInt32(textBox7.Text);

            string query = "INSERT INTO dbo.Номера ([Номер телефона гостиницы], [Номер], [Вместимость], [Цена], [Город], [Название], [Комфортность], [Страны]) VALUES ('" + tb1 + "','" + tb2 + "','" + tb3 + "','" + tb4 + "','" + tb5 + "','" + tb6 + "','" + tb7 + "','" + tb8 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено" + count + "строк");
        }

        private void MaskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (temp.Text.Length > 0)
                if (System.Convert.ToInt64(temp.Text) > 99999999999)
                    temp.Text = " ";
        }
    }
}

