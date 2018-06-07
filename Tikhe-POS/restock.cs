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
    public partial class restock : Form
    {
        public restock()
        {
            InitializeComponent();
        }
        int selectedRows;
        String tmp;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure to cancel this service ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    selectedRows = e.RowIndex;
                    DataGridViewRow row = dataGridView1.Rows[selectedRows];
                    tmp = row.Cells[2].Value.ToString();
                    total_harga = total_harga - Convert.ToInt32(tmp);
                    subtotal_txt.Text = total_harga.ToString();
                    stokBindingSource.RemoveCurrent();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            Hide();
        }
        int total_harga = 0;
        private void login_btn_Click(object sender, EventArgs e)
        {
            stokBindingSource.Add(new Stok() { No = "R01", Service = "Sabun Sepatu", Harga = "20000" });
            total_harga += 20000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
        //    Payment form = new Payment();
         //   form.Show(); Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stokBindingSource.Add(new Stok() { No = "R02", Service = "Sabun Helm", Harga = "30000" });
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stokBindingSource.Add(new Stok() { No = "R03", Service = "Pewangi", Harga = "40000" });
            total_harga += 40000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stokBindingSource.Add(new Stok() { No = "R04", Service = "Sikat", Harga = "10000" });
            total_harga += 10000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stokBindingSource.Add(new Stok() { No = "R03", Service = "Pewangi", Harga = "40000" });
            total_harga += 40000;
            subtotal_txt.Text = total_harga.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stokBindingSource.Add(new Stok() { No = "R05", Service = "Sol", Harga = "80000" });
            total_harga += 80000;
            subtotal_txt.Text = total_harga.ToString();
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
            Supplier form = new Supplier();
            form.Show();Hide();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show(); Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Cari di Database
        }
        int TogMove;
        int X, Y;
        private void restock_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void restock_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void restock_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
