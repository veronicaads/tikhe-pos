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
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json.Linq;

namespace Tikhe_POS
{
	public partial class Restock_Graph : Form
	{
		int x = 0;
		int y = 0;
		int z = 0;
		int a = 0;
		int b = 0;
		int c = 0;
		public Restock_Graph()
		{
			InitializeComponent();
		}
		private void Chart_Load(object sender, EventArgs e)
		{
			FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/");
			FirebaseDB firebaseDBItem = firebaseDB.Node("restock_store");
			FirebaseResponse getResponse = firebaseDBItem.Get();
			JObject stuff = JObject.Parse(getResponse.JSONContent);
			//MessageBox.Show(getResponse.JSONContent);
			String tgl_akhir = Properties.Settings.Default.tgl_akhir_cs;
			String tgl_awal = Properties.Settings.Default.tgl_awal_cs;
			IEnumerable<JToken> data_item = stuff.SelectTokens("$..[?(@.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].item");
			foreach (JToken item in data_item)
			{
				//MessageBox.Show(item.ToString());
				if (item.ToString().Equals("Cat Speatu"))
				{
					x++;
				}
				else if (item.ToString().Equals("Sol"))
				{
					y++;
				}
				else if (item.ToString().Equals("Sabun Sepatu"))
				{
					z++;
				}
				else if (item.ToString().Equals("Sabun Helm"))
				{
					a++;
				}
				else if (item.ToString().Equals("Pewangi"))
				{
					b++;
				}
				else if (item.ToString().Equals("Sikat"))
				{
					c++;
				}
			}
			fillChart( x, y, z,a,b,c);
			
		}

		private void fillChart(int x, int y, int z,int a,int b,int c)
		{
			supplier.Series["Cat Sepatu"].Points.AddXY("Item", x);
			supplier.Series["Sol"].Points.AddXY("Item", y);
			supplier.Series["Sabun Sepatu"].Points.AddXY("Item", z);
			supplier.Series["Sabun Helm"].Points.AddXY("Item", a);
			supplier.Series["Pewangi"].Points.AddXY("Item", b);
			supplier.Series["Sikat Sepatu"].Points.AddXY("Item", c);
		}
	}
}
