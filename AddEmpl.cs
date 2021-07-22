using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Avtoservis2
{
    public partial class AddEmpl : Form
    {
        public AddEmpl()
        {
            InitializeComponent();
        }

        private void AddEmpl_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public string GetPass(int x)
        {
            var r = new Random();
            string password = "";

            while (password.Length < x)
            {
                Char c = (char)r.Next(33, 125);
                if (Char.IsLetterOrDigit(c))
                    password += c;
            }
            return password;
        }

        public string GetLog(int y)
        {
            var r = new Random();
            string loginEmpl = "";

            while (loginEmpl.Length < y)
            {
                Char c = (char)r.Next(33, 125);
                if (Char.IsLetterOrDigit(c))
                    loginEmpl += c;
            }
            return loginEmpl;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            var password = GetPass(7);
            var loginEmpl = GetLog(7);
            pass.Text = password;
            log.Text = loginEmpl;
        }
    }
}
