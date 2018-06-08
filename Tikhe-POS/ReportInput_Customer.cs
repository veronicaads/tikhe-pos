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
			Cust_Chart chart = new Cust_Chart();
			chart.Show();
		}
	}
}
