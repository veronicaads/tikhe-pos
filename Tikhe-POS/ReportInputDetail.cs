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
	public partial class ReportInputDetail : Form
	{
		public ReportInputDetail()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.tgl_awal = this.dateTimePicker1.Value.ToString("yy-M-dd");
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.tgl_akhir = this.dateTimePicker2.Value.ToString("yy-M-dd");
		}

		private void submit_button_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.cabang = cabang.Text;
			Properties.Settings.Default.tgl_awal = this.dateTimePicker1.Value.ToString("yy-M-dd");
			Properties.Settings.Default.tgl_akhir = this.dateTimePicker2.Value.ToString("yy-M-dd");
				Detail_serviceorder chart = new Detail_serviceorder();
				chart.Show();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			ReportInputDetail form = new ReportInputDetail();
			form.Close();
		}
	}
}
