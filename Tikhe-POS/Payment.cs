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
using System.IO;

namespace Tikhe_POS
{
    public partial class Payment : Form
    {
        int total_harga;
        string order;
        public Payment(int total, string order_id)
        {
            InitializeComponent();
            total_harga = total;
            order = order_id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int TogMove;
        int X, Y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void Payment_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void Payment_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void Payment_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            label8.Text = total_harga.ToString();
        }

        private void username_edit_TextChanged(object sender, EventArgs e)
        {
            label7.Text = (Convert.ToInt32(username_edit.Text) - total_harga).ToString();
            if (Convert.ToInt32(label7.Text) < 0)
            {
                label7.Text = "0";
            }
        }

        private void username_edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //label7.Text = (Convert.ToInt32(username_edit.Text) - total_harga).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/orders_store");
            FirebaseDB isi = firebaseDB.Node(order);
            FirebaseResponse getResponse = isi.Get();

            List<string> tmp = new List<string>();
            dynamic stuff = JObject.Parse(getResponse.JSONContent);
            tmp.Add((string)stuff.biaya);
            tmp.Add((string)stuff.cabang);
            tmp.Add((string)stuff.customer);
            tmp.Add((string)stuff.diskon);
            tmp.Add((string)stuff.merek_sepatu);
            tmp.Add((string)stuff.orderid);
            tmp.Add((string)stuff.pembayaran);
            tmp.Add((string)stuff.service);
            tmp.Add((string)stuff.subservice);
            tmp.Add((string)stuff.tanggal_masuk);



            var data = "";
            data = @"{'customer':'" + tmp[2] + "','biaya':'" + tmp[0] + "','pembayaran' : '" + comboBox1.Text + "','cabang' : '" + tmp[1] + "','merek_sepatu' : '" + tmp[4] + "','orderid' : '" + tmp[5] + "','service' : '" + tmp[7] + "','subservice' : '" + tmp[8] + "','diskon' : '" + tmp[3] + "','tanggal_masuk' : '" + tmp[9] + "'}";
            isi.Patch(data);

            /*
            using (StreamWriter sw = new StreamWriter("D:/" + order + ".txt"))
            {

                sw.WriteLine("==========================================================================");
                sw.WriteLine("==================================SHOEBOX================================");
                sw.WriteLine("==========================================================================");
                sw.WriteLine("");
                sw.WriteLine("Nama Customer  : " + tmp[2]);
                sw.WriteLine("Merek Sepatu  : " + tmp[4]);
                sw.WriteLine(""); sw.WriteLine("");
                sw.WriteLine("--------------------------------------------------------------------------");
                sw.WriteLine("Service : " + stuff.service);
                sw.WriteLine("SubService : " + stuff.subservice);
                sw.WriteLine(""); sw.WriteLine("");
                sw.WriteLine("Diskon : " + stuff.diskon);
                sw.WriteLine("Biaya : " + stuff.biaya);
                sw.WriteLine("==========================================================================");
                sw.WriteLine("==========================================================================");
                sw.Flush();
                sw.Close(); 
            }*/

            MainMenu balik = new MainMenu();
            balik.Show();Hide();
			Invoices invoice = new Invoices();
			invoice.Show();
			
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
