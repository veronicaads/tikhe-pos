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
    public partial class ReportInput : Form
    {
        public ReportInput()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        

		private void submitbutton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.cabang = cabang.Text;
			Properties.Settings.Default.servis = service.Text;
			Properties.Settings.Default.subservis = subservice.Text;
			Properties.Settings.Default.tgl_awal = this.dateTimePicker1.Value.ToString("yy-M-dd");
			Properties.Settings.Default.tgl_akhir = this.dateTimePicker2.Value.ToString("yy-M-dd");
			Chart chart = new Chart();
			chart.Show();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.tgl_awal = this.dateTimePicker1.Value.ToString("yy-M-dd");
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.tgl_akhir = this.dateTimePicker2.Value.ToString("yy-M-dd");
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.servis = service.Text;
		}

		private void servis_clicked(object sender, EventArgs e)
		{

		}

		private void subservis_clicked(object sender, EventArgs e)
		{
			Properties.Settings.Default.subservis = subservice.Text;
		}
	}
}
