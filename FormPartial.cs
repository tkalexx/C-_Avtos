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

namespace Avtoservis2
{
    public partial class FormPartial : Form
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

        public FormPartial()
        {
            InitializeComponent();
        }

        private void FillEmployees()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Сотрудники]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Сотрудники]");
            grid_employees.DataSource = ds.Tables["[Сотрудники]"].DefaultView;
            this.grid_employees.Columns[0].Visible = false;
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

        private void FormPartial_Load(object sender, EventArgs e)
        {
            this.Connect();
            FillEmployees();
            FillSell();
            FillProduct();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SqlText = " ";
            AddEmpl f = new AddEmpl();
            int index;

            //Random key = new Random();
            //int key1 = key.Next(900);
            //string id_employees = Convert.ToString(key1);
            index = grid_employees.RowCount - 1;
            int id_employees1 = Convert.ToInt32(grid_employees[0, index].Value);
            string id_employees = Convert.ToString(id_employees1);
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Сотрудники] ([Код_сотрудника], [ФИО], [Должность], [Домашний_адрес], [Телефон], [Зарплата]) VALUES (";
                SqlText = SqlText + id_employees + ", ";
                SqlText = SqlText + "\'" + f.fio.Text + "\', ";
                SqlText = SqlText + "\'" + f.post.Text + "\', ";
                SqlText = SqlText + "\'" + f.address.Text + "\', ";
                SqlText = SqlText + "\'" + f.phone.Text + "\', ";
                SqlText = SqlText + "\'" + f.salary.Text + "\')";
                MyExecuteNonQuery(SqlText);

                SqlText = "INSERT INTO [Авторизация] ([Код_сотрудника], [Логин], [Пароль]) VALUES (";
                SqlText = SqlText + id_employees + ", ";
                SqlText = SqlText + "\'" + f.log.Text + "\', ";
                SqlText = SqlText + "\'" + f.pass.Text + "\')";
                MyExecuteNonQuery(SqlText);

                if (f.box_dost.SelectedIndex == 0)
                {
                    SqlText = "INSERT INTO [РазрешениеДоступа] ([Код], [Код_сотрудника], [Код_доступа]) VALUES (";
                    SqlText = SqlText + id_employees + ", ";
                    SqlText = SqlText + id_employees + ", ";
                    SqlText = SqlText + "\'" + "1" + "\')";
                    MyExecuteNonQuery(SqlText);
                }

                FillEmployees();
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Сотрудники] SET ";
            string id_employees, fio, post, address, phone, salary;

            n = grid_employees.Rows.Count;
            if (n == 1) return;

            editEmpl f = new editEmpl();


            index = grid_employees.CurrentRow.Index;
            id_employees = grid_employees[0, index].Value.ToString();
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
                SqlText += "WHERE [Сотрудники].Код_сотрудника = " + id_employees;
                MyExecuteNonQuery(SqlText);
                FillEmployees();
            }
        }

        private void red_sale_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Покупка] SET ";
            string id_sell, data, dost, vid_opl, count;

            n = grid_sell.Rows.Count;
            if (n == 1) return;

            EditSale f = new EditSale();


            index = grid_sell.CurrentRow.Index;
            id_sell = grid_sell[0, index].Value.ToString();
            
            data = grid_sell[7, index].Value.ToString();
            dost = grid_sell[8, index].Value.ToString();
            vid_opl = grid_sell[9, index].Value.ToString();
            count = grid_sell[10, index].Value.ToString();

            f.textBox1.Text = data;
            f.textBox2.Text = dost;
            f.textBox3.Text = vid_opl;
            f.textBox4.Text = count;
            

            if (f.ShowDialog() == DialogResult.OK)
            {
                data = f.textBox1.Text;
                dost = f.textBox2.Text;
                vid_opl = f.textBox3.Text;
                count = f.textBox4.Text;
                
                SqlText += "Дата = \'" + data + "\', Доставка = '" + dost + "\', Вид_Оплаты = '" + vid_opl + "\', Количество = '" + count + "\'";
                SqlText += "WHERE [Покупка].Номер_покупки = " + id_sell;
                MyExecuteNonQuery(SqlText);
                FillSell();
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            ItogPoZp f = new ItogPoZp();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string SqlText = " ";
            AddProd f = new AddProd();

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Товар] ([Модель], [Цвет], [Цена], [Код_технических_данных], [Страна], [Код_марки], [Наличие]) VALUES (";
                SqlText = SqlText + "\'" + f.textBox1.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox2.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox5.Text + "\', ";
                SqlText = SqlText + "\'" + 1 + "\', ";
                SqlText = SqlText + "\'" + f.textBox3.Text + "\', ";
                SqlText = SqlText + "\'" + f.bx_mrk.SelectedValue.ToString() + "\',";
                SqlText = SqlText + "\'" + f.textBox6.Text + "\') ";
                MyExecuteNonQuery(SqlText);
                MessageBox.Show("Товар добавлен!");
                FillProduct();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int index, n;
            string id_prod;
            string fio, post;
            string SqlText = "DELETE FROM [Товар] WHERE [Товар].Код_товара = ";

            n = grid_product.Rows.Count;
            if (n == 1) return;

            DellProd f = new DellProd();

            index = grid_product.CurrentRow.Index;
            id_prod = Convert.ToString(grid_product[0, index].Value);

            SqlText = SqlText + id_prod;

            fio = Convert.ToString(grid_product[1, index].Value);
            post = Convert.ToString(grid_product[2, index].Value);
            f.naimProd.Text = id_prod + " - " + fio + " - " + post;

            if (f.ShowDialog() == DialogResult.OK)
            {
                MyExecuteNonQuery(SqlText);
                FillProduct();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Товар] SET ";
            string id_empl, model, cvet, cen, id_tex, str, id_mrk, nal;

            n = grid_product.Rows.Count;
            if (n == 1) return;

            EditProd f = new EditProd();


            index = grid_product.CurrentRow.Index;

            id_empl = grid_product[0, index].Value.ToString();
            model = grid_product[1, index].Value.ToString();
            cvet = grid_product[2, index].Value.ToString();
            cen = grid_product[3, index].Value.ToString();
            id_tex = grid_product[4, index].Value.ToString();
            str = grid_product[5, index].Value.ToString();
            id_mrk = grid_product[6, index].Value.ToString();
            nal = grid_product[7, index].Value.ToString();

            f.textBox1.Text = model;
            f.textBox2.Text = cvet;
            f.textBox5.Text = cen;
            f.textBox4.Text = id_tex;
            f.textBox3.Text = str;
            f.bx_mrk.Text = id_mrk;
            f.textBox6.Text = nal;
           

            if (f.ShowDialog() == DialogResult.OK)
            {
                model = f.textBox1.Text;
                cvet = f.textBox2.Text;
                cen = f.textBox5.Text;
                id_tex = f.textBox4.Text;
                str = f.textBox3.Text;
                id_mrk = f.bx_mrk.Text;
                nal = f.textBox6.Text;
                SqlText += "Модель = \'" + model + "\', Цвет = '" + cvet + "\', Цена = '" + cen + "\', Код_технических_данных = '" + id_tex + "\', Страна = '" + str + "\', Код_марки = '" + id_mrk + "\', Наличие = '" + id_tex + "\'";
                SqlText += "WHERE [Товар].Код_товара = " + id_empl;
                MyExecuteNonQuery(SqlText);
                FillProduct();
            }
        }
    }
}
