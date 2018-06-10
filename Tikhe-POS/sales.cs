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
            orderBindingSource1.Add(new Order() { No = "S01", SubService = "Fast Clean", Harga = "30000", Service="Reclean"});
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Fast Clean");
            service.Add("Reclean");
            harga_sub.Add("30000");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S04", SubService = "Ordinary Sizing", Harga = "10000", Service = "Reclean" });
            total_harga += 10000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Ordinary Sizing");
            service.Add("Repair");
            harga_sub.Add("10000");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            Hide();
        }
        List<string> service = new List<string>();
        List<string> subservice = new List<string>();
        List<string> harga_sub = new List<string>();


        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S02", SubService = "Deep Clean", Harga = "50000", Service="Reclean"});
            total_harga += 50000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Deep Clean");
            service.Add("Reclean");
            harga_sub.Add("50000");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S03", SubService = "Unyellowing", Harga = "20000", Service="Reclean" });
            total_harga += 20000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Unyellowing");
            service.Add("Reclean");
            harga_sub.Add("20000");
        }
        int selectedRows;
        String tmp;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
            {
                if(MessageBox.Show("Are you sure to cancel this service ?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    selectedRows = e.RowIndex;
                    DataGridViewRow row = dataGridView2.Rows[selectedRows];
                    tmp = row.Cells[2].Value.ToString();
                    harga_sub.Remove(tmp);
                    total_harga = total_harga - Convert.ToInt32(tmp);
                    subtotal_txt.Text = total_harga.ToString();
                    total_txt.Text = total_harga.ToString();
                    tmp = row.Cells[4].Value.ToString();
                    service.Remove(tmp);
                    subservice.Remove(tmp);
                    orderBindingSource1.RemoveCurrent();                  
                }
            }
        }

        private void full_sizing_btn_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S05", SubService = "Full Sizing", Harga = "15000", Service="Repair" });
            total_harga += 15000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Full Sizing");
            service.Add("Reclean");
            harga_sub.Add("15000");
        }

        private void ordinary_sewing_btn_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S06", SubService = "Ordinary Sewing", Harga = "30000", Service="Repair" });
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Ordinary Sewing");
            service.Add("Repair");
            harga_sub.Add("30000");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S07", SubService = "Full Sewing", Harga = "30000", Service = "Repair" });
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Full Sewing");
            service.Add("Repair");
            harga_sub.Add("30000");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S08", SubService = "Remove Out Sol", Harga = "100000", Service = "Repair" });
            total_harga += 100000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Remove Out Sol");
            service.Add("Repair");
            harga_sub.Add("100000");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S09", SubService = "Leather Patch", Harga = "30000", Service = "Repair" });
            total_harga += 30000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Leather Patch");
            service.Add("Repair");
            harga_sub.Add("30000");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S10", SubService = "Remove In Sol", Harga = "20000", Service = "Repair" });
            total_harga += 20000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            total_txt.Text = subtotal_txt.Text;
            subservice.Add("Remove In Sol");
            service.Add("Repair");
            harga_sub.Add("20000");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S11", SubService = "Leather Pressing", Harga = "50000", Service = "Repair" });
            total_harga += 50000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Leather Pressing");
            service.Add("Repair");
            harga_sub.Add("50000");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S12", SubService = "1 Color", Harga = "100000", Service="Repaint" });
            total_harga += 100000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("1 Color");
            service.Add("Repaint");
            harga_sub.Add("100000");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S12", SubService = "2 Color", Harga = "120000", Service = "Repaint" });
            total_harga += 120000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("2 Color");
            service.Add("Repaint");
            harga_sub.Add("120000");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S13", SubService = "3 Color", Harga = "250000", Service = "Repaint" });
            total_harga += 250000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("3 Color");
            service.Add("Repaint");
            harga_sub.Add("250000");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S15", SubService = "Boost", Harga = "70000", Service = "Repaint" });
            total_harga += 70000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Boost");
            service.Add("Repaint");
            harga_sub.Add("70000");
        }


        private string generate_orderid(string a, int id)
        {
            String data="";
            if (id < 9 && id >= 0) data = a + "000" + id;
            else if (id > 9 && id <100) data = a + "00" + id;
            else if (id > 99 && id < 1000) data = a + "0" + id;
            else if (id > 999 && id < 10000) data = a + id;
            return data;
        }

        private void subtotal_txt_Click(object sender, EventArgs e)
        {

        }
        int umn_order, pertamina_order, mercubuana_order, atmajaya_order;
        private void button23_Click(object sender, EventArgs e)
        {
            if (cabang_combo.Text.Equals(""))
            {
                MessageBox.Show("Wajib Memilih cabang service !");
            }
            else
            {
                String tanggalmasuk = DateTime.Now.ToString("yy-M-dd");

                FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/orders_store");

                FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/order_keys");

                FirebaseResponse getResponse = firebase.Get();
                String order_id = "";
                var data = "";
                var pesanan = "";
                dynamic stuff = JObject.Parse(getResponse.JSONContent);
                umn_order = Convert.ToInt32(stuff.umn);
                pertamina_order = Convert.ToInt32(stuff.pertamina);
                mercubuana_order = Convert.ToInt32(stuff.mercubuana);
                atmajaya_order = Convert.ToInt32(stuff.atmajaya);

                for (int i = 0; i < service.Count; i++)
                {
                    if (cabang_combo.Text.Equals("UMN")) { umn_order += 1; order_id = generate_orderid("u", umn_order); }
                    else if (cabang_combo.Text.Equals("Pertamina")) { pertamina_order += 1; order_id = generate_orderid("p", pertamina_order); }
                    else if (cabang_combo.Text.Equals("Mercubuana")) { mercubuana_order += 1; order_id = generate_orderid("m", mercubuana_order); }
                    else if (cabang_combo.Text.Equals("Atmajaya")) { atmajaya_order += 1; order_id = generate_orderid("a", atmajaya_order); }
                    else if (cabang_combo.Text.Equals("Others"))
                    {

                    }

                    pesanan = @"{'customer':'" + combo_customer.Text + "','biaya':'" + harga_sub[i] + "','pembayaran' : '" + "-" + "','cabang' : '" + cabang_combo.Text + "','merek_sepatu' : '" + comboBox2.Text + "','orderid' : '" + order_id + "','service' : '" + service[i] + "','subService' : '" + subservice[i] + "','diskon' : '" + diskon_txt.Text + "','tanggal_masuk' : '" + tanggalmasuk + "'}";
                    //pesanan = @"{'customer':'" + combo_customer.Text + "','biaya':'" + total_txt.Text + "','pembayaran' : '" + "-" + "','cabang' : '" + cabang_combo.Text + "','merek_sepatu' : '" + comboBox2.Text + "','orderid' : '" + order_id + "','service' : '" + service[i] + "','subService' : '" + subservice[i] + "','diskon' : '" + diskon_txt.Text + "','tanggal_masuk' : '" + tanggalmasuk + "'}";

                    FirebaseDB Orders = firebaseDB.Node(order_id);
                    Orders.Put(pesanan);
                }

                data = @"{'UMN':'" + umn_order + "','atmajaya' : '" + atmajaya_order + "','laci' : '" + "occupied" + "','mercubuana' : '" + mercubuana_order + "','pertamina' : '" + pertamina_order + "','umn' : '" + umn_order + "'}";
                firebase.Patch(data);
				Properties.Settings.Default.cabang = cabang_combo.Text;
				Properties.Settings.Default.customer = combo_customer.Text;
				Properties.Settings.Default.tanggal_order = tanggalmasuk;
				total_harga = Convert.ToInt32(total_txt.Text);
                Payment form = new Payment(total_harga, order_id);
                form.Show(); Hide();
				
            }
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<string> nama_kalian = new List<string>();
        List<string> alamat = new List<string>();
        List<string> no_hp = new List<string>();
        int id_cust;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) diskon_txt.Text = "0";
            else diskon_txt.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(subtotal_txt.Text)/100).ToString();
            total_txt.Text= (Convert.ToInt32(subtotal_txt.Text) - Convert.ToInt32(diskon_txt.Text)).ToString();
        }

        private void total_txt_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S20", SubService = "Sabun 1", Harga = "25000", Service = "Sabun" });
            total_harga += 25000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Sabun 1");
            service.Add("Sabun");
            harga_sub.Add("25000");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S21", SubService = "Sabun 2", Harga = "45000", Service = "Sabun" });
            total_harga += 45000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Sabun 2");
            service.Add("Sabun");
            harga_sub.Add("45000");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderBindingSource1.Add(new Order() { No = "S22", SubService = "Sabun 3", Harga = "65000", Service = "Sabun" });
            total_harga += 65000;
            subtotal_txt.Text = total_harga.ToString();
            total_txt.Text = total_harga.ToString();
            subservice.Add("Sabun 3");
            service.Add("Sabun");
            harga_sub.Add("65000");
        }

        private void cabang_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void sales_Load(object sender, EventArgs e)
        {
            


            try
            {
                FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customer_Status");
                FirebaseResponse getResponse = firebase.Get();
                dynamic stuff = JObject.Parse(getResponse.JSONContent);
                String jumlah = stuff.count;
                id_cust = Convert.ToInt32(jumlah);

                for (int i = 0; i < id_cust; i++)
                {
                    FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customers");
                    FirebaseDB firebaseCustomer = firebaseDB.Node("C" + i);
                    FirebaseResponse customer = firebaseCustomer.Get();
                    dynamic stiff = JObject.Parse(customer.JSONContent);
                    if (stiff.nama == "") continue;

                    nama_kalian.Add((string)stiff.nama);
                    alamat.Add((string)stiff.alamat);
                    no_hp.Add((string)stiff.hp);

                    combo_customer.Items.Add((string)stiff.nama);

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void combo_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
			String customer = combo_customer.Text;
			//MessageBox.Show(supplier);
			FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customers");
			FirebaseResponse cust = firebaseDB.Get();
			dynamic stuff = JObject.Parse(cust.JSONContent);
			//MessageBox.Show(vendor.JSONContent);
			JToken custs = stuff.SelectToken("$..[?(@.nama == '" + customer + "')]");
			dynamic items = JObject.Parse(custs.ToString());
			//MessageBox.Show(items);
			label11.Text = items.nama;
			label12.Text = items.alamat;
			label13.Text = items.hp;
		}

        private void combo_customer_TextChanged(object sender, EventArgs e)
        {
        }

        private void sales_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
