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
    public partial class ItogPoZp : Form
    {
        public ItogPoZp()
        {
            InitializeComponent();
        }

        private void ItogPoZp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AvtoservisDataSet3.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.СотрудникиTableAdapter.Fill(this.AvtoservisDataSet3.Сотрудники);

            this.reportViewer1.RefreshReport();
        }
    }
}
