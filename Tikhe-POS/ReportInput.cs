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
			String flag = Properties.Settings.Default.flag_form;
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

		private void ReportInput_Load(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
        int TogMove;
        int X, Y;
        private void ReportInput_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void ReportInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void ReportInput_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
