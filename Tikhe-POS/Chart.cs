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
		int counter_reclean = 0, counter_repaint = 0, counter_repair = 0;
		int counter_x = 0, counter_y = 0, counter_z = 0, counter_a = 0, counter_b = 0, counter_c = 0, counter_d = 0;
		int counter_e = 0;

        private void pets_Click(object sender, EventArgs e)
        {

        }

        public Chart()
		{
			InitializeComponent();
		}
		public void variable_reset()
		{
			counter_reclean = 0;
			counter_repaint = 0;
			counter_repair = 0;
		}
		private void Chart_Load(object sender, EventArgs e)
		{
			DBConnect();
		}
		private void DBConnect()
		{
			FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/");
			FirebaseDB firebaseDBOrder = firebaseDB.Node("orders");
			FirebaseDB firebaseDBOrderStore = firebaseDB.Node("orders_store");
			FirebaseResponse getResponse = firebaseDBOrder.Get();
			FirebaseResponse getResponses = firebaseDBOrderStore.Get();
			JObject stuff = JObject.Parse(getResponse.JSONContent);
			JObject stuffs = JObject.Parse(getResponses.JSONContent);
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
				IEnumerable<JToken> data_mercubuana_s = stuffs.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].service");
				foreach (JToken item in data_mercubuana_s)
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
				variable_reset();
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
				IEnumerable<JToken> data_umn_s = stuffs.SelectTokens("$..[?(@.cabang == 'UMN' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].service");
				foreach (JToken item in data_umn_s)
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
				variable_reset();
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
				IEnumerable<JToken> data_aj_s = stuffs.SelectTokens("$..[?(@.cabang == 'Atmajaya' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].service");
				foreach (JToken item in data_aj_s)
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
				variable_reset();
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
				IEnumerable<JToken> data_p_s = stuffs.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].service");
				foreach (JToken item in data_p_s)
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
			else if (cabang.Equals("Mercubuana") && app_type.Equals("Store"))
			{
				if (servis.Equals("Reclean"))
				{
					IEnumerable<JToken> data_mercubuana = stuffs.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.service == 'Reclean' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_mercubuana)
					{
						if (item.ToString().Equals("Deep Clean"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Fast Clean"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Unyellwoing"))
						{
							counter_z++;
						}
					}
					fillChart_servis_reclean("Reclean", counter_x, counter_y, counter_z);
				}
				else if (servis.Equals("Repair"))
				{
					IEnumerable<JToken> data_mercubuana = stuffs.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.service == 'Repair' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_mercubuana)
					{
						if (item.ToString().Equals("Ordinary Sizing"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Full Sizing"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Ordinary Sewing"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Full Sewing"))
						{
							counter_a++;
						}
						else if (item.ToString().Equals("Remove Out Sol"))
						{
							counter_b++;
						}
						else if (item.ToString().Equals("Leather Patch"))
						{
							counter_c++;
						}
						else if (item.ToString().Equals("Remove In Sol"))
						{
							counter_d++;
						}
						else if (item.ToString().Equals("Leather Pressing"))
						{
							counter_e++;
						}
					}
					fillChart_servis_repair("Repair", counter_x, counter_y, counter_z, counter_a, counter_b, counter_c, counter_d, counter_e);
				}
				else if (servis.Equals("Repaint"))
				{
					IEnumerable<JToken> data_mercu = stuffs.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.service == 'Repaint' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_mercu)
					{
						if (item.ToString().Equals("1 Color"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("2 Color"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("3 Color"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Boost"))
						{
							counter_a++;
						}
					}
					fillChart_servis_repaint("Repaint", counter_x, counter_y, counter_z, counter_a);
				}
			}
			else if (cabang.Equals("UMN") && app_type.Equals("Store"))
			{
				if (servis.Equals("Repair"))
				{
					IEnumerable<JToken> data_umn = stuffs.SelectTokens("$..[?(@.cabang == 'UMN' && @.service == 'Repair' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_umn)
					{
						if (item.ToString().Equals("Ordinary Sizing"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Full Sizing"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Ordinary Sewing"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Full Sewing"))
						{
							counter_a++;
						}
						else if (item.ToString().Equals("Remove Out Sol"))
						{
							counter_b++;
						}
						else if (item.ToString().Equals("Leather Patch"))
						{
							counter_c++;
						}
						else if (item.ToString().Equals("Remove In Sol"))
						{
							counter_d++;
						}
						else if (item.ToString().Equals("Leather Pressing"))
						{
							counter_e++;
						}
					}
					fillChart_servis_repair("Repair", counter_x, counter_y, counter_z, counter_a, counter_b, counter_c, counter_d, counter_e);
				}
				else if (servis.Equals("Reclean"))
				{
					IEnumerable<JToken> data_umn = stuffs.SelectTokens("$..[?(@.cabang == 'UMN' && @.service == 'Reclean' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_umn)
					{
						if (item.ToString().Equals("Deep Clean"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Fast Clean"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Unyellwoing"))
						{
							counter_z++;
						}
					}
					fillChart_servis_reclean("Reclean", counter_x, counter_y, counter_z);
				}
				else if (servis.Equals("Repaint"))
				{
					IEnumerable<JToken> data_umn = stuffs.SelectTokens("$..[?(@.cabang == 'UMN' && @.service == 'Repaint' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_umn)
					{
						if (item.ToString().Equals("1 Color"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("2 Color"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("3 Color"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Boost"))
						{
							counter_a++;
						}
					}
					fillChart_servis_repaint("Repaint", counter_x, counter_y, counter_z, counter_a);
				}
			}
			else if (cabang.Equals("Pertamina") && app_type.Equals("Store"))
			{
				if (servis.Equals("Reclean"))
				{
					IEnumerable<JToken> data_pertamina = stuffs.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.service == 'Reclean' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_pertamina)
					{
						if (item.ToString().Equals("Deep Clean"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Fast Clean"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Unyellwoing"))
						{
							counter_z++;
						}
					}
					fillChart_servis_reclean("Reclean", counter_x, counter_y, counter_z);
				}
				else if (servis.Equals("Repair"))
				{
					IEnumerable<JToken> data_p = stuffs.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.service == 'Repair' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_p)
					{
						if (item.ToString().Equals("Ordinary Sizing"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Full Sizing"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Ordinary Sewing"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Full Sewing"))
						{
							counter_a++;
						}
						else if (item.ToString().Equals("Remove Out Sol"))
						{
							counter_b++;
						}
						else if (item.ToString().Equals("Leather Patch"))
						{
							counter_c++;
						}
						else if (item.ToString().Equals("Remove In Sol"))
						{
							counter_d++;
						}
						else if (item.ToString().Equals("Leather Pressing"))
						{
							counter_e++;
						}
					}
					fillChart_servis_repair("Repair", counter_x, counter_y, counter_z, counter_a, counter_b, counter_c, counter_d, counter_e);
				}
				else if (servis.Equals("Repaint"))
				{
					IEnumerable<JToken> data_p = stuffs.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.service == 'Repaint' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_p)
					{
						if (item.ToString().Equals("1 Color"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("2 Color"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("3 Color"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Boost"))
						{
							counter_a++;
						}
					}
					fillChart_servis_repaint("Repaint", counter_x, counter_y, counter_z, counter_a);
				}
			}
			else if (cabang.Equals("Atmajaya") && app_type.Equals("Store"))
			{
				if (servis.Equals("Reclean"))
				{
					IEnumerable<JToken> data_aj = stuffs.SelectTokens("$..[?(@.cabang == 'Atmajaya' && @.service == 'Reclean' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_aj)
					{
						if (item.ToString().Equals("Deep Clean"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Fast Clean"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Unyellwoing"))
						{
							counter_z++;
						}
					}
					fillChart_servis_reclean("Reclean", counter_x, counter_y, counter_z);
				}
				else if (servis.Equals("Repair"))
				{
					IEnumerable<JToken> data_aj = stuffs.SelectTokens("$..[?(@.cabang == 'Atmajaya' && @.service == 'Repair' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_aj)
					{
						if (item.ToString().Equals("Ordinary Sizing"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Full Sizing"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Ordinary Sewing"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Full Sewing"))
						{
							counter_a++;
						}
						else if (item.ToString().Equals("Remove Out Sol"))
						{
							counter_b++;
						}
						else if (item.ToString().Equals("Leather Patch"))
						{
							counter_c++;
						}
						else if (item.ToString().Equals("Remove In Sol"))
						{
							counter_d++;
						}
						else if (item.ToString().Equals("Leather Pressing"))
						{
							counter_e++;
						}
					}
					fillChart_servis_repair("Repair", counter_x, counter_y, counter_z, counter_a, counter_b, counter_c, counter_d, counter_e);
				}
				else if (servis.Equals("Repaint"))
				{
					IEnumerable<JToken> data_p = stuffs.SelectTokens("$..[?(@.cabang == 'UMN' && @.service == 'Repaint' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_p)
					{
						if (item.ToString().Equals("1 Color"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("2 Color"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("3 Color"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Boost"))
						{
							counter_a++;
						}
					}
					fillChart_servis_repaint("Repaint", counter_x, counter_y, counter_z, counter_a);
				}
			}
			else if (cabang.Equals("Mercubuana") && app_type.Equals("Mobile"))
			{
				if (servis.Equals("Reclean"))
				{
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
				else if (servis.Equals("Repair"))
				{
					IEnumerable<JToken> data_mercubuana = stuff.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.service == 'Repair' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_mercubuana)
					{
						if (item.ToString().Equals("Ordinary Sizing (10000)"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Full Sizing (15000)"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Ordinary Sewing (30000)"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Full Sewing (30000)"))
						{
							counter_a++;
						}
						else if (item.ToString().Equals("Remove Out Sol (100000)"))
						{
							counter_b++;
						}
						else if (item.ToString().Equals("Leather Patch (30000)"))
						{
							counter_c++;
						}
						else if (item.ToString().Equals("Remove In Sol (20000)"))
						{
							counter_d++;
						}
						else if (item.ToString().Equals("Leather Pressing (50000)"))
						{
							counter_e++;
						}
					}
					fillChart_servis_repair("Repair", counter_x, counter_y, counter_z, counter_a, counter_b, counter_c, counter_d, counter_e);
				}
				else if (servis.Equals("Repaint"))
				{
					IEnumerable<JToken> data_mercu = stuff.SelectTokens("$..[?(@.cabang == 'Mercubuana' && @.service == 'Repaint' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_mercu)
					{
						if (item.ToString().Equals("1 Color"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("2 Color"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("3 Color"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Boost"))
						{
							counter_a++;
						}
						fillChart_servis_repaint("Repaint", counter_x, counter_y, counter_z, counter_a);
					}
				}
			}
			else if (cabang.Equals("UMN") && app_type.Equals("Mobile"))
			{
				if (servis.Equals("Repair"))
				{
					IEnumerable<JToken> data_umn = stuff.SelectTokens("$..[?(@.cabang == 'UMN' && @.service == 'Repair' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_umn)
					{
						if (item.ToString().Equals("Ordinary Sizing (10000)"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Full Sizing (15000)"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Ordinary Sewing (30000)"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Full Sewing (30000)"))
						{
							counter_a++;
						}
						else if (item.ToString().Equals("Remove Out Sol (100000)"))
						{
							counter_b++;
						}
						else if (item.ToString().Equals("Leather Patch (30000)"))
						{
							counter_c++;
						}
						else if (item.ToString().Equals("Remove In Sol (20000)"))
						{
							counter_d++;
						}
						else if (item.ToString().Equals("Leather Pressing (50000)"))
						{
							counter_e++;
						}
					}
					fillChart_servis_repair("Repair", counter_x, counter_y, counter_z, counter_a, counter_b, counter_c, counter_d, counter_e);
				}
				else if (servis.Equals("Reclean"))
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
				else if (servis.Equals("Repaint"))
				{
					IEnumerable<JToken> data_umn = stuff.SelectTokens("$..[?(@.cabang == 'UMN' && @.service == 'Repaint' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_umn)
					{
						if (item.ToString().Equals("1 Color"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("2 Color"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("3 Color"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Boost"))
						{
							counter_a++;
						}
					}
					fillChart_servis_repaint("Repaint", counter_x, counter_y, counter_z, counter_a);
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
				else if (servis.Equals("Repair"))
				{
					IEnumerable<JToken> data_p = stuff.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.service == 'Repair' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_p)
					{
						if (item.ToString().Equals("Ordinary Sizing (10000)"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Full Sizing (15000)"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Ordinary Sewing (30000)"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Full Sewing (30000)"))
						{
							counter_a++;
						}
						else if (item.ToString().Equals("Remove Out Sol (100000)"))
						{
							counter_b++;
						}
						else if (item.ToString().Equals("Leather Patch (30000)"))
						{
							counter_c++;
						}
						else if (item.ToString().Equals("Remove In Sol (20000)"))
						{
							counter_d++;
						}
						else if (item.ToString().Equals("Leather Pressing (50000)"))
						{
							counter_e++;
						}
					}
					fillChart_servis_repair("Repair", counter_x, counter_y, counter_z, counter_a, counter_b, counter_c, counter_d, counter_e);
				}
				else if (servis.Equals("Repaint"))
				{
					IEnumerable<JToken> data_p = stuff.SelectTokens("$..[?(@.cabang == 'Pertamina' && @.service == 'Repaint' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_p)
					{
						if (item.ToString().Equals("1 Color"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("2 Color"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("3 Color"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Boost"))
						{
							counter_a++;
						}
					}
					fillChart_servis_repaint("Repaint", counter_x, counter_y, counter_z, counter_a);
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
				else if (servis.Equals("Repair"))
				{
					IEnumerable<JToken> data_aj = stuff.SelectTokens("$..[?(@.cabang == 'Atmajaya' && @.service == 'Repair' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_aj)
					{
						if (item.ToString().Equals("Ordinary Sizing (10000)"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("Full Sizing (15000)"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("Ordinary Sewing (30000)"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Full Sewing (30000)"))
						{
							counter_a++;
						}
						else if (item.ToString().Equals("Remove Out Sol (100000)"))
						{
							counter_b++;
						}
						else if (item.ToString().Equals("Leather Patch (30000)"))
						{
							counter_c++;
						}
						else if (item.ToString().Equals("Remove In Sol (20000)"))
						{
							counter_d++;
						}
						else if (item.ToString().Equals("Leather Pressing (50000)"))
						{
							counter_e++;
						}
					}
					fillChart_servis_repair("Repair", counter_x, counter_y, counter_z, counter_a, counter_b, counter_c, counter_d, counter_e);
				}
				else if (servis.Equals("Repaint"))
				{
					IEnumerable<JToken> data_umn = stuff.SelectTokens("$..[?(@.cabang == 'UMN' && @.service == 'Repaint' && @.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )].subService");
					foreach (JToken item in data_umn)
					{
						if (item.ToString().Equals("1 Color"))
						{
							counter_x++;
						}
						else if (item.ToString().Equals("2 Color"))
						{
							counter_y++;
						}
						else if (item.ToString().Equals("3 Color"))
						{
							counter_z++;
						}
						else if (item.ToString().Equals("Boost"))
						{
							counter_a++;
						}
					}
					fillChart_servis_repaint("Repaint", counter_x, counter_y, counter_z, counter_a);
				}
			}
		}
		

		private void fillChart(String cabang,int x, int y,int z)
		{
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
		private void fillChart_servis_repair(String service, int x, int y, int z,int a,int b,int c,int d,int e)
		{
			//AddXY value in chart1 in series named as Salary  
			pets.Series[service].Points.AddXY("Ordinary Sizing", x);
			pets.Series[service].Points.AddXY("Full Sizing", y);
			pets.Series[service].Points.AddXY("Ordinary Sewing", z);
			pets.Series[service].Points.AddXY("Full Sewing", a);
			pets.Series[service].Points.AddXY("Remove Out Sol", b);
			pets.Series[service].Points.AddXY("Leather Patch", c);
			pets.Series[service].Points.AddXY("Remove In Sol", d);
			pets.Series[service].Points.AddXY("Leather Pressing", e);
		}
		private void fillChart_servis_repaint(String service, int x, int y, int z, int a)
		{
			//AddXY value in chart1 in series named as Salary  
			pets.Series[service].Points.AddXY("1 Color", x);
			pets.Series[service].Points.AddXY("2 Color", y);
			pets.Series[service].Points.AddXY("3 Color", z);
			pets.Series[service].Points.AddXY("Boost", a);
		}

	}
}
