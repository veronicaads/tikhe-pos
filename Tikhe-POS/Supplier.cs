using FirebaseNet.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Tikhe_POS
{

    public partial class Supplier : Form
    {
        int id_sup;
        int selectedRow;
        FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Supplier");
        FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Supplier_Status");

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
            merek_txt.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button22_Click(object sender, EventArgs e)
        {
            FirebaseDB firebaseSupplier = firebaseDB.Node("S"+id_sup);
            String tmp = "S" + id_sup;
            var data = "";
            if (nama_txt.Text == "" || alamat_txt.Text == "" || email_txt.Text == "" || hp_txt.Text == "" || vendor_txt.Text == "" || merek_txt.Text=="")
            {
                MessageBox.Show("Semua Wajib Diisi !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainMenu form = new MainMenu();
                form.Show(); Hide();
            }
            else
            {
                vendorBindingSource.Add(new Vendor() { ID = "S"+id_sup.ToString(), Nama = nama_txt.Text, HP = hp_txt.Text, Produk = vendor_txt.Text, Alamat = alamat_txt.Text, Email = email_txt.Text, Merek = merek_txt.Text });
                data = @"{'id':'" + tmp + "','nama' : '" + nama_txt.Text + "','alamat' : '" + alamat_txt.Text + "','hp' : '" + hp_txt.Text + "','email' : '" + email_txt.Text + "','produk' : '" + vendor_txt.Text + "','merek' : '" + merek_txt.Text + "'}";
                firebaseSupplier.Put(data);
                id_sup++;
            }
            nama_txt.Text = "";
            alamat_txt.Text = "";
            merek_txt.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";
            vendor_txt.Text = "";

            var count = "";
            count = @"{'count':'" + id_sup + "'}";
            firebase.Put(count);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (nama_txt.Text == "" || alamat_txt.Text == "" || email_txt.Text == "" || hp_txt.Text == "" || vendor_txt.Text == "" || merek_txt.Text == "")
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
                newRow.Cells[6].Value = merek_txt.Text;

                FirebaseDB firebaseSupplier = firebaseDB.Node(newRow.Cells[0].Value.ToString());
                FirebaseResponse coba = firebaseSupplier.Get();
                dynamic stuff = JObject.Parse(coba.JSONContent);
                
                var data = "";
                data = @"{'id':'" + stuff.id + "','nama' : '" + nama_txt.Text + "','alamat' : '" + alamat_txt.Text + "','hp' : '" + hp_txt.Text + "','email' : '" + email_txt.Text + "','produk' : '" + vendor_txt.Text + "','merek' : '" + merek_txt.Text + "'}";
                firebaseSupplier.Patch(data);

                nama_txt.Text = "";
                alamat_txt.Text = "";
                hp_txt.Text = "";
                email_txt.Text = "";
                vendor_txt.Text = "";
                merek_txt.Text = "";
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
            merek_txt.Text = row.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            nama_txt.Text = "";
            alamat_txt.Text = "";
            merek_txt.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";
            vendor_txt.Text = "";

            DataGridViewRow newRow = dataGridView1.Rows[selectedRow];
            FirebaseDB firebaseSupplier = firebaseDB.Node(newRow.Cells[0].Value.ToString());
            //MessageBox.Show(newRow.Cells[0].Value.ToString());
            var data = "";
            data = @"{'id':'XXX','nama' : '" + nama_txt.Text + "','alamat' : '" + alamat_txt.Text + "','hp' : '" + hp_txt.Text + "','email' : '" + email_txt.Text + "','produk' : '" + vendor_txt.Text + "','merek' : '" + merek_txt.Text + "'}";

            firebaseSupplier.Patch(data);
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

        private void Supplier_Load(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse getResponse = firebase.Get();
                dynamic stuff = JObject.Parse(getResponse.JSONContent);
				//MessageBox.Show(getResponse.JSONContent);
                String jumlah = stuff.count;
                id_sup = Convert.ToInt32(jumlah);

                for (int i = 0; i < id_sup; i++)
                {
                    FirebaseDB firebaseSuplier = firebaseDB.Node("S" + i);
                    FirebaseResponse customer = firebaseSuplier.Get();
                    dynamic stiff = JObject.Parse(customer.JSONContent);
                    if (stiff.nama == "") continue;

                    vendorBindingSource.Add(new Vendor() { ID = stiff.id, Nama = stiff.nama, HP = stiff.hp, Produk = stiff.produk, Alamat = stiff.alamat, Email = stiff.email, Merek = stiff.merek });
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			FirebaseResponse vendor = firebaseDB.Get();
			dynamic stuff = JObject.Parse(vendor.JSONContent);
			IEnumerable<JToken> name = stuff.SelectTokens("$..[?(@.nama >= '" + textBox1.Text + "')]");
			String search_nama = textBox1.Text;
			String sub_search_name = search_nama.Substring(0, search_nama.Length);
			vendorBindingSource.Clear();
			foreach (JToken item in name)
			{
				dynamic items = JObject.Parse(item.ToString());
				String id = items.id;
				String nama_sub = items.nama;
				String nama_disub = nama_sub.Substring(0, search_nama.Length);
				if (id.Equals("XXX")) { }
				else
				{
					if (nama_disub.Equals(sub_search_name))
					{
						vendorBindingSource.Add(new Vendor() { ID =  items.id, Nama = items.nama, HP = items.hp, Produk = items.produk, Alamat = items.alamat, Email = items.email, Merek = items.merek });
					}
				}
			}
		}

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Supplier_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
