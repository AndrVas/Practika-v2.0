using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace SqlServerTestApp

{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

        private void Button15_Click(object sender, EventArgs e)
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

        private void Button16_Click(object sender, EventArgs e)
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

        private void Button17_Click(object sender, EventArgs e)
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

        private void Button18_Click(object sender, EventArgs e)
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

        private void Button19_Click(object sender, EventArgs e)
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

        private void Button20_Click(object sender, EventArgs e)
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

        private void Button21_Click(object sender, EventArgs e)
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Button10_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
            this.Hide();
        }
    }
}
