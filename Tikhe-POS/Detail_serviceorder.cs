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
		int total = 0;
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
				FirebaseResponse getResponses = firebaseDB.Get();
				String cabang = Properties.Settings.Default.cabang;
				String tgl_akhir = Properties.Settings.Default.tgl_akhir;
				String tgl_awal = Properties.Settings.Default.tgl_awal;
				String servis = Properties.Settings.Default.subservis;
				String app_type = Properties.Settings.Default.servis;
				JObject stuff = JObject.Parse(getResponse.JSONContent);
				JObject stuffss = JObject.Parse(getResponses.JSONContent);
				if (cabang.Equals("Location")) {
					IEnumerable<JToken> data = stuff.SelectTokens("$..[?(@.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(total);
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderid,
							Application = "Store",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.customer,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
					IEnumerable<JToken> data_m = stuffss.SelectTokens("$..[?(@.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data_m)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(item.ToString());
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderId,
							Application = "Mobile",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.userEmail,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
				}
				else if (cabang.Equals("Mercubuana"))
				{
					IEnumerable<JToken> data= stuff.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(total);
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderid,
							Application = "Store",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.customer,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
					IEnumerable<JToken> data_m = stuffss.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data_m)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(total);
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderId,
							Application = "Mobile",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.userEmail,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
				}
				else if (cabang.Equals("UMN"))
				{
					IEnumerable<JToken> data = stuff.SelectTokens("$..[?(@.cabang == 'UMN' && @.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(total);
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderid,
							Application = "Store",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.customer,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
					IEnumerable<JToken> data_m = stuffss.SelectTokens("$..[?(@.cabang == 'UMN' && @.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data_m)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(total);
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderId,
							Application = "Mobile",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.userEmail,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
				}
				else if (cabang.Equals("Pertamina"))
				{
					IEnumerable<JToken> data = stuff.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(total);
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderid,
							Application = "Store",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.customer,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
					IEnumerable<JToken> data_m = stuffss.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data_m)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(total);
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderId,
							Application = "Mobile",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.userEmail,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
				}
				else if (cabang.Equals("Atmajaya"))
				{
					IEnumerable<JToken> data = stuff.SelectTokens("$..[?(@.cabang == 'Atmajaya' && @.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(total);
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderid,
							Application = "Store",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.customer,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
					IEnumerable<JToken> data_m = stuffss.SelectTokens("$..[?(@.cabang == 'Atmajaya' && @.service != 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
					foreach (JToken item in data_m)
					{
						dynamic stuffs = JObject.Parse(item.ToString());
						//MessageBox.Show(total);
						transactionBindingSource2.Add(new Transaction()
						{
							IDOrder = stuffs.orderId,
							Application = "Mobile",
							Service = stuffs.service,
							Subservice = stuffs.subService,
							Cabang = stuffs.cabang,
							Customer = stuffs.userEmail,
							Tanggal = stuffs.tanggal_masuk,
							Total = stuffs.biaya
						});
						total = total + Convert.ToInt32(stuffs.biaya);
					}
				}
				textBox1.Text = total.ToString();
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
