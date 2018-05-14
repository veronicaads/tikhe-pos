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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nama_txt.Text = "";
            alamat_txt.Text = "";
            email_txt.Text = "";
            hp_txt.Text = "";
            vendor_txt.Text = "";
            textBox2.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int id_vendor=0;
        private void button22_Click(object sender, EventArgs e)
        {

            if (nama_txt.Text == "" || alamat_txt.Text == "" || email_txt.Text == "" || hp_txt.Text == "" || vendor_txt.Text == "" || textBox2.Text=="")
            {
                MessageBox.Show("Semua Wajib Diisi !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainMenu form = new MainMenu();
                form.Show(); Hide();
            }
            else
            {
                vendorBindingSource.Add(new Vendor() { ID = id_vendor.ToString(), Nama = nama_txt.Text, HP = hp_txt.Text, Produk = vendor_txt.Text, Alamat = alamat_txt.Text, Email = email_txt.Text, Merek = textBox2.Text });
                id_vendor++;
            }
            nama_txt.Text = "";
            alamat_txt.Text = "";
            textBox2.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";
            vendor_txt.Text = "";
        }
        int selectedRow;
        private void button1_Click(object sender, EventArgs e)
        {
            if (nama_txt.Text == "" || alamat_txt.Text == "" || email_txt.Text == "" || hp_txt.Text == "" || vendor_txt.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Semua Wajib Diisi !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainMenu form = new MainMenu();
                form.Show(); Hide();
            }
            else
            {
                DataGridViewRow newRow = dataGridView1.Rows[selectedRow];
                newRow.Cells[1].Value = nama_txt.Text;
                newRow.Cells[5].Value = alamat_txt.Text;
                newRow.Cells[4].Value = email_txt.Text;
                newRow.Cells[2].Value = hp_txt.Text;
                newRow.Cells[3].Value = vendor_txt.Text;
                newRow.Cells[6].Value = textBox2.Text;
                nama_txt.Text = "";
                alamat_txt.Text = "";
                hp_txt.Text = "";
                email_txt.Text = "";
                vendor_txt.Text = "";
                textBox2.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            nama_txt.Text = row.Cells[1].Value.ToString();
            alamat_txt.Text = row.Cells[5].Value.ToString();
            email_txt.Text = row.Cells[4].Value.ToString();
            hp_txt.Text = row.Cells[2].Value.ToString();
            vendor_txt.Text = row.Cells[3].Value.ToString();
            textBox2.Text = row.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nama_txt.Text = "";
            alamat_txt.Text = "";
            textBox2.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";
            vendor_txt.Text = "";
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }
        int TogMove;
        int X, Y;
        private void Supplier_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void Supplier_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void Supplier_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
