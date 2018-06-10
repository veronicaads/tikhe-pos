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
	public partial class Inventory_Report_Detail : Form
	{
		public Inventory_Report_Detail()
		{
			InitializeComponent();
		}

		FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/restock_store");
		private void orderBinding_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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

		private void button3_Click(object sender, EventArgs e)
		{
			Inventory_Report_Detail form = new Inventory_Report_Detail();
			form.Close();
		}
		private void Inventory_Load(object sender, EventArgs e)
		{
			try
			{
				int total = 0;
				FirebaseResponse getResponse = firebaseDB.Get();
				String tgl_akhir = Properties.Settings.Default.tgl_akhir_cs;
				String tgl_awal = Properties.Settings.Default.tgl_awal_cs;
				JObject stuff = JObject.Parse(getResponse.JSONContent);
				IEnumerable<JToken> data = stuff.SelectTokens("$..[?(@.tanggal_masuk >= '" + tgl_awal + "' && @.tanggal_masuk < '" + tgl_akhir + "' )]");
				foreach (JToken item in data)
				{
					dynamic stuffs = JObject.Parse(item.ToString());
					inventoriBindingSource.Add(new Inventori()
					{
						IDSupply = stuffs.supply_id,
						Supplier = stuffs.supplier,
						Tanggal = stuffs.tanggal_masuk,
						Item = stuffs.item,
						Harga = stuffs.biaya
					});
					total = total + Convert.ToInt32(stuffs.biaya);
				}
				textBox2.Text = total.ToString();
			}
			catch (Exception error) {
				MessageBox.Show(error.Message);
			}
		}

		Bitmap bitmap;
		private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			//Print the contents.
			e.Graphics.DrawImage(bitmap, 0, 0);
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			printDocument1.Print();
		}


		private void button4_Click(object sender, EventArgs e)
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

		private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
		{

			Bitmap bm = new Bitmap(this.orderBinding.Width, this.orderBinding.Height);
			orderBinding.DrawToBitmap(bm, new Rectangle(0, 0, this.orderBinding.Width, this.orderBinding.Height));
			e.Graphics.DrawImage(bm, 0, 0);
		}
	}
}
