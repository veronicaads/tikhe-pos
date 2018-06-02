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
        String nama;
        String alamat;
        String hp;
        String email;
        String merek;
        String gender;
        String id_customer;
        int Count_Customer=0;
        public Customer()
        {
            InitializeComponent();
            nama = nama_txt.Text;
            alamat = alamat_txt.Text;
            hp = hp_txt.Text;
            email = email_txt.Text;
            merek = merk_txt.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            nama_txt.Text = "";
            alamat_txt.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";
            merk_txt.Text = "";
        }
        int id_cust;
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
            merek = merk_txt.Text;

            

            FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customers");
            FirebaseDB firebaseCustomer = firebaseDB.Node("C"+id_cust);
            var data="";
            if (nama_txt.Text == "" || alamat_txt.Text == "" || email_txt.Text == "" || hp_txt.Text == "" || merk_txt.Text == "" || !pria_but.Checked && !wanita_but.Checked)
            {
                MessageBox.Show("Semua Wajib Diisi !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainMenu form = new MainMenu();
                form.Show(); Hide();
            }
            else
            {
                if (pria_but.Checked)
                {
                    personBindingSource.Add(new Person() { ID = id_cust.ToString(), Nama = nama_txt.Text, JenisKelamin = "P", Alamat = alamat_txt.Text, Email = email_txt.Text, HP = hp_txt.Text, MerkSepatu = merk_txt.Text });
                    gender = "Pria";
                    data = @"{'id':'"+id_cust+"','nama' : '" + nama + "','alamat' : '" + alamat + "','hp' : '" + hp + "','email' : '" + email + "','merk' : '" + merek + "','gender' : '" + gender + "'}";
                }
                else
                {
                    personBindingSource.Add(new Person() { ID = id_cust.ToString(), Nama = nama_txt.Text, JenisKelamin = "W", Alamat = alamat_txt.Text, Email = email_txt.Text, HP = hp_txt.Text, MerkSepatu = merk_txt.Text });
                    gender = "Wanita";
                    data = @"{'id':'" + id_cust + "','nama' : '" + nama + "','alamat' : '" + alamat + "','hp' : '" + hp + "','email' : '" + email + "','merk' : '" + merek + "','gender' : '" + gender + "'}";
                }
                id_cust++;
                firebaseCustomer.Put(data);
            }

            nama_txt.Text = "";
            alamat_txt.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";
            merk_txt.Text = "";

            FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customer_Status");
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
            alamat_txt.Text = row.Cells[4].Value.ToString();
            email_txt.Text = row.Cells[6].Value.ToString();
            hp_txt.Text = row.Cells[3].Value.ToString();
            merk_txt.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nama_txt.Text == "" || alamat_txt.Text == "" || email_txt.Text == "" || hp_txt.Text == "" || merk_txt.Text == "" || !pria_but.Checked && !wanita_but.Checked)
            {
                MessageBox.Show("Semua Wajib Diisi !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow newRow = dataGridView1.Rows[selectedRow];
                newRow.Cells[1].Value = nama_txt.Text;
                newRow.Cells[4].Value = alamat_txt.Text;
                newRow.Cells[6].Value = email_txt.Text;
                newRow.Cells[3].Value = hp_txt.Text;
                newRow.Cells[5].Value = merk_txt.Text;
                nama_txt.Text = "";
                alamat_txt.Text = "";
                hp_txt.Text = "";
                email_txt.Text = "";
                merk_txt.Text = "";
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nama_txt.Text = "";
            alamat_txt.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";
            merk_txt.Text = "";
            selectedRow = dataGridView1.CurrentCell.RowIndex;
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
                FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customer_Status");
                FirebaseResponse getResponse = firebase.Get();
                dynamic stuff = JObject.Parse(getResponse.JSONContent);
                String jumlah = stuff.count;
                id_cust = Convert.ToInt32(jumlah);

                FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customers");
                for(int i = 0; i < id_cust; i++)
                {
                    FirebaseDB firebaseCustomer = firebaseDB.Node("C"+i);
                    FirebaseResponse customer = firebaseCustomer.Get();
                    dynamic stiff = JObject.Parse(customer.JSONContent);
                    personBindingSource.Add(new Person() { ID = "C" + i, Nama = stiff.nama, JenisKelamin = stiff.gender, Alamat = stiff.alamat, Email = stiff.email, HP = stiff.hp, MerkSepatu = stiff.merek });

                }



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //DataTable dbset;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*string searchValue = textBox1.Text;
            dbset = new DataTable();
            DataView dv = new DataView(dbset);
            dv.RowFilter = String.Format("Nama LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;*/
        }

        private void Customer_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
