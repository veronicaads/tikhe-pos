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
	public partial class Cust_Chart : Form
	{
		int x = 0;
		int y = 0;
		public Cust_Chart()
		{
			InitializeComponent();
		}
		private void Chart_Load(object sender, EventArgs e)
		{
			FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/");
			FirebaseDB firebaseDBCust = firebaseDB.Node("Customers");
			FirebaseResponse getResponse = firebaseDBCust.Get();
			JObject stuff = JObject.Parse(getResponse.JSONContent);
			String tgl_akhir = Properties.Settings.Default.tgl_akhir_cs;
			String tgl_awal = Properties.Settings.Default.tgl_awal_cs;
			IEnumerable<JToken> data_cust = stuff.SelectTokens("$..[?(@.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].gender");
			foreach (JToken item in data_cust) {
				if (item.ToString().Equals("Wanita"))
				{
					x++;
				}
				else
				{
					y++;
				}
			}
			fillChart(y,x);

		}
		private void fillChart(int y,int x)
		{
			//AddXY value in chart1 in series named as Salary  
			chartcust.Series["Female"].Points.AddXY("Gender", x);
			chartcust.Series["Male"].Points.AddXY("Gender", y);
		}
	}
}
