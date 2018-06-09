namespace Tikhe_POS
{
	partial class Restock_Graph
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.supplier = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.supplier)).BeginInit();
			this.SuspendLayout();
			// 
			// supplier
			// 
			chartArea2.Name = "ChartArea1";
			this.supplier.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.supplier.Legends.Add(legend2);
			this.supplier.Location = new System.Drawing.Point(12, 12);
			this.supplier.Name = "supplier";
			this.supplier.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
			series7.ChartArea = "ChartArea1";
			series7.Legend = "Legend1";
			series7.Name = "Cat Sepatu";
			series8.ChartArea = "ChartArea1";
			series8.Legend = "Legend1";
			series8.Name = "Sikat Sepatu";
			series9.ChartArea = "ChartArea1";
			series9.Legend = "Legend1";
			series9.Name = "Sabun Sepatu";
			series10.ChartArea = "ChartArea1";
			series10.Legend = "Legend1";
			series10.Name = "Sabun Helm";
			series11.ChartArea = "ChartArea1";
			series11.Legend = "Legend1";
			series11.Name = "Pewangi";
			series12.ChartArea = "ChartArea1";
			series12.Legend = "Legend1";
			series12.Name = "Sol";
			this.supplier.Series.Add(series7);
			this.supplier.Series.Add(series8);
			this.supplier.Series.Add(series9);
			this.supplier.Series.Add(series10);
			this.supplier.Series.Add(series11);
			this.supplier.Series.Add(series12);
			this.supplier.Size = new System.Drawing.Size(526, 300);
			this.supplier.TabIndex = 0;
			this.supplier.Text = "chart1";
			// 
			// Restock_Graph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 328);
			this.Controls.Add(this.supplier);
			this.Name = "Restock_Graph";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Chart_Load);
			((System.ComponentModel.ISupportInitialize)(this.supplier)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart supplier;
	}
}