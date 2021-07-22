using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace Avtoservis2
{
    public partial class FormFull : Form
    {
        string text = "Server=(local);Initial Catalog=Avtoservis;Trusted_connection=Yes";

        private void Connect()
        {
            SqlConnection conn = new SqlConnection(text);
            try
            {
                //Открыть подключение
                conn.Open();
            }
            catch (Exception ex)
            {
                //Сообщение об ошибке
                MessageBox.Show(ex.Message);
            }

            finally
            {
                //Закрываем подключение
                conn.Close();
            }

        }

        public FormFull()
        {
            InitializeComponent();
        }

        private void FillClients()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Клиенты]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Клиенты]");
            grid_clients.DataSource = ds.Tables["[Клиенты]"].DefaultView;
            grid_clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_clients.Columns[0].Visible = false;
            this.grid_clients.Columns[5].Visible = false;
        }

        private void FillEmployees()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Сотрудники]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Сотрудники]");
            grid_employees.DataSource = ds.Tables["[Сотрудники]"].DefaultView;
            grid_employees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_employees.Columns[0].Visible = false;
        }

        private void FillProduct()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Товар]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Товар]");
            grid_product.DataSource = ds.Tables["[Товар]"].DefaultView;
            grid_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_product.Columns[0].Visible = false;
            this.grid_product.Columns[4].Visible = false;
            this.grid_product.Columns[6].Visible = false;
        }

        private void FillTechnical()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Технические_данные]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Технические_данные]");
            grid_technical.DataSource = ds.Tables["[Технические_данные]"].DefaultView;
            grid_technical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_technical.Columns[0].Visible = false;
        }
        private void FillSell()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT Номер_покупки, Покупка.Код_товара, Товар.Модель, Покупка.Код_клиента, Клиенты.ФИО, Покупка.Код_сотрудника, Сотрудники.ФИО, Дата, Доставка, Вид_Оплаты, Количество FROM Покупка inner join Клиенты on Покупка.Код_клиента = Клиенты.Код_клиента inner join Сотрудники On Покупка.Код_сотрудника = Сотрудники.Код_сотрудника inner join Товар On Покупка.Код_товара = Товар.Код_товара ";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Покупка]");
            grid_sell.DataSource = ds.Tables["[Покупка]"].DefaultView;
            grid_sell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sell.Columns[0].Visible = false;
            this.grid_sell.Columns[1].Visible = false;
            this.grid_sell.Columns[3].Visible = false;
            this.grid_sell.Columns[5].Visible = false;
        }

        public void MyExecuteNonQuery(string SqlText)
        {

            SqlConnection cn = new SqlConnection(text);
            cn.Open(); 
            SqlCommand cmd = cn.CreateCommand(); 
            cmd.CommandText = SqlText; 
            cmd.ExecuteNonQuery(); 
            cn.Close(); 
        }

        private void FormFull_Load(object sender, EventArgs e)
        {
            
            this.Connect();
            FillClients();
            FillEmployees();
            FillProduct();
            FillTechnical();
            FillSell();
            
        }

        private void btn_addEmployees_Click(object sender, EventArgs e)
        {
            string SqlText = " ";
            AddEmpl f = new AddEmpl();
            //int index;
            
            //Random key = new Random();
            //int key1 = key.Next(900);
            //string id_employees = Convert.ToString(key1);
            //index = grid_employees.RowCount-1;
            //int id_employees1 = Convert.ToInt32(grid_employees[0, index].Value);
            //string id_employees = Convert.ToString(id_employees1);
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Сотрудники] ([ФИО], [Должность], [Домашний_адрес], [Телефон], [Зарплата]) VALUES (";
                SqlText = SqlText + "\'" + f.fio.Text + "\', ";
                SqlText = SqlText + "\'" + f.post.Text + "\', ";
                SqlText = SqlText + "\'" + f.address.Text + "\', ";
                SqlText = SqlText + "\'" + f.phone.Text + "\', ";
                SqlText = SqlText + "\'" + f.salary.Text + "\')";
                MyExecuteNonQuery(SqlText);

                //index = grid_employees.RowCount-1;
                //FillEmployees();
                //grid_employees.CurrentCell = grid_employees[0, grid_employees.Rows.Count - 1];

                //string id_employees = grid_employees.Rows[grid_employees.CurrentRow.Index].Cells[grid_employees.CurrentCell.ColumnIndex].Value.ToString();

                string id_employees = "(SELECT MAX(Код_сотрудника) FROM Сотрудники)";
                MyExecuteNonQuery(id_employees);

                SqlText = "INSERT INTO [Авторизация] ([Код_сотрудника], [Логин], [Пароль]) VALUES (";
                SqlText = SqlText + id_employees + ", ";
                SqlText = SqlText + "\'" + f.log.Text + "\', ";
                SqlText = SqlText + "\'" + f.pass.Text + "\')";
                MyExecuteNonQuery(SqlText);


                if (f.box_dost.SelectedIndex == 0)
                {
                    SqlText = "INSERT INTO [РазрешениеДоступа] ([Код_сотрудника], [Код_доступа]) VALUES (";
                    SqlText = SqlText + id_employees + ", ";
                    SqlText = SqlText + "\'" + "1" + "\')";
                    MyExecuteNonQuery(SqlText);
                }

                if (f.box_dost.SelectedIndex == 1)
                {
                    SqlText = "INSERT INTO [РазрешениеДоступа] ([Код_сотрудника], [Код_доступа]) VALUES (";
                    SqlText = SqlText + id_employees + ", ";
                    SqlText = SqlText + "\'" + "2" + "\')";
                    MyExecuteNonQuery(SqlText);
                }

                if (f.box_dost.SelectedIndex == 2)
                {
                    SqlText = "INSERT INTO [РазрешениеДоступа] ([Код_сотрудника], [Код_доступа]) VALUES (";
                    SqlText = SqlText + id_employees + ", ";
                    SqlText = SqlText + "\'" + "3" + "\')";
                    MyExecuteNonQuery(SqlText);
                }
            }
            FillEmployees();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index, n;
            string id_employees;
            string fio, post;
            string SqlText = "DELETE FROM [Сотрудники] WHERE [Сотрудники].Код_Сотрудника = ";

            n = grid_employees.Rows.Count;
            if (n == 1) return;

            DellEmpl f = new DellEmpl();

            index = grid_employees.CurrentRow.Index;
            id_employees = Convert.ToString(grid_employees[0, index].Value);

            SqlText = SqlText + id_employees;

            fio = Convert.ToString(grid_employees[1, index].Value);
            post = Convert.ToString(grid_employees[2, index].Value);
            f.fioEmpl.Text = id_employees + " - " + fio + " - " + post;

            if (f.ShowDialog() == DialogResult.OK) 
            {
                MyExecuteNonQuery(SqlText);
                FillEmployees();
            }
        }

        private void editEmpl_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Сотрудники] SET ";
            string id_empl, fio, post, address, phone, salary;

            n = grid_employees.Rows.Count;
            if (n == 1) return;

            editEmpl f = new editEmpl();


            index = grid_employees.CurrentRow.Index;

            id_empl = grid_employees[0, index].Value.ToString();
            fio = grid_employees[1, index].Value.ToString();
            post = grid_employees[2, index].Value.ToString();
            address = grid_employees[3, index].Value.ToString();
            phone = grid_employees[4, index].Value.ToString();
            salary = grid_employees[5, index].Value.ToString();

            f.fio.Text = fio;
            f.post.Text = post;
            f.address.Text = address;
            f.phone.Text = phone;
            f.salary.Text = salary;

            if (f.ShowDialog() == DialogResult.OK)
            {
                fio = f.fio.Text;
                post = f.post.Text;
                address = f.address.Text;
                phone = f.phone.Text;
                salary = f.salary.Text;
                SqlText += "ФИО = \'" + fio + "\', Должность = '" + post + "\', Домашний_адрес = '" + address + "\', Телефон = '" + phone + "\', Зарплата = '" + salary + "\'";
                SqlText += "WHERE [Сотрудники].Код_сотрудника = " + id_empl;
                MyExecuteNonQuery(SqlText);
                FillEmployees();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        DataSet ds = new DataSet();

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string CommandText = "";
            if (param.Text == " ")
            {
                return;
            };
            if (box_table.SelectedIndex == 0)
            {
                CommandText = "SELECT [ФИО],[Паспорт],[Домашний_адрес],[Телефон] FROM [Клиенты] WHERE ";  
            }

            if (box_table.SelectedIndex == 1)
            {
                CommandText = "SELECT [ФИО],[Должность],[Домашний_адрес],[Телефон],[Зарплата] FROM [Сотрудники] WHERE ";
            }
            if (box_table.SelectedIndex == 2)
            {
                CommandText = "SELECT [Модель],[Цвет],[Страна],[Цена],[Наличие] FROM [Товар] WHERE ";
            }
            if (box_table.SelectedIndex == 3)
            {
                CommandText = "SELECT * FROM [Технические_данные] WHERE ";
            }
            if (box_table.SelectedIndex == 4)
            {
                CommandText = "SELECT * FROM [Продажи] WHERE ";
            }
            if (box_param.SelectedIndex == 0)
            {
                CommandText += " " + box_str.Text + " " + box_param.Text + " " + "'%" + param.Text + "%'";
            }
            if (box_param.SelectedIndex == 1 || box_param.SelectedIndex == 2 || box_param.SelectedIndex == 3)
            {
                CommandText += " " + box_str.Text + " " + box_param.Text + " '" + param.Text + " '";
            }
            
            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поиск]");
            grid_poisk.DataSource = ds.Tables["[Поиск]"].DefaultView;
            grid_poisk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void box_table_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void box_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_table.SelectedIndex == 0)
            {
                box_str.Items.Clear();
                for (int i = 0; i < grid_clients.ColumnCount; i++)
                {
                    box_str.Items.Add(grid_clients.Columns[i].HeaderText);
                }
            }
            if (box_table.SelectedIndex == 1)
            {
                box_str.Items.Clear();
                for (int i = 0; i < grid_employees.ColumnCount; i++)
                {
                    box_str.Items.Add(grid_employees.Columns[i].HeaderText);
                }
            }
            if (box_table.SelectedIndex == 2)
            {
                box_str.Items.Clear();
                for (int i = 0; i < grid_product.ColumnCount; i++)
                {
                    box_str.Items.Add(grid_product.Columns[i].HeaderText);
                }
            }
            if (box_table.SelectedIndex == 3)
            {
                box_str.Items.Clear();
                for (int i = 0; i < grid_technical.ColumnCount; i++)
                {
                    box_str.Items.Add(grid_technical.Columns[i].HeaderText);
                }
            }
            if (box_table.SelectedIndex == 4)
            {
                box_str.Items.Clear();
                for (int i = 0; i < grid_sell.ColumnCount; i++)
                {
                    box_str.Items.Add(grid_sell.Columns[i].HeaderText);
                }
            }
        }

        private void btn_summEmpl_Click(object sender, EventArgs e)
        {
            Rep2 f = new Rep2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rep1 f = new Rep1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(text);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Товар.Цена) AS Summ FROM Товар INNER JOIN Покупка ON Товар.Код_товара = Покупка.Код_товара";
            object result = cmd.ExecuteScalar();
            int a = Convert.ToInt32(result);
            conn.Close();
            tx_box_s.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string CommandText = "";
            CommandText = "SELECT Товар.Модель, Товар.Цена, Дата, Сотрудники.ФИО from Товар, Сотрудники, Покупка WHERE Покупка.Дата Between";
            CommandText += " '" + dateTimePicker1.Value.ToShortDateString() + "' ";
            CommandText += " and ";
            CommandText += " '" + dateTimePicker2.Value.ToShortDateString() + "' ";
            CommandText += " and Товар.Код_товара = Покупка.Код_товара and Сотрудники.Код_сотрудника = Покупка.Код_сотрудника";
            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Запр]");
            dataGridView1.DataSource = ds.Tables["[Запр]"].DefaultView;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ItogPoZp f = new ItogPoZp();
            f.Show();
        }
    }
}
