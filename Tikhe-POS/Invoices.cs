using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FirebaseNet.Database;
using System.Drawing.Printing;
using Newtonsoft.Json.Linq;

namespace Tikhe_POS
{
	public partial class Invoices : Form
	{
		public Invoices()
		{
			InitializeComponent();
		}
		FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/orders_store");
		private void Invoice_Load(object sender, EventArgs e)
		{
			try
			{
				int total = 0;
				FirebaseResponse getResponse = firebaseDB.Get();
				String customer = Properties.Settings.Default.customer;
				String tanggal = Properties.Settings.Default.tanggal_order;
				String cabang = Properties.Settings.Default.cabang;
				JObject stuff = JObject.Parse(getResponse.JSONContent);
				IEnumerable<JToken> data = stuff.SelectTokens("$..[?(@.cabang == '" + cabang + "' && @.tanggal_masuk == '" + tanggal + "' && @.customer == '" + customer + "' )]");
				foreach (JToken item in data)
				{
					dynamic stuffs = JObject.Parse(item.ToString());
					invoiceBindingSource.Add(new Invoice()
					{
						IDOrder = stuffs.orderid,
						Service = stuffs.service,
						Subservice = stuffs.subService,
						Total = stuffs.biaya
					});
					total = total + Convert.ToInt32(stuffs.biaya);
				}
				textBox1.Text = total.ToString();
				cabang_text.Text = cabang;
				nama.Text = customer;
				tanggal_text.Text = tanggal;
			}
			catch (Exception error)
			{
				MessageBox.Show(error.Message);
			}
		}
		Bitmap memoryImage;
		private void CaptureScreen()
		{
			Graphics myGraphics = this.CreateGraphics();
			Size s = this.Size;
			memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
			Graphics memoryGraphics = Graphics.FromImage(memoryImage);
			memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CaptureScreen();
			printDocument1.Print();
			printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(memoryImage, 0, 0);
		}
	}
}
