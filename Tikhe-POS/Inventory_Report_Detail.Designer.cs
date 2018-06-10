namespace Tikhe_POS
{
	partial class Inventory_Report_Detail
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.orderBinding = new System.Windows.Forms.DataGridView();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.iDSupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderBinding)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoriBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(0, 61);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1096, 68);
			this.panel1.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(199, 33);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "version 1.0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(11, 25);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 27);
			this.label4.TabIndex = 1;
			this.label4.Text = "Tikhe - Report";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(-130, -38);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 34);
			this.button1.TabIndex = 13;
			this.button1.Text = "< Back";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// orderBinding
			// 
			this.orderBinding.AutoGenerateColumns = false;
			this.orderBinding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderBinding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSupplyDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
			this.orderBinding.DataSource = this.inventoriBindingSource;
			this.orderBinding.Location = new System.Drawing.Point(13, 148);
			this.orderBinding.Margin = new System.Windows.Forms.Padding(4);
			this.orderBinding.Name = "orderBinding";
			this.orderBinding.Size = new System.Drawing.Size(540, 272);
			this.orderBinding.TabIndex = 14;
			this.orderBinding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderBinding_CellContentClick);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(525, 16);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(29, 27);
			this.button3.TabIndex = 22;
			this.button3.Text = "X";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(139, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 24);
			this.label1.TabIndex = 23;
			this.label1.Text = "Inventory Restock Detail Report";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(202, 432);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(124, 36);
			this.button2.TabIndex = 27;
			this.button2.Text = "Export to PDF";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(22, 432);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(158, 36);
			this.button4.TabIndex = 26;
			this.button4.Text = "Export to Excel";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(649, 432);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 25;
			this.label5.Text = "Grand Total";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(736, 428);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(132, 20);
			this.textBox1.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(489, 430);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "Grand Total";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(421, 446);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(132, 20);
			this.textBox2.TabIndex = 28;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
			// 
			// iDSupplyDataGridViewTextBoxColumn
			// 
			this.iDSupplyDataGridViewTextBoxColumn.DataPropertyName = "IDSupply";
			this.iDSupplyDataGridViewTextBoxColumn.HeaderText = "ID Supply";
			this.iDSupplyDataGridViewTextBoxColumn.Name = "iDSupplyDataGridViewTextBoxColumn";
			// 
			// supplierDataGridViewTextBoxColumn
			// 
			this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
			this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
			this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
			// 
			// tanggalDataGridViewTextBoxColumn
			// 
			this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
			this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal Pesan";
			this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
			// 
			// itemDataGridViewTextBoxColumn
			// 
			this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
			this.itemDataGridViewTextBoxColumn.HeaderText = "Jenis Item";
			this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
			// 
			// hargaDataGridViewTextBoxColumn
			// 
			this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
			this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
			this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
			// 
			// inventoriBindingSource
			// 
			this.inventoriBindingSource.DataSource = typeof(Tikhe_POS.Inventori);
			// 
			// Inventory_Report_Detail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
			this.ClientSize = new System.Drawing.Size(571, 480);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.orderBinding);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Inventory_Report_Detail";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Inventory_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderBinding)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoriBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView orderBinding;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDSupplyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource inventoriBindingSource;
		private System.Drawing.Printing.PrintDocument printDocument1;
	}
}