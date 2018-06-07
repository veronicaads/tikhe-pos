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
		int counter_x = 0, counter_y = 0, counter_z = 0;
		public Chart()
		{
			InitializeComponent();
		}
		private void Chart_Load(object sender, EventArgs e)
		{
			DBConnect();
		}
		//fillChart method  
		private void DBConnect()
		{
			FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/");
			FirebaseDB firebaseDBOrder = firebaseDB.Node("orders");
			FirebaseResponse getResponse = firebaseDBOrder.Get();
			JObject stuff = JObject.Parse(getResponse.JSONContent);
			String cabang = Properties.Settings.Default.cabang;
			String tgl_akhir = Properties.Settings.Default.tgl_akhir;
			String tgl_awal = Properties.Settings.Default.tgl_awal;
			String servis = Properties.Settings.Default.subservis;
			String app_type = Properties.Settings.Default.servis;
			if (cabang.Equals("Location"))
			{	
				IEnumerable<JToken> data_mercubuana = stuff.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].service");
				foreach (JToken item in data_mercubuana)
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
			else if (cabang.Equals("Mercubuana") && app_type.Equals("Mobile"))
			{
				if (servis.Equals("Reclean")) {
					IEnumerable<JToken> data_mercubuana = stuff.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.service == 'Reclean' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_mercubuana)
					{
						if (item.ToString().Equals("Deep Clean (50000)"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Fast Clean (30000)"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Unyellwoing (20000)"))
						{
							counter_z++;
						}
					}
					fillChart_servis_reclean("Reclean", counter_x, counter_y, counter_z);
				}
			}
			else if (cabang.Equals("UMN") && app_type.Equals("Mobile"))
			{
				if (servis.Equals("Reclean"))
				{
					IEnumerable<JToken> data_umn = stuff.SelectTokens("$..[?(@.cabang == 'UMN' && @.service == 'Reclean' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_umn)
					{
						if (item.ToString().Equals("Deep Clean (50000)"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Fast Clean (30000)"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Unyellwoing (20000)"))
						{
							counter_z++;
						}
					}
					fillChart_servis_reclean("Reclean", counter_x, counter_y, counter_z);
				}
			}
			else if (cabang.Equals("Pertamina") && app_type.Equals("Mobile"))
			{
				if (servis.Equals("Reclean"))
				{
					IEnumerable<JToken> data_pertamina = stuff.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.service == 'Reclean' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_pertamina)
					{
						if (item.ToString().Equals("Deep Clean (50000)"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Fast Clean (30000)"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Unyellwoing (20000)"))
						{
							counter_z++;
						}
					}
					fillChart_servis_reclean("Reclean", counter_x, counter_y, counter_z);
				}
			}
			else if (cabang.Equals("Atmajaya") && app_type.Equals("Mobile"))
			{
				if (servis.Equals("Reclean"))
				{
					IEnumerable<JToken> data_aj = stuff.SelectTokens("$..[?(@.cabang == 'Atmajaya' && @.service == 'Reclean' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_aj)
					{
						if (item.ToString().Equals("Deep Clean (50000)"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Fast Clean (30000)"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Unyellwoing (20000)"))
						{
							counter_z++;
						}
					}
					fillChart_servis_reclean("Reclean", counter_x, counter_y, counter_z);
				}
			}
		}

		private void fillChart(String cabang,int x, int y,int z)
		{
			//AddXY value in chart1 in series named as Salary  
			pets.Series[cabang].Points.AddXY("Reclean", x);
			pets.Series[cabang].Points.AddXY("Repaint", y);
			pets.Series[cabang].Points.AddXY("Repair", z);		
		}
		private void fillChart_servis_reclean(String service, int x, int y, int z)
		{
			//AddXY value in chart1 in series named as Salary  
			pets.Series[service].Points.AddXY("Deep Clean", x);
			pets.Series[service].Points.AddXY("Fast Clean", y);
			pets.Series[service].Points.AddXY("Unyellowing", z);
		}

	}
}
