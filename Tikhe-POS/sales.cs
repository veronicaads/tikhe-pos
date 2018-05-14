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
    public partial class sales : Form
    {
        public int total_harga = 0;

        public sales()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fast_clean_btn_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S01", Service = "Fast Clean", Harga = "30000" });
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S04", Service = "Ordinary Sizing", Harga = "10000" });
            total_harga += 10000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S02", Service = "Deep Clean", Harga = "50000" });
            total_harga += 50000;
            subtotal_txt.Text = total_harga.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S03", Service = "Unyellowing", Harga = "20000" });
            total_harga += 20000;
            subtotal_txt.Text = total_harga.ToString();
        }
        int selectedRows;
        String tmp;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Blom bisa kurangin total harga
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
            {
                if(MessageBox.Show("Are you sure to cancel this service ?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    selectedRows = e.RowIndex;
                    DataGridViewRow row = dataGridView2.Rows[selectedRows];
                    tmp = row.Cells[2].Value.ToString();
                    total_harga = total_harga - Convert.ToInt32(tmp);
                    subtotal_txt.Text = total_harga.ToString();
                    orderBindingSource.RemoveCurrent();
                }
            }
        }

        private void full_sizing_btn_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S05", Service = "Full Sizing", Harga = "15000" });
            total_harga += 15000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void ordinary_sewing_btn_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S06", Service = "Ordinary Sewing", Harga = "30000" });
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S07", Service = "Full Sewing", Harga = "30000" });
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S08", Service = "Remove Out Sol", Harga = "100000" });
            total_harga += 100000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S09", Service = "Leather Patch", Harga = "30000" });
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S10", Service = "Remove In Sol", Harga = "20000" });
            total_harga += 20000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S11", Service = "Leather Pressing", Harga = "50000" });
            total_harga += 50000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S12", Service = "Dress Shoes", Harga = "120000" });
            total_harga += 120000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S12", Service = "Casual Shoes", Harga = "120000" });
            total_harga += 120000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S13", Service = "Work Shoes", Harga = "120000" });
            total_harga += 120000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S14", Service = "Dance Shoes", Harga = "250000" });
            total_harga += 250000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S15", Service = "Boots", Harga = "150000" });
            total_harga += 150000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S16", Service = "Sandals", Harga = "50000" });
            total_harga += 50000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S17", Service = "Slippers", Harga = "80000" });
            total_harga += 80000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S18", Service = "Running Shoes", Harga = "250000" });
            total_harga += 250000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(new Order() { No = "S19", Service = "Basketball Shoes", Harga = "250000" });
            total_harga += 250000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void subtotal_txt_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();
            form.Show();Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            form.Show();Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Cari di Database
        }
        int TogMove;
        int X, Y;
        private void sales_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void sales_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void sales_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
