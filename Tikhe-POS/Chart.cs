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
	public partial class Chart : Form
	{
		int counter_reclean = 0 , counter_repaint = 0, counter_repair = 0;
		public Chart()
		{
			InitializeComponent();
		}
		private void Chart_Load(object sender, EventArgs e)
		{
			DBConnect();
		}

        private void pets_Click(object sender, EventArgs e)
        {

        }

        //fillChart method  
        private void DBConnect()
		{
			FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/");
			FirebaseDB firebaseDBOrder = firebaseDB.Node("orders");
			String cabang = Properties.Settings.Default.cabang;
			String tgl_akhir = Properties.Settings.Default.tgl_akhir;
			String tgl_awal = Properties.Settings.Default.tgl_awal;
			String subservis = Properties.Settings.Default.cabang;
			if (cabang.Equals("Location"))
			{
				FirebaseResponse getResponse = firebaseDBOrder.Get();
				JObject stuff = JObject.Parse(getResponse.JSONContent);
				IEnumerable<JToken> data_mercubuana = stuff.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].service");
				foreach (JToken item in data_mercubuana) {
					if (item.ToString().Equals("Reclean"))
					{
						counter_reclean++;
					}
					else if (item.ToString().Equals("Repaint"))
					{
						counter_repaint++;
					}
					else if (item.ToString().Equals("Repair"))
					{
						counter_repair++;
					}
				}
				fillChart("Mercubuana", counter_reclean, counter_repaint, counter_repair);
				IEnumerable<JToken> data_umn = stuff.SelectTokens("$..[?(@.cabang == 'UMN' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].service");
				foreach (JToken item in data_umn)
				{
					if (item.ToString().Equals("Reclean"))
					{
						counter_reclean++;
					}
					else if (item.ToString().Equals("Repaint"))
					{
						counter_repaint++;
					}
					else if (item.ToString().Equals("Repair"))
					{
						counter_repair++;
					}
				}
				fillChart("UMN", counter_reclean, counter_repaint, counter_repair);
				IEnumerable<JToken> data_atma = stuff.SelectTokens("$..[?(@.cabang == 'Atmajaya' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].service");
				foreach (JToken item in data_atma)
				{
					if (item.ToString().Equals("Reclean"))
					{
						counter_reclean++;
					}
					else if (item.ToString().Equals("Repaint"))
					{
						counter_repaint++;
					}
					else if (item.ToString().Equals("Repair"))
					{
						counter_repair++;
					}
				}
				fillChart("Atmajaya", counter_reclean, counter_repaint, counter_repair);
				IEnumerable<JToken> data_pertamina = stuff.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].service");
				foreach (JToken item in data_pertamina)
				{
					if (item.ToString().Equals("Reclean"))
					{
						counter_reclean++;
					}
					else if (item.ToString().Equals("Repaint"))
					{
						counter_repaint++;
					}
					else if (item.ToString().Equals("Repair"))
					{
						counter_repair++;
					}
				}
				fillChart("Pertamina", counter_reclean, counter_repaint, counter_repair);
			}
		}

		private void fillChart(String cabang,int x, int y,int z)
		{
			//AddXY value in chart1 in series named as Salary  
			pets.Series[cabang].Points.AddXY("Reclean", x);
			pets.Series[cabang].Points.AddXY("Repaint", y);
			pets.Series[cabang].Points.AddXY("Repair", z);
			
		}

	}
}
