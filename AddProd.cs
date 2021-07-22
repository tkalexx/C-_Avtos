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
using System.Data.OleDb;

namespace Avtoservis2
{
    public partial class AddProd : Form
    {
        public AddProd()
        {
            InitializeComponent();
        }
        string text = "Server=(local);Initial Catalog=Avtoservis;Trusted_connection=Yes";

        private void AddProd_Load(object sender, EventArgs e)
        {
            string CommandText = "SELECT [Код_марки], [Название_марки] FROM [Марки_авто] ";
            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поиск]");
            bx_mrk.DataSource = ds.Tables["[Поиск]"].DefaultView;

            this.bx_mrk.DisplayMember = "Название_марки";
            this.bx_mrk.ValueMember = "Код_марки";
            this.bx_mrk.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
