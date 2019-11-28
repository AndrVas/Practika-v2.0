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
    public partial class Form10 : Form
    {
        public Form10()
        {
           
            
                InitializeComponent();
                comboBox1.KeyPress += (sender, e) => e.Handled = true;
                comboBox2.KeyPress += (sender, e) => e.Handled = true;
                comboBox3.KeyPress += (sender, e) => e.Handled = true;
                comboBox4.KeyPress += (sender, e) => e.Handled = true;
                comboBox5.KeyPress += (sender, e) => e.Handled = true;
                comboBox6.KeyPress += (sender, e) => e.Handled = true;
                comboBox7.KeyPress += (sender, e) => e.Handled = true;

        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID клиента], [Фамилия]+' '+[Имя]+' '+[Отчество] from [dbo].[Клиенты]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox1.SelectedItem)?.Id);
            string query = "Delete from dbo.Клиенты where [ID клиента]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result >0)
            {
                MessageBox.Show("Удалено");
                comboBox1.SelectedItem = null;
            }

        }

       

        private void Button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID клиента],[Постаянный клиент],[Фамилия],[Имя],[Отчество],[Паспортные данные]

             FROM [dbo].[Клиенты]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID клиента", "ID клиента");
            dataGridView1.Columns.Add("Постаянный клиент", "Постаянный клиент");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("Паспортные данные", "Паспортные данные");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
            dataGridView1.Refresh();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void ComboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID номера], [Название] from [dbo].[Номера]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID номера], [Номер телефона гостиницы], [Номер], [Вместимость], [Цена], [Город], [Название], [Комфортность], [Страны]

             FROM [dbo].[Номера]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID номера", "ID номера");
            dataGridView1.Columns.Add("Номер телефона гостиницы", "Номер телефона гостиницы");
            dataGridView1.Columns.Add("Номер", "Номер");
            dataGridView1.Columns.Add("Вместимость", "Вместимость");
            dataGridView1.Columns.Add("Цена", "Цена");
            dataGridView1.Columns.Add("Город", "Город");
            dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Комфортность", "Комфортность");
            dataGridView1.Columns.Add("Страны", "Страны");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }
            dataGridView1.Refresh();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox2.SelectedItem)?.Id);
            string query = "Delete from dbo.Номера where [ID номера]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Удалено");
                comboBox2.SelectedItem = null;
            }
        }

        private void ComboBox3_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID Обслуживания], [Виды обслуживания] from [dbo].[Обслуживание]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox3.SelectedItem)?.Id);
            string query = "Delete from dbo.Обслуживание where [ID Обслуживания]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Удалено");
                comboBox3.SelectedItem = null;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID обслуживания],[Дата обслуживания],[Виды обслуживания]

             FROM [dbo].[Обслуживание]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("[ID сотрудника]", "[ID сотрудника]");
            dataGridView1.Columns.Add("[Дата обслуживания]", "[Дата обслуживания]");
            dataGridView1.Columns.Add("[Виды обслуживания]", "[Виды обслуживания]");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
            dataGridView1.Refresh();
        }

        private void ComboBox4_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID поселения], [Дата поселения] from [dbo].[Поселение]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(list);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox4.SelectedItem)?.Id);
            string query = "Delete from dbo.Поселение where [ID поселения]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Удалено");
                comboBox4.SelectedItem = null;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID поселения],[Дата поселения],[Дата освобождения]

             FROM [dbo].[Поселение]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID поселения", "ID поселения");
            dataGridView1.Columns.Add("Дата поселения", "Дата поселения");
            dataGridView1.Columns.Add("Дата освобождения", "Дата освобождения");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
            dataGridView1.Refresh();
        }

        private void ComboBox5_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID скидки], [Тип скидки] from [dbo].[Процент скидок]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox5.SelectedItem)?.Id);
            string query = "Delete from [dbo].[Процент скидок] where [ID скидки]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Удалено");
                comboBox5.SelectedItem = null;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID скидки],[Скидки],[Тип скидки], [Дата]

             FROM [dbo].[Процент скидок]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID скидки", "ID скидки");
            dataGridView1.Columns.Add("Скидки", "Скидки");
            dataGridView1.Columns.Add("Тип скидки", "Тип скидки");
            dataGridView1.Columns.Add("Дата", "Дата");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
            dataGridView1.Refresh();
        }

        private void ComboBox6_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID вида развлечения], [Виды развлечений]+' '+[Город]+' '+[Название гостиницы] from [dbo].[Развлечения]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox6.Items.Clear();
            comboBox6.Items.AddRange(list);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox6.SelectedItem)?.Id);
            string query = "Delete from dbo.Развлечения where [ID вида развлечения]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Удалено");
                comboBox6.SelectedItem = null;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID вида развлечения],[Виды развлечений],[Цена],[Вместимость людей], [Город], [Название гостиницы], [Дата]

             FROM [dbo].[Развлечения]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID вида развлечения", "ID вида развлечения");
            dataGridView1.Columns.Add("Виды развлечений", "Виды развлечений");
            dataGridView1.Columns.Add("Цена", "Цена");
            dataGridView1.Columns.Add("Вместимость людей", "Вместимость людей");
            dataGridView1.Columns.Add("Город", "Город");
            dataGridView1.Columns.Add("Название гостиницы", "Название гостиницы");
            dataGridView1.Columns.Add("Дата", "Дата");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
            dataGridView1.Refresh();
        }

        private void ComboBox7_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID сотрудника], [Должность]+' '+[Фамилия]+' '+[Имя]+' '+[Отчество] from [dbo].[Сотрудники]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox7.Items.Clear();
            comboBox7.Items.AddRange(list);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox7.SelectedItem)?.Id);
            string query = "Delete from dbo.Сотрудники where [ID сотрудника]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Удалено");
                comboBox7.SelectedItem = null;
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID сотрудника],[Должность],[Фамилия],[Имя], [Отчество], [Зарплата]

             FROM [dbo].[Сотрудники]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID сотрудника", "ID сотрудника");
            dataGridView1.Columns.Add("Должность", "Должность");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("Зарплата", "Зарплата");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
            dataGridView1.Refresh();
        }
    }
}
