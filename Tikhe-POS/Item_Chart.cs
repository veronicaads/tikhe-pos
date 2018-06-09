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
	public partial class Item_Chart : Form
	{
		int x = 0;
		int y = 0;
		int z = 0;
		private void reset_init() {
			x = y = z = 0;
		}
		public Item_Chart()
		{
			InitializeComponent();
		}
		private void Chart_Load(object sender, EventArgs e)
		{
			FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/");
			FirebaseDB firebaseDBItem = firebaseDB.Node("orders_store");
			FirebaseResponse getResponse = firebaseDBItem.Get();
			JObject stuff = JObject.Parse(getResponse.JSONContent);
			String tgl_akhir = Properties.Settings.Default.tgl_akhir_cs;
			String tgl_awal = Properties.Settings.Default.tgl_awal_cs;
			IEnumerable<JToken> data_item = stuff.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.service == 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
			foreach (JToken item in data_item)
			{
				if (item.ToString().Equals("Sabun 1")) {
					x++;
				}
				else if (item.ToString().Equals("Sabun 2"))
				{
					y++;
				}
				else if (item.ToString().Equals("Sabun 3"))
				{
					z++;
				}
			}
			fillChart("Mercubuana",x,y,z);
			reset_init();
			IEnumerable<JToken> data_umn = stuff.SelectTokens("$..[?(@.cabang == 'UMN' && @.service == 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
			foreach (JToken item in data_umn)
			{
				if (item.ToString().Equals("Sabun 1"))
				{
					x++;
				}
				else if (item.ToString().Equals("Sabun 2"))
				{
					y++;
				}
				else if (item.ToString().Equals("Sabun 3"))
				{
					z++;
				}
			}
			fillChart("UMN", x, y, z);
			reset_init();
			IEnumerable<JToken> data_atma = stuff.SelectTokens("$..[?(@.cabang == 'Atmajaya' && @.service == 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
			foreach (JToken item in data_atma)
			{
				//MessageBox.Show(item.ToString());
				if (item.ToString().Equals("Sabun 1"))
				{
					x++;
				}
				else if (item.ToString().Equals("Sabun 2"))
				{
					y++;
				}
				else if (item.ToString().Equals("Sabun 3"))
				{
					z++;
				}
				//MessageBox.Show(z.ToString());
			}
			fillChart("Atmajaya", x, y, z);
			reset_init();
			IEnumerable<JToken> data_p = stuff.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.service == 'Sabun' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
			foreach (JToken item in data_p)
			{
				if (item.ToString().Equals("Sabun 1"))
				{
					x++;
				}
				else if (item.ToString().Equals("Sabun 2"))
				{
					y++;
				}
				else if (item.ToString().Equals("Sabun 3"))
				{
					z++;
				}
			}
			fillChart("Pertamina", x, y, z);
		}

		private void fillChart(String cabang, int x,int y,int z)
		{
			item.Series[cabang].Points.AddXY("Sabun Tipe 1", x);
			item.Series[cabang].Points.AddXY("Sabun Tipe 2", y);
			item.Series[cabang].Points.AddXY("Sabun Tipe 3", z);
		}
	}
}
