using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseNet.Database;
using Newtonsoft.Json.Linq;

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
                    tmp = row.Cells[1].Value.ToString();
                    stokBindingSource4.RemoveCurrent();
                    item.Remove(tmp);
                }
            }
        }
        List<string> item = new List<string>();

        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            Hide();
        }
        int total_harga = 0;
        private void login_btn_Click(object sender, EventArgs e)
        {
            stokBindingSource4.Add(new Stok() { No = "R01", Jenis_Barang = "Sabun Sepatu", Harga = "20000" });
            total_harga += 20000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            item.Add("Sabun Sepatu");
        }

        private string generate_orderid(int id)
        {
            String data = "";
            if (id < 9 && id >= 0) data = "U000" + id;
            else if (id > 9 && id < 100) data = "U00" + id;
            else if (id > 99 && id < 1000) data = "U0" + id;
            else if (id > 999 && id < 10000) data = "U" + id;
            return data;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            var data = "";
            var pesanan = "";
            int jum=0;
            FirebaseDB firebaseSup = new FirebaseDB("https://mobile-shoebox.firebaseio.com/restock_key");
            FirebaseResponse fire = firebaseSup.Get();

            FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/restock_store");
            if (MessageBox.Show("Are you sure to Add this item ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                String tanggalmasuk = DateTime.Now.ToString("yy-M-dd");

                String supp_id = "";
                
                dynamic stuff = JObject.Parse(fire.JSONContent);
                jum = Convert.ToInt32(stuff.count);


                for (int i = 0; i < item.Count; i++)
                {
                    supp_id = generate_orderid(jum);
                    pesanan = @"{'supplier':'" + comboBox1.Text + "','biaya':'" + total_txt.Text + "','supply_id' : '" +supp_id + "','item' : '" + item[i] + "','diskon' : '" + diskon_txt.Text + "','tanggal_masuk' : '" + tanggalmasuk + "'}";
                    jum++;
                }

                FirebaseDB Orders = firebase.Node(supp_id);
                Orders.Put(pesanan);

                data = @"{'count':'" + jum + "'}";
                firebaseSup.Patch(data);

                MainMenu haha = new MainMenu();
                haha.Show(); Hide();
            }

           
        }
    
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            stokBindingSource4.Add(new Stok() { No = "R02", Jenis_Barang = "Sabun Helm", Harga = "30000" });
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            item.Add("Sabun Helm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stokBindingSource4.Add(new Stok() { No = "R03", Jenis_Barang = "Pewangi", Harga = "40000" });
            total_harga += 40000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            item.Add("Pewangi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stokBindingSource4.Add(new Stok() { No = "R04", Jenis_Barang = "Sikat", Harga = "10000" });
            total_harga += 10000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            item.Add("Sikat");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stokBindingSource4.Add(new Stok() { No = "R03", Jenis_Barang = "Cat Sepatu", Harga = "40000" });
            total_harga += 40000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            item.Add("Cat Sepatu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stokBindingSource4.Add(new Stok() { No = "R05", Jenis_Barang = "Sol", Harga = "80000" });
            total_harga += 80000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            item.Add("Sol");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			String supplier = comboBox1.Text;
			//MessageBox.Show(supplier);
			FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Supplier");
			FirebaseResponse vendor = firebaseDB.Get();
			dynamic stuff = JObject.Parse(vendor.JSONContent);
			//MessageBox.Show(vendor.JSONContent);
			JToken vendors = stuff.SelectToken("$..[?(@.nama == '" + supplier + "')]");
			dynamic items = JObject.Parse(vendors.ToString());
			//MessageBox.Show(items);
			label11.Text = items.nama;
			label12.Text = items.alamat;
			label13.Text = items.hp;
		}
        int id_supplier = 0;
        List<string> nama_kalian = new List<string>();
        List<string> alamat = new List<string>();
        List<string> no_hp = new List<string>();
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("")) diskon_txt.Text = "0";
            else diskon_txt.Text = (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(subtotal_txt.Text) / 100).ToString();
            total_txt.Text = (Convert.ToInt32(subtotal_txt.Text) - Convert.ToInt32(diskon_txt.Text)).ToString();
        }

        private void restock_Load(object sender, EventArgs e)
        {
            try
            {

                FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Supplier");
                FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Supplier_Status");
                FirebaseResponse getResponse = firebase.Get();
                dynamic stuff = JObject.Parse(getResponse.JSONContent);
                String jumlah = stuff.count;
                id_supplier = Convert.ToInt32(jumlah);

                for (int i = 0; i < id_supplier; i++)
                {
                    FirebaseDB firebaseSup = firebaseDB.Node("S" + i);
                    FirebaseResponse customer = firebaseSup.Get();
                    dynamic stiff = JObject.Parse(customer.JSONContent);
                    if (stiff.nama == "") continue;

                    nama_kalian.Add((string)stiff.nama);
                    alamat.Add((string)stiff.alamat);
                    no_hp.Add((string)stiff.hp);

                    comboBox1.Items.Add((string)stiff.nama);

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void restock_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
