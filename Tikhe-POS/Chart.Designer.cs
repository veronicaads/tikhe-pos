﻿namespace Tikhe_POS
{
	partial class Chart
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.pets = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.pets)).BeginInit();
			this.SuspendLayout();
			// 
			// pets
			// 
			chartArea1.Name = "ChartArea1";
			this.pets.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.pets.Legends.Add(legend1);
			this.pets.Location = new System.Drawing.Point(12, 12);
			this.pets.Name = "pets";
			this.pets.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Mercubuana";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "UMN";
			this.pets.Series.Add(series1);
			this.pets.Series.Add(series2);
			this.pets.Size = new System.Drawing.Size(300, 300);
			this.pets.TabIndex = 0;
			this.pets.Text = "chart1";
			title1.Name = "Branch Sales";
			this.pets.Titles.Add(title1);
			// 
			// Chart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 450);
			this.Controls.Add(this.pets);
			this.Name = "Chart";
			this.Text = "Chart";
			this.Load += new System.EventHandler(this.Chart_Load);
			((System.ComponentModel.ISupportInitialize)(this.pets)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart pets;
	}
}