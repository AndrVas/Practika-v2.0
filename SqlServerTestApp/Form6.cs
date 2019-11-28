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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            comboBox2.KeyPress += (sender, e) => e.Handled = true;
            comboBox3.KeyPress += (sender, e) => e.Handled = true;
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
            string cb3 = ((IdentityItem)comboBox3.SelectedItem)?.Id;
            string query = $@"Insert into [dbo].[Обслуживание] ([Код номера], [Код клиента], [Виды обслуживания], [Дата обслуживания]) VALUES ('" + cb1 + "','" + cb2 + "','" + cb3 + "','" + dateTimePicker1.Value + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено " + count + " строк");
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            {
                string query = "select [ID номера], [Номер] from [Номера]";
                var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(list);
            }
        }

        private void ComboBox2_DropDown(object sender, EventArgs e)
        {
            {
                string query = "select [ID клиента], [Фамилия]+' '+[Имя]+' '+[Отчество] from [Клиенты]";
                var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(list);
            }
        }

        private void ComboBox3_DropDown(object sender, EventArgs e)
        {
            {
                string query = "select [Виды обслуживания], [Виды обслуживания] from [Обслуживание]";
                var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(list);
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
