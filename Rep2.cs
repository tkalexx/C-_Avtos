using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtoservis2
{
    public partial class Rep2 : Form
    {
        public Rep2()
        {
            InitializeComponent();
        }

        private void Rep2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AvtoservisDataSet2.sale". При необходимости она может быть перемещена или удалена.
            this.saleTableAdapter.Fill(this.AvtoservisDataSet2.sale);

            this.reportViewer1.RefreshReport();
        }
    }
}
