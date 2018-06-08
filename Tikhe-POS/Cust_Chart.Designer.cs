namespace Tikhe_POS
{
	partial class Cust_Chart
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
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.chartcust = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartcust)).BeginInit();
			this.SuspendLayout();
			// 
			// chartcust
			// 
			chartArea2.Name = "ChartArea1";
			this.chartcust.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chartcust.Legends.Add(legend2);
			this.chartcust.Location = new System.Drawing.Point(12, 12);
			this.chartcust.Name = "chartcust";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Male";
			series4.ChartArea = "ChartArea1";
			series4.Legend = "Legend1";
			series4.Name = "Female";
			this.chartcust.Series.Add(series3);
			this.chartcust.Series.Add(series4);
			this.chartcust.Size = new System.Drawing.Size(277, 342);
			this.chartcust.TabIndex = 0;
			this.chartcust.Text = "chart1";
			title2.Name = "Customer Info Chart";
			this.chartcust.Titles.Add(title2);
			this.chartcust.Click += new System.EventHandler(this.Chart_Load);
			// 
			// Cust_Chart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 364);
			this.Controls.Add(this.chartcust);
			this.Name = "Cust_Chart";
			this.Text = "Cust_Chart";
			this.Load += new System.EventHandler(this.Chart_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartcust)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartcust;
	}
}