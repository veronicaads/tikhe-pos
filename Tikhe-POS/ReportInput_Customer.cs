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
	public partial class ReportInput_Customer : Form
	{
		public ReportInput_Customer()
		{
			InitializeComponent();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.tgl_awal_cs = this.dateTimePicker1.Value.ToString("yy-M-dd");
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.tgl_akhir_cs = this.dateTimePicker2.Value.ToString("yy-M-dd");
		}

		private void submit_button_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.tgl_awal_cs = this.dateTimePicker1.Value.ToString("yy-M-dd");
			Properties.Settings.Default.tgl_akhir_cs = this.dateTimePicker2.Value.ToString("yy-M-dd");
			String flag = Properties.Settings.Default.flag_form;
			if (flag.Equals("Customer")) {
				Cust_Chart chart = new Cust_Chart();
				chart.Show();
			}
			else if (flag.Equals("Item"))
			{
				Item_Chart chart = new Item_Chart();
				chart.Show();
			}
			else if (flag.Equals("Stock"))
			{
				Restock_Graph chart = new Restock_Graph();
				chart.Show();
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
            //ReportInput_Customer rs = new ReportInput_Customer();
            //rs.Hide();
            Hide();
		}


        int TogMove;
        int X, Y;
        private void ReportInput_Customer_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void ReportInput_Customer_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void ReportInput_Customer_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
