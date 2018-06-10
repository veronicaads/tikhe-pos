namespace Tikhe_POS
{
	partial class Invoices
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cabang_text = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nama = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tanggal_text = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.iDOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Invoice";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "ShoeBox ";
			// 
			// cabang_text
			// 
			this.cabang_text.AutoSize = true;
			this.cabang_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cabang_text.Location = new System.Drawing.Point(88, 64);
			this.cabang_text.Name = "cabang_text";
			this.cabang_text.Size = new System.Drawing.Size(56, 16);
			this.cabang_text.TabIndex = 2;
			this.cabang_text.Text = "Cabang";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nama Customer :";
			// 
			// nama
			// 
			this.nama.AutoSize = true;
			this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nama.Location = new System.Drawing.Point(138, 88);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(45, 16);
			this.nama.TabIndex = 4;
			this.nama.Text = "Nama";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Tanggal Order :";
			// 
			// tanggal_text
			// 
			this.tanggal_text.AutoSize = true;
			this.tanggal_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tanggal_text.Location = new System.Drawing.Point(133, 111);
			this.tanggal_text.Name = "tanggal_text";
			this.tanggal_text.Size = new System.Drawing.Size(59, 16);
			this.tanggal_text.TabIndex = 6;
			this.tanggal_text.Text = "Tanggal";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOrderDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.subserviceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.invoiceBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(28, 161);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(441, 210);
			this.dataGridView1.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(272, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(199, 143);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(369, 377);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(300, 380);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Grand Total";
			// 
			// iDOrderDataGridViewTextBoxColumn
			// 
			this.iDOrderDataGridViewTextBoxColumn.DataPropertyName = "IDOrder";
			this.iDOrderDataGridViewTextBoxColumn.HeaderText = "IDOrder";
			this.iDOrderDataGridViewTextBoxColumn.Name = "iDOrderDataGridViewTextBoxColumn";
			// 
			// serviceDataGridViewTextBoxColumn
			// 
			this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
			this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
			this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
			// 
			// subserviceDataGridViewTextBoxColumn
			// 
			this.subserviceDataGridViewTextBoxColumn.DataPropertyName = "Subservice";
			this.subserviceDataGridViewTextBoxColumn.HeaderText = "Subservice";
			this.subserviceDataGridViewTextBoxColumn.Name = "subserviceDataGridViewTextBoxColumn";
			// 
			// totalDataGridViewTextBoxColumn
			// 
			this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
			this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
			this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataSource = typeof(Tikhe_POS.Invoice);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 380);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Print";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// Invoices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(483, 415);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tanggal_text);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cabang_text);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Invoices";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Invoice_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label cabang_text;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label nama;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label tanggal_text;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn subserviceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button1;
		private System.Drawing.Printing.PrintDocument printDocument1;
	}
}