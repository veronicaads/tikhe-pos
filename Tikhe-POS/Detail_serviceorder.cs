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
	public partial class Detail_serviceorder : Form
	{
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/orders");
		FirebaseDB firebase = new FirebaseDB("https://mobile-shoebox.firebaseio.com/orders_store");

		public Detail_serviceorder()
		{
			InitializeComponent();
		}

		private void Customer_Load(object sender, EventArgs e)
		{
			try
			{
				FirebaseResponse getResponse = firebase.Get();
				String cabang = Properties.Settings.Default.cabang;
				String tgl_akhir = Properties.Settings.Default.tgl_akhir;
				String tgl_awal = Properties.Settings.Default.tgl_awal;
				String servis = Properties.Settings.Default.subservis;
				String app_type = Properties.Settings.Default.servis;
				JObject stuff = JObject.Parse(getResponse.JSONContent);
				//MessageBox.Show(getResponse.JSONContent);
				IEnumerable<JToken> data= stuff.SelectTokens("$..[?(@.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
				foreach (JToken item in data) {
					dynamic stuffs = JObject.Parse(item.ToString());
					String total = stuffs.biaya;
					MessageBox.Show(total);
					//transactionBindingSource.Clear();
					transactionBindingSource.Add(new Transaction() { IDOrder = stuffs.orderid, Application = "Store", Service = stuffs.service, Subservice = stuffs.subService,  Cabang = stuffs.cabang, Customer = stuffs.customer, Tanggal = stuffs.tanggal_masuk,Total = stuffs.biaya
					});
				}
			}
			catch (Exception error)
			{
				MessageBox.Show(error.Message);
			}
		}

        int TogMove;
        int X, Y;
        private void Detail_serviceorder_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void Detail_serviceorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void Detail_serviceorder_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
