namespace Tikhe_POS
{
    partial class Supplier
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
			this.alamat_txt = new System.Windows.Forms.TextBox();
			this.nama_txt = new System.Windows.Forms.TextBox();
			this.email_txt = new System.Windows.Forms.TextBox();
			this.hp_txt = new System.Windows.Forms.TextBox();
			this.vendor_txt = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.clear_btn = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.delete_btn = new System.Windows.Forms.Button();
			this.update_btn = new System.Windows.Forms.Button();
			this.add_btn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Produk = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.merekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.merek_txt = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button18 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// alamat_txt
			// 
			this.alamat_txt.Location = new System.Drawing.Point(129, 54);
			this.alamat_txt.Multiline = true;
			this.alamat_txt.Name = "alamat_txt";
			this.alamat_txt.Size = new System.Drawing.Size(198, 94);
			this.alamat_txt.TabIndex = 5;
			// 
			// nama_txt
			// 
			this.nama_txt.Location = new System.Drawing.Point(129, 24);
			this.nama_txt.Name = "nama_txt";
			this.nama_txt.Size = new System.Drawing.Size(198, 24);
			this.nama_txt.TabIndex = 5;
			// 
			// email_txt
			// 
			this.email_txt.Location = new System.Drawing.Point(129, 166);
			this.email_txt.Name = "email_txt";
			this.email_txt.Size = new System.Drawing.Size(198, 24);
			this.email_txt.TabIndex = 5;
			// 
			// hp_txt
			// 
			this.hp_txt.Location = new System.Drawing.Point(129, 202);
			this.hp_txt.Name = "hp_txt";
			this.hp_txt.Size = new System.Drawing.Size(198, 24);
			this.hp_txt.TabIndex = 5;
			// 
			// vendor_txt
			// 
			this.vendor_txt.Location = new System.Drawing.Point(128, 282);
			this.vendor_txt.Name = "vendor_txt";
			this.vendor_txt.Size = new System.Drawing.Size(198, 24);
			this.vendor_txt.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 285);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 18);
			this.label8.TabIndex = 4;
			this.label8.Text = "Produk";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 18);
			this.label7.TabIndex = 4;
			this.label7.Text = "Email";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "No. HP ";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "Alamat";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nama";
			// 
			// clear_btn
			// 
			this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clear_btn.ForeColor = System.Drawing.Color.White;
			this.clear_btn.Location = new System.Drawing.Point(266, 336);
			this.clear_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.clear_btn.Name = "clear_btn";
			this.clear_btn.Size = new System.Drawing.Size(66, 40);
			this.clear_btn.TabIndex = 3;
			this.clear_btn.Text = "Clear";
			this.clear_btn.UseVisualStyleBackColor = false;
			this.clear_btn.Click += new System.EventHandler(this.button3_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Purple;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(649, 117);
			this.button7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(91, 32);
			this.button7.TabIndex = 16;
			this.button7.Text = "Search";
			this.button7.UseVisualStyleBackColor = false;
			// 
			// delete_btn
			// 
			this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete_btn.ForeColor = System.Drawing.Color.White;
			this.delete_btn.Location = new System.Drawing.Point(186, 336);
			this.delete_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(66, 40);
			this.delete_btn.TabIndex = 3;
			this.delete_btn.Text = "Delete";
			this.delete_btn.UseVisualStyleBackColor = false;
			this.delete_btn.Click += new System.EventHandler(this.button2_Click);
			// 
			// update_btn
			// 
			this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update_btn.ForeColor = System.Drawing.Color.White;
			this.update_btn.Location = new System.Drawing.Point(103, 336);
			this.update_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.update_btn.Name = "update_btn";
			this.update_btn.Size = new System.Drawing.Size(67, 40);
			this.update_btn.TabIndex = 3;
			this.update_btn.Text = "Update";
			this.update_btn.UseVisualStyleBackColor = false;
			this.update_btn.Click += new System.EventHandler(this.button1_Click);
			// 
			// add_btn
			// 
			this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add_btn.ForeColor = System.Drawing.Color.White;
			this.add_btn.Location = new System.Drawing.Point(15, 336);
			this.add_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.add_btn.Name = "add_btn";
			this.add_btn.Size = new System.Drawing.Size(72, 40);
			this.add_btn.TabIndex = 3;
			this.add_btn.Text = "Add";
			this.add_btn.UseVisualStyleBackColor = false;
			this.add_btn.Click += new System.EventHandler(this.button22_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.HP,
            this.Produk,
            this.emailDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.merekDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.vendorBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(371, 175);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(417, 397);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 30;
			// 
			// Nama
			// 
			this.Nama.DataPropertyName = "Nama";
			this.Nama.HeaderText = "Nama";
			this.Nama.Name = "Nama";
			this.Nama.ReadOnly = true;
			this.Nama.Width = 140;
			// 
			// HP
			// 
			this.HP.DataPropertyName = "HP";
			this.HP.HeaderText = "HP";
			this.HP.Name = "HP";
			// 
			// Produk
			// 
			this.Produk.DataPropertyName = "Produk";
			this.Produk.HeaderText = "Produk";
			this.Produk.Name = "Produk";
			this.Produk.Width = 105;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// alamatDataGridViewTextBoxColumn
			// 
			this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
			this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
			this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
			// 
			// merekDataGridViewTextBoxColumn
			// 
			this.merekDataGridViewTextBoxColumn.DataPropertyName = "Merek";
			this.merekDataGridViewTextBoxColumn.HeaderText = "Merek";
			this.merekDataGridViewTextBoxColumn.Name = "merekDataGridViewTextBoxColumn";
			// 
			// vendorBindingSource
			// 
			this.vendorBindingSource.DataSource = typeof(Tikhe_POS.Vendor);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.alamat_txt);
			this.groupBox1.Controls.Add(this.nama_txt);
			this.groupBox1.Controls.Add(this.email_txt);
			this.groupBox1.Controls.Add(this.merek_txt);
			this.groupBox1.Controls.Add(this.hp_txt);
			this.groupBox1.Controls.Add(this.vendor_txt);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.clear_btn);
			this.groupBox1.Controls.Add(this.delete_btn);
			this.groupBox1.Controls.Add(this.update_btn);
			this.groupBox1.Controls.Add(this.add_btn);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(15, 169);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(350, 403);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Info Supplier";
			// 
			// merek_txt
			// 
			this.merek_txt.Location = new System.Drawing.Point(128, 244);
			this.merek_txt.Name = "merek_txt";
			this.merek_txt.Size = new System.Drawing.Size(198, 24);
			this.merek_txt.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 247);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 18);
			this.label9.TabIndex = 4;
			this.label9.Text = "Merek";
			this.label9.Click += new System.EventHandler(this.label5_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(286, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 24);
			this.label2.TabIndex = 12;
			this.label2.Text = "Data Supplier";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Gray;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button18.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button18.Location = new System.Drawing.Point(9, 6);
			this.button18.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(73, 28);
			this.button18.TabIndex = 11;
			this.button18.Text = "< Back";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new System.EventHandler(this.button18_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-2, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(808, 55);
			this.panel1.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(257, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "version 1.0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(251, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tikhe - Point Of Sale\r\n";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 117);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(618, 32);
			this.textBox1.TabIndex = 15;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// personBindingSource
			// 
			this.personBindingSource.DataSource = typeof(Tikhe_POS.Person);
			// 
			// Supplier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
			this.ClientSize = new System.Drawing.Size(800, 584);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Supplier";
			this.Text = "Supplier";
			this.Load += new System.EventHandler(this.Supplier_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Supplier_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Supplier_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Supplier_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alamat_txt;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox hp_txt;
        private System.Windows.Forms.TextBox vendor_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox merek_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produk;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merekDataGridViewTextBoxColumn;
    }
}