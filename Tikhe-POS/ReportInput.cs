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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            subservice.Items.Clear();
            if (service.SelectedIndex == 0) {
                subservice.Items.Clear();
                subservice.Items.Add("All");
                subservice.Items.Add("Deep Clean");
                subservice.Items.Add("Fast Clean");
                subservice.Items.Add("Unyellowing");
            }
            else if (service.SelectedIndex == 1)
            {
                subservice.Items.Clear();
                subservice.Items.Add("All");
                subservice.Items.Add("Dress Shoes");
                subservice.Items.Add("Casual Shoes");
                subservice.Items.Add("Workshoes");
                subservice.Items.Add("Dance Shoes");
                subservice.Items.Add("Boots");
                subservice.Items.Add("Sandals");
                subservice.Items.Add("Slippers");
                subservice.Items.Add("Running Shoes");
                subservice.Items.Add("BasketBall Shoes");
            }
            else if (service.SelectedIndex == 2)
            {
                subservice.Items.Clear();
                subservice.Items.Add("All");
                subservice.Items.Add("Ordinary Sizing");
                subservice.Items.Add("Full Sizing");
                subservice.Items.Add("Ordinary Sewing");
                subservice.Items.Add("Full Sewing");
                subservice.Items.Add("Remove Out Sol");
                subservice.Items.Add("Leather Patch");
                subservice.Items.Add("Remove In Sol");
                subservice.Items.Add("Leather Pressing");
            }
            
        }

		private void submitbutton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.cabang = cabang.Text;
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

		}
	}
}
