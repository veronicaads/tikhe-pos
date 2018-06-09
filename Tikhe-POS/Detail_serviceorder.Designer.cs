namespace Tikhe_POS
{
	partial class Detail_serviceorder
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
			this.label2 = new System.Windows.Forms.Label();
			this.button18 = new System.Windows.Forms.Button();
			this.orderBinding = new System.Windows.Forms.DataGridView();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printDocument2 = new System.Drawing.Printing.PrintDocument();
			this.iDOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.applicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cabangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transactionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderTransactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.orderTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.orderBinding)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderTransactionBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderTransactionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(404, -68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "Data Customer";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Gray;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button18.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button18.Location = new System.Drawing.Point(35, -71);
			this.button18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(98, 34);
			this.button18.TabIndex = 9;
			this.button18.Text = "< Back";
			this.button18.UseVisualStyleBackColor = false;
			// 
			// orderBinding
			// 
			this.orderBinding.AutoGenerateColumns = false;
			this.orderBinding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderBinding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOrderDataGridViewTextBoxColumn,
            this.applicationDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.subserviceDataGridViewTextBoxColumn,
            this.cabangDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.Total});
			this.orderBinding.DataSource = this.transactionBindingSource2;
			this.orderBinding.Location = new System.Drawing.Point(16, 140);
			this.orderBinding.Margin = new System.Windows.Forms.Padding(4);
			this.orderBinding.Name = "orderBinding";
			this.orderBinding.Size = new System.Drawing.Size(846, 400);
			this.orderBinding.TabIndex = 11;
			// 
			// Total
			// 
			this.Total.DataPropertyName = "Total";
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(-4, 66);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1096, 68);
			this.panel1.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(259, 34);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(295, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 24);
			this.label1.TabIndex = 7;
			this.label1.Text = "Service Order Report";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(13, 14);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 34);
			this.button1.TabIndex = 6;
			this.button1.Text = "< Back";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(730, 546);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(132, 22);
			this.textBox1.TabIndex = 13;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(643, 550);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Grand Total";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 550);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(158, 36);
			this.button2.TabIndex = 15;
			this.button2.Text = "Export to Excel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(196, 550);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(124, 36);
			this.button3.TabIndex = 16;
			this.button3.Text = "Export to PDF";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// iDOrderDataGridViewTextBoxColumn
			// 
			this.iDOrderDataGridViewTextBoxColumn.DataPropertyName = "IDOrder";
			this.iDOrderDataGridViewTextBoxColumn.HeaderText = "IDOrder";
			this.iDOrderDataGridViewTextBoxColumn.Name = "iDOrderDataGridViewTextBoxColumn";
			// 
			// applicationDataGridViewTextBoxColumn
			// 
			this.applicationDataGridViewTextBoxColumn.DataPropertyName = "Application";
			this.applicationDataGridViewTextBoxColumn.HeaderText = "Application";
			this.applicationDataGridViewTextBoxColumn.Name = "applicationDataGridViewTextBoxColumn";
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
			// cabangDataGridViewTextBoxColumn
			// 
			this.cabangDataGridViewTextBoxColumn.DataPropertyName = "Cabang";
			this.cabangDataGridViewTextBoxColumn.HeaderText = "Cabang";
			this.cabangDataGridViewTextBoxColumn.Name = "cabangDataGridViewTextBoxColumn";
			// 
			// customerDataGridViewTextBoxColumn
			// 
			this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
			this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
			this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
			// 
			// tanggalDataGridViewTextBoxColumn
			// 
			this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
			this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
			this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
			// 
			// transactionBindingSource2
			// 
			this.transactionBindingSource2.DataSource = typeof(Tikhe_POS.Transaction);
			// 
			// transactionBindingSource1
			// 
			this.transactionBindingSource1.DataSource = typeof(Tikhe_POS.Transaction);
			// 
			// transactionBindingSource
			// 
			this.transactionBindingSource.DataSource = typeof(Tikhe_POS.Transaction);
			// 
			// orderTransactionBindingSource1
			// 
			this.orderTransactionBindingSource1.DataSource = typeof(Tikhe_POS.OrderTransaction);
			// 
			// orderTransactionBindingSource
			// 
			this.orderTransactionBindingSource.DataSource = typeof(Tikhe_POS.OrderTransaction);
			// 
			// Detail_serviceorder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
			this.ClientSize = new System.Drawing.Size(875, 598);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.orderBinding);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Detail_serviceorder";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Customer_Load);
			((System.ComponentModel.ISupportInitialize)(this.orderBinding)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderTransactionBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderTransactionBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.DataGridView orderBinding;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.BindingSource transactionBindingSource;
		private System.Windows.Forms.BindingSource transactionBindingSource1;
		private System.Windows.Forms.BindingSource orderTransactionBindingSource;
		private System.Windows.Forms.BindingSource orderTransactionBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn applicationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn subserviceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cabangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.BindingSource transactionBindingSource2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Drawing.Printing.PrintDocument printDocument2;
	}
}