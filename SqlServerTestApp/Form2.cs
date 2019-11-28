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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string tb3 = textBox3.Text;
            string tb4 = textBox4.Text;
            string cb1 = ((IdentityItem)comboBox1.SelectedItem)?.Id;
            bool tb5 = checkBox1.Checked;
            int x = Convert.ToInt32(textBox4.Text);
            string query1 = $@"Insert into [dbo].[Клиенты] ([Фамилия], [Имя], [Отчество], [Паспортные данные], [Постаянный клиент], [Код скидки]) VALUES ('" + tb1 + "','" + tb2 + "','" + tb3 + "','" + tb4 + "','" + (tb5 ? 1 : 0) + "','" + cb1 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query1);
            MessageBox.Show("добавлено " + count + " строк");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (temp.Text != null && temp.Text.Length > 10)
            {
                temp.Text = temp.Text.Substring(0, 10);
            }
        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID скидки], [Тип скидки] from [dbo].[Процент скидок]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

