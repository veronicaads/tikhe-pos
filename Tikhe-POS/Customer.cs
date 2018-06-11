using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseNet.Database;
using Newtonsoft.Json.Linq;

namespace Tikhe_POS
{
    public partial class Customer : Form
    {
        String nama, alamat, hp, email, gender;
        int id_cust;
        FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customers");
        FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customer_Status");

        public Customer()
        {
            InitializeComponent();
            nama = nama_txt.Text;
            alamat = alamat_txt.Text;
            hp = hp_txt.Text;
            email = email_txt.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nama_txt.Text = "";
            alamat_txt.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";
            nama_txt.Focus();
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();Hide();
        }
        
        private void button22_Click(object sender, EventArgs e)
        {
            nama = nama_txt.Text;
            alamat = alamat_txt.Text;
            hp = hp_txt.Text;
            email = email_txt.Text;
            String tglmasuk = DateTime.Now.ToString("yy-M-dd");
            String tmp = "C" + id_cust;
            FirebaseDB firebaseCustomer = firebaseDB.Node("C"+id_cust);
            var data="";
            if (nama_txt.Text == "" || alamat_txt.Text == "" || email_txt.Text == "" || hp_txt.Text == "" || !pria_but.Checked && !wanita_but.Checked)
            {
                MessageBox.Show("Semua Wajib Diisi !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainMenu form = new MainMenu();
                form.Show(); Hide();
            }
            else
            {
                if (pria_but.Checked)
                {
                    personBindingSource.Add(new Person() { ID = "C"+id_cust.ToString(), Nama = nama_txt.Text, JenisKelamin = "Pria", Alamat = alamat_txt.Text, Email = email_txt.Text, HP = hp_txt.Text });
                    gender = "Pria";
                    data = @"{'id':'"+tmp+"','nama' : '" + nama + "','alamat' : '" + alamat + "','hp' : '" + hp + "','email' : '" + email + "','gender' : '" + gender + "','tanggal_masuk' : '" + tglmasuk + "'}";
                }
                else
                {
                    personBindingSource.Add(new Person() { ID = "C"+id_cust.ToString(), Nama = nama_txt.Text, JenisKelamin = "Wanita", Alamat = alamat_txt.Text, Email = email_txt.Text, HP = hp_txt.Text });
                    gender = "Wanita";
                    data = @"{'id':'" + tmp + "','nama' : '" + nama + "','alamat' : '" + alamat + "','hp' : '" + hp + "','email' : '" + email + "','gender' : '" + gender + "','tanggal_masuk' : '" + tglmasuk + "'}";
                }
                id_cust++;
                firebaseCustomer.Put(data);
            }

            nama_txt.Text = "";
            alamat_txt.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";            
            var count = "";
            count = @"{'count':'" + id_cust + "'}";
            firebase.Put(count);
        }
        int selectedRow;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            nama_txt.Text = row.Cells[1].Value.ToString();
            alamat_txt.Text = row.Cells[3].Value.ToString();
            email_txt.Text = row.Cells[4].Value.ToString();
            hp_txt.Text = row.Cells[5].Value.ToString();
            if (row.Cells[2].Value.ToString().Equals("Pria")){pria_but.Checked = true;}
            else wanita_but.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nama_txt.Text == "" || alamat_txt.Text == "" || email_txt.Text == "" || hp_txt.Text == "" || !pria_but.Checked && !wanita_but.Checked)
            {
                MessageBox.Show("Semua Wajib Diisi !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow newRow = dataGridView1.Rows[selectedRow];

                FirebaseDB firebaseCustomer = firebaseDB.Node(newRow.Cells[0].Value.ToString());
                FirebaseResponse customer = firebaseCustomer.Get();
                dynamic stiff = JObject.Parse(customer.JSONContent);

                newRow.Cells[1].Value = nama_txt.Text;
                newRow.Cells[3].Value = alamat_txt.Text;
                newRow.Cells[4].Value = email_txt.Text;
                newRow.Cells[5].Value = hp_txt.Text;
                
                if (pria_but.Checked) gender = "Pria";
                else gender = "Wanita";
                newRow.Cells[2].Value = gender;

                var data = "";
                data = @"{'id':'" + stiff.id + "','nama' : '" + nama_txt.Text + "','alamat' : '" + alamat_txt.Text + "','hp' : '" + hp_txt.Text + "','email' : '" + email_txt.Text + "','gender' : '" + gender + "'}";
                firebaseCustomer.Patch(data);

                nama_txt.Text = "";
                alamat_txt.Text = "";
                hp_txt.Text = "";
                email_txt.Text = "";

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            
            nama_txt.Text = "";
            alamat_txt.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";

            gender = "";

            DataGridViewRow newRow = dataGridView1.Rows[selectedRow];
            FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customers");
            FirebaseDB firebaseCustomer = firebaseDB.Node(newRow.Cells[0].Value.ToString());
            MessageBox.Show(newRow.Cells[0].Value.ToString());
            var data = "";
            data = @"{'id':'" + "XXX" + "','nama' : '" + nama_txt.Text + "','alamat' : '" + alamat_txt.Text + "','hp' : '" + hp_txt.Text + "','email' : '" + email_txt.Text + "','gender' : '" + gender + "','tanggal_masuk' : '"+""+"'}";
            firebaseCustomer.Patch(data);

            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="") MessageBox.Show("Kosong !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                String search = textBox1.Text;
			}
            
        }

        int TogMove;
        int X, Y;
        private void Customer_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

		private void dataGridView1_Sorted(object sender, EventArgs e)
		{

		}

		private void Customer_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }
        
        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse getResponse = firebase.Get();
                dynamic stuff = JObject.Parse(getResponse.JSONContent);
                String jumlah = stuff.count;
                id_cust = Convert.ToInt32(jumlah);

                for(int i = 0; i < id_cust; i++)
                {
                    FirebaseDB firebaseCustomer = firebaseDB.Node("C"+i);
                    FirebaseResponse customer = firebaseCustomer.Get();
                    dynamic stiff = JObject.Parse(customer.JSONContent);
                    if (stiff.nama=="") continue;
                    
                    personBindingSource.Add(new Person()
					{ ID = stiff.id,
						Nama = stiff.nama,
						JenisKelamin = stiff.gender,
						Alamat = stiff.alamat,
						Email = stiff.email,
						HP = stiff.hp });
                }



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
			FirebaseResponse customer = firebaseDB.Get();
			dynamic stuff = JObject.Parse(customer.JSONContent);
			IEnumerable<JToken> name =  stuff.SelectTokens("$..[?(@.nama >= '"+ textBox1.Text +"')]");
			String search_nama = textBox1.Text;
			String sub_search_name = search_nama.Substring(0, search_nama.Length);
			personBindingSource.Clear();
			foreach (JToken item in name) { 
				dynamic items = JObject.Parse(item.ToString());
				String id = items.id;
				String nama_sub = items.nama;
				String nama_disub = nama_sub.Substring(0, search_nama.Length);
				if (id.Equals("XXX")) { }
				else
				{
					if (nama_disub.Equals(sub_search_name)) {
						personBindingSource.Add(new Person()
						{ ID = items.id,
							Nama = items.nama,
							JenisKelamin = items.gender,
							Alamat = items.alamat,
							Email = items.email,
							HP = items.hp });
					}
				}
			}
		}

        private void Customer_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
