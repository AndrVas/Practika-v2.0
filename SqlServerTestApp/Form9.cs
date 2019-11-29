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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = @"Select Название, Город
                              From Номера
                                 where Цена = (Select MIN(Цена) From Номера) and Вместимость = '1';";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "Название", "Город");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string query = @"Select Название, Город
                              From [Номера]
                                 Where [Вместимость] = '30' and [Город] = 'Москва';";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "Название", "Город");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string query = @"Select [Название гостиницы], [Виды развлечений], [Город]
                                From [Развлечения]
                                     where Город = 'Уфа' and ([Виды развлечений] = 'Ресторан' or [Виды развлечений] = 'Концерт');";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "Название гостиницы", "Виды развлечений", "Город");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string query = @"Select Страны, Комфортность
                             From[Номера]
                                 Where[Комфортность] = '10';";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "Страны","Комфортность");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string query = @" select Название,Цена, Страны
                                From Номера
                                    Where Цена = (select MAX(Цена) from Номера) and Страны = 'Россия';";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "Название","Цена", "Страны");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string query = @" select Название,Цена, Страны
                                From Номера
                                     Where Цена = (select MIN(Цена) from Номера) and Страны = 'Россия';  ";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "Название","Цена", "Страны");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string query = @"select Название, Страны, Комфортность
                                From Номера
                                    Where Комфортность = (select MAX(Комфортность) from Номера);";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "Название" , "Страны" , "Комфортность");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
            
        }
    }
}
