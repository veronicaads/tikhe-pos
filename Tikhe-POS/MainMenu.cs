using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tikhe_POS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void service_btn_Click(object sender, EventArgs e)
        {
            ReportMain ins = new ReportMain();
            ins.Show();
            Hide();
        }
        private void restock_btn_Click(object sender, EventArgs e)
        {
            restock ins = new restock();
            ins.Show();
            Hide();
        }
        private void sales_btn_Click(object sender, EventArgs e)
        {
            sales ins = new sales();
            ins.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
