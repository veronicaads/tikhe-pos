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
    public partial class confirmation : Form
    {
        String tanggal;
        String customer;
        
        public confirmation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("asd");
            tanggal = this.dateTimePicker1.Value.ToString("yy-M-dd");
            customer = combo_customer.Text;
            DateTime today = DateTime.Today;
            String tanggal_keluar = today.ToString("yy-M-dd");
            FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/");
            FirebaseDB firebaseDBCust = firebaseDB.Node("orders_store");
            FirebaseResponse getResponse = firebaseDBCust.Get();
            JObject stuff = JObject.Parse(getResponse.JSONContent);
            IEnumerable<JToken> data_cust = stuff.SelectTokens("$..[?(@.tanggal_masuk == '" + tanggal + "' && @.customer == '" + customer + "' )].orderid");
            foreach (JToken item in data_cust)
            {
                
                String orderid = item.ToString();
                MessageBox.Show(orderid);
                FirebaseDB firebaseDB_order = new FirebaseDB("https://mobile-shoebox.firebaseio.com/orders_store/" + orderid);
                FirebaseResponse order = firebaseDB_order.Get();
                dynamic stiff = JObject.Parse(order.JSONContent);
                var pesanan = @"{'customer':'" + stiff.customer + "','biaya':'" + stiff.biaya + "','pembayaran' : '" + "-" + "','cabang' : '" + stiff.cabang + "','merek_sepatu' : '" + stiff.merek_Sepatu + "','orderid' : '" + stiff.orderid + "','service' : '" + stiff.service + "','subService' : '" + stiff.subService + "','diskon' : '" + stiff.diskon + "','tanggal_masuk' : '" + tanggal + "','tanggal_keluar' : '" + tanggal_keluar + "'}";
                firebaseDB_order.Patch(pesanan);
            }

        }

        private void combo_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
           customer  = combo_customer.Text;
            //MessageBox.Show(supplier);
            FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customers");
            FirebaseResponse cust = firebaseDB.Get();
            dynamic stuff = JObject.Parse(cust.JSONContent);
            //MessageBox.Show(vendor.JSONContent);
            JToken custs = stuff.SelectToken("$..[?(@.nama == '" + customer + "')]");
            dynamic items = JObject.Parse(custs.ToString());
            //MessageBox.Show(items);
            
        }

        private void confirmation_Load(object sender, EventArgs e)
        {
            try
            {
                FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customer_Status");
                FirebaseResponse getResponse = firebase.Get();
                dynamic stuff = JObject.Parse(getResponse.JSONContent);
                String jumlah = stuff.count;
                int id_cust = Convert.ToInt32(jumlah);

                for (int i = 0; i < id_cust; i++)
                {
                    FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Customers");
                    FirebaseDB firebaseCustomer = firebaseDB.Node("C" + i);
                    FirebaseResponse customer = firebaseCustomer.Get();
                    dynamic stiff = JObject.Parse(customer.JSONContent);
                    if (stiff.nama == "") continue;

                    combo_customer.Items.Add((string)stiff.nama);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
        int TogMove;
        int SumbuX, SumbuY;
        private void confirmation_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            SumbuX = e.X;
            SumbuY = e.Y;
        }

        private void confirmation_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - SumbuX, MousePosition.Y - SumbuY);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tanggal = this.dateTimePicker1.Value.ToString("yy-M-dd");
        }

        private void confirmation_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
