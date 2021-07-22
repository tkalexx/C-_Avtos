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
    public partial class FormLimited : Form
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
        public FormLimited()
        {
            InitializeComponent();
        }

        private void FormLimited_Load(object sender, EventArgs e)
        {
            FillProduct();
            FillClients();
            FillSell();
            FillNkldn();
            for (int i = 0; i < grid_prod.ColumnCount; i++)
            {
                FL_box_param.Items.Add(grid_prod.Columns[i].HeaderText);
            }
            for (int i = 0; i < grid_clients.ColumnCount; i++)
            {
                LM_bx_param.Items.Add(grid_clients.Columns[i].HeaderText);
            }
            for (int i = 0; i < grid_sell.ColumnCount; i++)
            {
                comboBox2.Items.Add(grid_sell.Columns[i].HeaderText);
            }
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

        private void FillNkldn()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Накладные] WHERE [Оплачено] = 'false'";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Накладные]");
            grid_nkldn.DataSource = ds.Tables["[Накладные]"].DefaultView;
            grid_nkldn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_nkldn.Columns[0].Visible = false;
            
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

        private void FillProduct()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT [Код_товара],[Модель],[Цвет],[Страна],[Цена],[Наличие] FROM [Товар]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Товар]");
            grid_prod.DataSource = ds.Tables["[Товар]"].DefaultView;
            grid_prod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_prod.Columns[0].Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FL_btn_use_Click(object sender, EventArgs e)
        {
            string CommandText = "";
            if (FL_param.Text == " ")
            {
                return;
            };
            if (FL_box_usl.SelectedIndex == 0)
            {
                CommandText = "SELECT [Код_товара],[Модель],[Цвет],[Страна],[Цена],[Наличие] FROM [Товар] WHERE";
                CommandText += " " + FL_box_param.Text + " " + FL_box_usl.Text + " " + "'%" + FL_param.Text + "%'";
            }
            if (FL_box_usl.SelectedIndex == 1 || FL_box_usl.SelectedIndex == 2 || FL_box_usl.SelectedIndex == 3)
            {
                CommandText = "SELECT [Код_товара],[Модель],[Цвет],[Страна],[Цена],[Наличие] FROM [Товар] WHERE ";
                CommandText += " " + FL_box_param.Text + " " + FL_box_usl.Text + " '" + FL_param.Text + " '";
            }
            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поиск]");
            grid_prod.DataSource = ds.Tables["[Поиск]"].DefaultView;
            grid_prod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            FormLim2 f = new FormLim2(grid_prod.SelectedRows[0].Cells[0].Value, grid_prod.SelectedRows[0].Cells[1].Value, grid_clients.SelectedRows[0].Cells[0].Value, grid_clients.SelectedRows[0].Cells[1].Value);
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(text);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@code", f.tbx_id_prod.Text);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Наличие FROM Товар WHERE Код_товара = @code";
                object result = cmd.ExecuteScalar();
                int a = Convert.ToInt32(result);
                conn.Close();
               
                if (a >= Convert.ToInt32(f.count.Text))
                {
                    string SqlText = " ";
                    string id_employees = "(SELECT MAX(Код_сотрудника) FROM Сотрудники)";
                    MyExecuteNonQuery(id_employees);

                    SqlText = "INSERT INTO [Накладные] ( [Код_товара], [Код_клиента], [Код_сотрудника], [Дата], [Доставка], [Вид_Оплаты], [Количество], [Оплачено]) VALUES (";
                    
                    SqlText = SqlText + "\'" + f.tbx_id_prod.Text + "\', ";
                    SqlText = SqlText + "\'" + f.tbx_id_clients.Text + "\', ";
                    SqlText = SqlText + "\'" + f.bx_empl.SelectedValue.ToString() + "\', ";
                    SqlText = SqlText + "\'" + f.dateTimePicker1.Value.ToShortDateString() + "\', ";
                    if (f.bx_dost.Text == "Да")
                    {
                        SqlText = SqlText + "\'" + true + "\', ";

                    }
                    else
                    {
                        SqlText = SqlText + "\'" + false + "\', ";

                    }
                    SqlText = SqlText + "\'" + f.bx_vidOpl.Text + "\', ";
                    SqlText = SqlText + "\'" + f.count.Text + "\', ";
                    SqlText = SqlText + "\'" + false + "\')";
                    MyExecuteNonQuery(SqlText);
                    MessageBox.Show("Заказ добавлен в накладные");
                    FillNkldn();
                    /*string SqlText = " ";
                    SqlText = "INSERT INTO [Покупка] ([Код_товара], [Код_клиента], [Код_сотрудника], [Дата], [Доставка], [Вид_Оплаты], [Количество]) VALUES (";
                    SqlText = SqlText + "\'" + f.tbx_id_prod.Text + "\', ";
                    SqlText = SqlText + "\'" + f.tbx_id_clients.Text + "\', ";
                    SqlText = SqlText + "\'" + f.bx_empl.SelectedValue.ToString() + "\', ";
                    SqlText = SqlText + "\'" + f.dateTimePicker1.Value.ToShortDateString() + "\', ";
                    if (f.bx_dost.Text == "Да")
                    {
                        SqlText = SqlText + "\'" + true + "\', ";

                    }
                    else
                    {
                        SqlText = SqlText + "\'" + false + "\', ";

                    }
                    SqlText = SqlText + "\'" + f.bx_vidOpl.Text + "\', ";
                    SqlText = SqlText + "\'" + f.count.Text + "\')";
                    MyExecuteNonQuery(SqlText);
                    MessageBox.Show("Заказ оформлен");
                    string id_prod, count1;
                    count1 = f.count.Text;
                    int s = a - Convert.ToInt32(count1);
                    string SqlText1 = "UPDATE [Товар] SET Наличие = ";
                    id_prod = f.tbx_id_prod.Text;
                    SqlText1 = SqlText1 + "'" + Convert.ToString(s) + "'";
                    SqlText1 = SqlText1 + "FROM Товар WHERE [Товар].Код_товара = ";
                    SqlText1 = SqlText1 + id_prod;
                    MyExecuteNonQuery(SqlText1);
                    FillProduct();*/
                }
                else
                {
                    MessageBox.Show("Недостаточно товаров");
                }
            }

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            string CommandText = "";
            if (LM_tb.Text == " ")
            {
                return;
            };
            if (LM_bx_otb.SelectedIndex == 0)
            {
                CommandText = "SELECT * FROM [Клиенты] WHERE";
                CommandText += " " + LM_bx_param.Text + " " + LM_bx_otb.Text + " " + "'%" + LM_tb.Text + "%'";
            }
            if (LM_bx_otb.SelectedIndex == 1 || LM_bx_otb.SelectedIndex == 2 || LM_bx_otb.SelectedIndex == 3)
            {
                CommandText = "SELECT * FROM [Клиенты] WHERE";
                CommandText += " " + LM_bx_param.Text + " " + LM_bx_otb.Text + " '" + LM_tb.Text + " '";
            }
            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поиск2]");
            grid_clients.DataSource = ds.Tables["[Поиск2]"].DefaultView;
            grid_clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SqlText = " ";
            AddClients f = new AddClients();
            
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Клиенты] ([ФИО], [Паспорт], [Домашний_адрес], [Телефон],[Код_скидки] ) VALUES (";
                SqlText = SqlText + "\'" + f.fio.Text + "\', ";
                SqlText = SqlText + "\'" + f.post.Text + "\', ";
                SqlText = SqlText + "\'" + f.address.Text + "\', ";
                SqlText = SqlText + "\'" + f.phone.Text + "\',";
                SqlText = SqlText + "\'" + 1 + "\') ";
                MyExecuteNonQuery(SqlText);
                MessageBox.Show("Клиент зарегистрирован");
            } 
            FillClients();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string CommandText = "";
            if (textBox1.Text == " ")
            {
                return;
            };
            if (comboBox1.SelectedIndex == 0)
            {
                CommandText = "SELECT * FROM [Продажи] WHERE";
                CommandText += " " + comboBox2.Text + " " + comboBox1.Text + " " + "'%" + textBox1.Text + "%'";
            }
            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3)
            {
                CommandText = "SELECT * FROM [Продажи] WHERE";
                CommandText += " " + comboBox2.Text + " " + comboBox1.Text + " '" + textBox1.Text + " '";
            }
            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поиск6]");
            grid_sell.DataSource = ds.Tables["[Поиск6]"].DefaultView;
            grid_sell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_provodka_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_nkldn.Rows.Count; i++)
            {

                if (Convert.ToInt32(grid_nkldn[8,i].Value) == 1)
                {
                    int index;
                    string id_pkp, id_pr, id_cl, id_empl, data, dost, vid, count, zp_emp;
                    index = i;
                    id_pkp = Convert.ToString(grid_nkldn[0, index].Value);
                    id_pr = Convert.ToString(grid_nkldn[1, index].Value);
                    id_cl = Convert.ToString(grid_nkldn[2, index].Value);
                    id_empl = Convert.ToString(grid_nkldn[3, index].Value);
                    data = Convert.ToString(grid_nkldn[4, index].Value);
                    dost = Convert.ToString(grid_nkldn[5, index].Value);
                    vid = Convert.ToString(grid_nkldn[6, index].Value);
                    count = Convert.ToString(grid_nkldn[7, index].Value);
                    zp_emp = Convert.ToString(grid_nkldn[8, index].Value);


                    string SqlText = " ";
                        SqlText = "INSERT INTO [Покупка] ([Номер_покупки], [Код_товара], [Код_клиента], [Код_сотрудника], [Дата], [Доставка], [Вид_Оплаты], [Количество]) VALUES (";
                    SqlText = SqlText + "'" + id_pkp + "',";
                    SqlText = SqlText + "'" + id_pr + "',";
                    SqlText = SqlText + "'" + id_cl + "',";
                    SqlText = SqlText + "'" + id_empl + "',";
                    SqlText = SqlText + "'" + data + "',";
                    SqlText = SqlText + "'" + dost + "',";
                    SqlText = SqlText + "'" + vid + "',";
                    SqlText = SqlText + "'" + count + "')";
                    MyExecuteNonQuery(SqlText);
                    MessageBox.Show("Заказ оформлен");

                    SqlText = "UPDATE [Накладные] SET Оплачено = ";
                    SqlText = SqlText + "'" + zp_emp + "'";
                    SqlText = SqlText + "FROM Накладные WHERE[Накладные].Номер_накладной = ";
                    SqlText = SqlText + grid_nkldn[0, i].Value;
                    MyExecuteNonQuery(SqlText);
                    FillNkldn();
                    FillSell();
                }
            }
            /*string SqlText = " ";
                    SqlText = "INSERT INTO [Покупка] ([Код_товара], [Код_клиента], [Код_сотрудника], [Дата], [Доставка], [Вид_Оплаты], [Количество]) VALUES (";
                    SqlText = SqlText + "\'" + f.tbx_id_prod.Text + "\', ";
                    SqlText = SqlText + "\'" + f.tbx_id_clients.Text + "\', ";
                    SqlText = SqlText + "\'" + f.bx_empl.SelectedValue.ToString() + "\', ";
                    SqlText = SqlText + "\'" + f.dateTimePicker1.Value.ToShortDateString() + "\', ";
                    if (f.bx_dost.Text == "Да")
                    {
                        SqlText = SqlText + "\'" + true + "\', ";

                    }
                    else
                    {
                        SqlText = SqlText + "\'" + false + "\', ";

                    }
                    SqlText = SqlText + "\'" + f.bx_vidOpl.Text + "\', ";
                    SqlText = SqlText + "\'" + f.count.Text + "\')";
                    MyExecuteNonQuery(SqlText);
                    MessageBox.Show("Заказ оформлен");
                    string id_prod, count1;
                    count1 = f.count.Text;
                    int s = a - Convert.ToInt32(count1);
                    string SqlText1 = "UPDATE [Товар] SET Наличие = ";
                    id_prod = f.tbx_id_prod.Text;
                    SqlText1 = SqlText1 + "'" + Convert.ToString(s) + "'";
                    SqlText1 = SqlText1 + "FROM Товар WHERE [Товар].Код_товара = ";
                    SqlText1 = SqlText1 + id_prod;
                    MyExecuteNonQuery(SqlText1);
                    FillProduct();*/

            /*string SqlText = " ";
            string id_employees = "(SELECT MAX(Код_сотрудника) FROM Сотрудники)";
            MyExecuteNonQuery(id_employees);

            string id_pkpk = "(SELECT MAX(Номер_покупки) FROM Покупка)";
            MyExecuteNonQuery(id_pkpk);
            SqlText = "INSERT INTO [Накладные] ([Номер_покупки], [Код_товара], [Код_клиента], [Код_сотрудника], [Дата], [Доставка], [Вид_Оплаты], [Количество], [Оплачено]) VALUES (";
            SqlText = SqlText + "\'" + id_pkpk + "\', ";
            SqlText = SqlText + "\'" + f.tbx_id_prod.Text + "\', ";
            SqlText = SqlText + "\'" + f.tbx_id_clients.Text + "\', ";
            SqlText = SqlText + "\'" + f.bx_empl.SelectedValue.ToString() + "\', ";
            SqlText = SqlText + "\'" + f.dateTimePicker1.Value.ToShortDateString() + "\', ";
            if (f.bx_dost.Text == "Да")
            {
                SqlText = SqlText + "\'" + true + "\', ";

            }
            else
            {
                SqlText = SqlText + "\'" + false + "\', ";

            }
            SqlText = SqlText + "\'" + f.bx_vidOpl.Text + "\', ";
            SqlText = SqlText + "\'" + f.count.Text + "\', ";
            SqlText = SqlText + "\'" + true + "\')";
            MyExecuteNonQuery(SqlText);
            MessageBox.Show("Заказ оформлен");*/
        }
    }
}
