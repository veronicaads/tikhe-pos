using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using FirebaseNet.Database;
using System.Drawing.Printing;
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

		private void ToCsV(DataGridView dGV, string filename)
		{
			string stOutput = "";
			// Export titles:
			string sHeaders = "";

			for (int j = 0; j < dGV.Columns.Count; j++)
				sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
			stOutput += sHeaders + "\r\n";
			// Export data.
			for (int i = 0; i < dGV.RowCount - 1; i++)
			{
				string stLine = "";
				for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
					stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
				stOutput += stLine + "\r\n";
			}
			Encoding utf16 = Encoding.GetEncoding(1254);
			byte[] output = utf16.GetBytes(stOutput);
			FileStream fs = new FileStream(filename, FileMode.Create);
			BinaryWriter bw = new BinaryWriter(fs);
			bw.Write(output, 0, output.Length); //write the encoded file
			bw.Flush();
			bw.Close();
			fs.Close();
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

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "export.xls";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				//ToCsV(dataGridView1, @"c:\export.xls");
				ToCsV(orderBinding, sfd.FileName); // Here dataGridview1 is your grid view name
			}
		}
		Bitmap bitmap;
		private void button3_Click(object sender, EventArgs e)
		{
			printDocument1.Print();
		}
		private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			//Print the contents.
			e.Graphics.DrawImage(bitmap, 0, 0);
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			Bitmap bm = new Bitmap(this.orderBinding.Width, this.orderBinding.Height);
			orderBinding.DrawToBitmap(bm, new Rectangle(0, 0, this.orderBinding.Width, this.orderBinding.Height));
			e.Graphics.DrawImage(bm, 0, 0);
		}
	}
}
