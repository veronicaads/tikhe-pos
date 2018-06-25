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
    public partial class ReportMain : Form
    {
        public ReportMain()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show(); Hide();
        }
        int TogMove;
        int X, Y;
        private void ReportMain_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void ReportMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void order_graphic_CheckedChanged(object sender, EventArgs e)
        {
            if (order_graphic.Checked)
            {
                ReportInput RI = new ReportInput();
                RI.Show();
                Properties.Settings.Default.flag_form = "Graph_service";
            }
        }

        private void ReportMain_Load(object sender, EventArgs e)
        {
            order_graphic.Checked = false;
        }

        private void order_graphic_MouseClick(object sender, MouseEventArgs e)
        {
            //ReportInput RI = new ReportInput();
            //RI.Show();
			//Properties.Settings.Default.flag_form = "Graph_service";
		}

        private void service_summary_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void service_summary_MouseClick(object sender, MouseEventArgs e)
        {
            ReportInput RI = new ReportInput();
            RI.Show();
        }

        private void service_detail_CheckedChanged(object sender, EventArgs e)
        {
            if (service_detail.Checked)
            {
                ReportInputDetail rd = new ReportInputDetail();
                rd.Show();
                Properties.Settings.Default.flag_form = "service_order";
            }
		}

        private void service_detail_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

		private void customer_graphic_CheckedChanged(object sender, EventArgs e)
		{
            if (customer_graphic.Checked) {
                ReportInput_Customer Rs = new ReportInput_Customer();
                Rs.Show();
                Properties.Settings.Default.flag_form = "Customer";
            }
		}

		private void item_graph_CheckedChanged(object sender, EventArgs e)
		{
            if (item_graph.Checked)
            {
                ReportInput_Customer Rs = new ReportInput_Customer();
                Rs.Show();
                Properties.Settings.Default.flag_form = "Item";
            }
		}

		private void restock_graph_CheckedChanged(object sender, EventArgs e)
		{
            if (restock_graph.Checked)
            {
                ReportInput_Customer Rs = new ReportInput_Customer();
                Rs.Show();
                Properties.Settings.Default.flag_form = "Stock";
            }
		}

		private void customer_detail_CheckedChanged(object sender, EventArgs e)
		{
            if (customer_detail.Checked)
            {
                ReportInputDetail rd = new ReportInputDetail();
                rd.Show();
                Properties.Settings.Default.flag_form = "item_order";
            }
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
            if (radioButton3.Checked)
            {
                ReportInput_Customer rd = new ReportInput_Customer();
                rd.Show();
                Properties.Settings.Default.flag_form = "inventory";
            }
		}

		private void ReportMain_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
