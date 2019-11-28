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
    public partial class Form11 : Form
    {
        public Form11()
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = @"select [ID клиента], [Фамилия], [Имя], [Отчество] from [dbo].[Клиенты]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ID клиента", "Фамилия", "Имя", "Отчество");
            foreach(var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string tb1 = null;
            string tb2 = null;
            string tb3 = null;
            try
            {
                tb1 = textBox1.Text;
                tb2 = textBox2.Text;
                tb3 = textBox3.Text;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Клиенты SET Фамилия='" + tb1 + "',Имя='" + tb2 + "',Отчество='" + tb3 + "' where [ID клиента]='" + n + "'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result !=null && result > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string query = @"select [ID номера], [Город], [Название], [Страны] from [dbo].[Номера]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ID номера", "Город", "Название", "Страны");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string tb4 = null;
            string tb5 = null;
            string tb6 = null;
            try
            {
                tb4 = textBox4.Text;
                tb5 = textBox5.Text;
                tb6 = textBox6.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Номера SET Город='" + tb4 + "',Название='" + tb5 + "',Страны='" + tb6 + "' where [ID номера]='" + n + "'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string query = @"select [ID Обслуживания], [Виды обслуживания], [Дата обслуживания] from [dbo].[Обслуживание]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ID Обслуживания", "Виды обслуживания", "Дата обслуживания");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string cb7 = null;
            DateTime tb8;
            
            try
            {
                cb7 = comboBox6.Text;
                tb8 = dateTimePicker1.Value;
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Обслуживание SET [Виды обслуживания]='" + cb7 + "',[Дата обслуживания]='" + tb8 + "' where [ID Обслуживания]='" + n + "'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string query = @"select  [ID поселения], [Дата поселения], [Дата освобождения],[Код клиента] from [dbo].[Поселение]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ID поселения", "Дата поселения", "Дата освобождения","Код клиента");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            DateTime tb9;
            DateTime tb10;
            string cb8 = null;

            try
            {
             tb9 = dateTimePicker2.Value;
             tb10 = dateTimePicker3.Value;
             cb8 = comboBox7.Text;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Поселение SET [Дата поселения]='" + tb9 + "',[Дата освобождения]='" + tb10 + "',[Код клиента]='" + cb8 + "' where [ID поселения]='" + n + "'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {

            string query = @"select [ID скидки], [Скидки], [Тип скидки], [Дата] from [dbo].[Процент скидок]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ID Скидки", "Скидки", "Тип кидки", "Дата");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID скидки], [Скидки] from [dbo].[Процент скидок]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void ComboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID скидки], [Тип скидки] from [dbo].[Процент скидок]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            string cb1 = null;
            string cb2 = null;
            DateTime tb11;
            try
            {
                cb1 = comboBox1.Text;
                cb2 = comboBox2.Text;
                tb11 = dateTimePicker4.Value;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.[Процент скидок] SET Скидки ='" + cb1 + "',[Тип скидки]='" + cb2 + "',Дата='" + tb11 + "' where [ID скидки]='" + n + "'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            string query = @"select [ID вида развлечения], [Виды развлечений], [Город], [Название гостиницы] from [dbo].[Развлечения]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ID вида развлечения", "Виды развлечения", "Город", "Название гостиницы");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            string cb3 = null;
            string tb13 = null;
            string tb14 = null;
            try
            {
                cb3 = comboBox3.Text;
                tb13 = textBox8.Text;
                tb14 = textBox9.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Развлечения SET [Виды развлечений]='" + cb3 + "',Город='" + tb13 + "',[Название гостиницы]='" + tb14 + "' where [ID вида развлечения]='" + n + "'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void ComboBox3_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID вида развлечения], [Виды развлечений] from [dbo].[Развлечения]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            string query = @"select [ID сотрудника], [Должность], [Фамилия], [Имя], [Отчество] from [dbo].[Сотрудники]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ID сотрудника", "Должность", "Фамилия", "Имя", "Отчество");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
        }

        private void ComboBox4_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID сотрудника], [Должность] from [dbo].[Сотрудники]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(list);
        }

        private void ComboBox5_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID сотрудника], [Зарплата] from [dbo].[Сотрудники]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            string cb4 = null;
            string cb5 = null;
            string tb15 = null;
            string tb16 = null;
            string tb17 = null;
            try
            {
                cb4 = comboBox4.Text;
                cb5 = comboBox5.Text;
                tb15 = textBox10.Text;
                tb16 = textBox11.Text;
                tb17 = textBox12.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Сотрудники SET [Должность]='" + cb4 + "',Зарплата='" + cb5 + "',[Фамилия]='" + tb15 + "',[Имя]='" + tb16 + "',[Отчество] = '" + tb17 + "' where [ID сотрудника]='" + n + "'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Updated");
            }
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

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
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

        private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void ComboBox6_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID Обслуживания], [Виды обслуживания] from [dbo].[Обслуживание]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox6.Items.Clear();
            comboBox6.Items.AddRange(list);
        }

        private void DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox7_DropDown(object sender, EventArgs e)
        {
            string query = "select [Код клиента], [Код клиента] from [dbo].[Поселение]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox7.Items.Clear();
            comboBox7.Items.AddRange(list);
        }
    }
}
