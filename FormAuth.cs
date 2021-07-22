using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Avtoservis2
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void Connect() {
            string text = "Server=(local);Initial Catalog=Avtoservis;Trusted_connection=Yes";
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

        private void FormAuth_Load(object sender, EventArgs e)
        {
            this.Connect();
        }
        enum Role { Failed, Full, Partial, Limited}
        
        static Role GetRole(string log, string pass)
        {
            Role role = Role.Failed;

            using ( var conn = new SqlConnection("Server=(local);Initial Catalog=Avtoservis;Trusted_connection=Yes"))
            {
                var command = new SqlCommand("SELECT Код_доступа FROM Авторизация INNER JOIN РазрешениеДоступа ON Авторизация.Код_Сотрудника = РазрешениеДоступа.Код_сотрудника WHERE Авторизация.Логин = @log and Авторизация.Пароль = @pass ", conn);
                command.Parameters.AddWithValue("@log", log);
                command.Parameters.AddWithValue("@pass", pass);
                conn.Open();
                using (var dataReader = command.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        switch ((int)dataReader["Код_доступа"])
                        {
                            case 3: role = Role.Limited; break;
                            case 2: role = Role.Partial; break;
                            case 1: role = Role.Full; break;
                        }
                    }
                }
            }
            return role;
        }
        private void Input_Click(object sender, EventArgs e)
        {
            Role role = GetRole(log.Text, pass.Text);
            if (role == Role.Failed)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else
            {
                if (role == Role.Full)
                {
                    var form = new FormFull();
                    form.ShowDialog();
                }
                if (role == Role.Partial)
                {
                    var form = new FormPartial();
                    form.ShowDialog();
                }
                else if (role == Role.Limited)
                {
                    var form = new FormLimited();
                    form.ShowDialog();
                }
            }
        }
    }
}
