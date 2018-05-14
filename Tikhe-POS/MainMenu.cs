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
            Login form = new Login();
            form.Show(); Hide();
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            form.Show(); Hide();
        }

        private void supplier_btn_Click(object sender, EventArgs e)
        {
            Supplier form = new Supplier();
            form.Show(); Hide();
        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            Employee form = new Employee();
            form.Show(); Hide();
        }
        int TogMove;
        int X, Y;
        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void MainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }
    }
}
