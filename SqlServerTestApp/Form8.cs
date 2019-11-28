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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            comboBox2.KeyPress += (sender, e) => e.Handled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string cb1 = ((IdentityItem)comboBox1.SelectedItem)?.Id;
            string cb2 = ((IdentityItem)comboBox2.SelectedItem)?.Id;
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string tb3 = textBox3.Text;
            string query6 = "insert into dbo.[Сотрудники] ([Должность],[Зарплата], [Фамилия], [Имя], [Отчество]) values('" + cb1 + "','" + cb2 + "','" + tb1 + "','" + tb2 + "','" + tb3 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query6);
            MessageBox.Show("добавлено " + count + " строк");
        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [Должность], [Должность] from [Сотрудники]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void ComboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [Зарплата], [Зарплата] from [Сотрудники]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
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

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
    }
}
