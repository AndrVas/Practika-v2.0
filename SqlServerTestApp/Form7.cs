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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            comboBox2.KeyPress += (sender, e) => e.Handled = true;
            comboBox3.KeyPress += (sender, e) => e.Handled = true;
            comboBox4.KeyPress += (sender, e) => e.Handled = true;
            comboBox5.KeyPress += (sender, e) => e.Handled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [Виды развлечений], [Виды развлечений] from [Развлечения]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void ComboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [Цена], [Цена] from [Развлечения]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
        }

        private void ComboBox3_DropDown(object sender, EventArgs e)
        {
            string query = "select [Вместимость людей], [Вместимость людей] from [Развлечения]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }

        private void ComboBox4_DropDown(object sender, EventArgs e)
        {
            string query = "select [Город], [Город] from [Развлечения]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(list);
        }

        private void ComboBox5_DropDown(object sender, EventArgs e)
        {
            string query = "select [Название гостиницы], [Название гостиницы] from [Развлечения]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list);
        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)

        {
            string tb1 = dateTimePicker1.Value.ToShortDateString();

            string cb1 = ((IdentityItem)comboBox1.SelectedItem)?.Id;
            string cb2 = ((IdentityItem)comboBox2.SelectedItem)?.Id;
            string cb3 = ((IdentityItem)comboBox3.SelectedItem)?.Id;
            string cb4 = ((IdentityItem)comboBox4.SelectedItem)?.Id;
            string cb5 = ((IdentityItem)comboBox5.SelectedItem)?.Id;
            string query6 = "insert into dbo.[Развлечения] ([Виды развлечений], [Цена], [Вместимость людей], [Город], [Название гостиницы], [Дата]) values('" + cb1 + "','" + cb2 + "','" + cb3 + "','" + cb4 + "','" + cb5 + "','" + tb1 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query6);
            MessageBox.Show("добавлено " + count + " строк");
        }

    }
}
