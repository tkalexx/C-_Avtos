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
    public partial class Rep1 : Form
    {
        public Rep1()
        {
            InitializeComponent();
        }

        private void Rep1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AvtoservisDataSet.f1". При необходимости она может быть перемещена или удалена.
            this.f1TableAdapter.Fill(this.AvtoservisDataSet.f1);

            this.reportViewer1.RefreshReport();
        }
    }
}
