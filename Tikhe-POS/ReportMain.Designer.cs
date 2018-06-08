namespace Tikhe_POS
{
    partial class ReportMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMain));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.graph_report = new System.Windows.Forms.GroupBox();
			this.order_graphic = new System.Windows.Forms.RadioButton();
			this.customer_graphic = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.detail = new System.Windows.Forms.GroupBox();
			this.service_detail = new System.Windows.Forms.RadioButton();
			this.customer_detail = new System.Windows.Forms.RadioButton();
			this.button18 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.graph_report.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.detail.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-2, 65);
			this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1062, 69);
			this.panel1.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(223, 31);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "version 1.0";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(14, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tikhe - Report";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// graph_report
			// 
			this.graph_report.Controls.Add(this.radioButton2);
			this.graph_report.Controls.Add(this.radioButton1);
			this.graph_report.Controls.Add(this.order_graphic);
			this.graph_report.Controls.Add(this.customer_graphic);
			this.graph_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.graph_report.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.graph_report.Location = new System.Drawing.Point(18, 157);
			this.graph_report.Name = "graph_report";
			this.graph_report.Size = new System.Drawing.Size(409, 94);
			this.graph_report.TabIndex = 2;
			this.graph_report.TabStop = false;
			this.graph_report.Text = "Graphical Reports";
			this.graph_report.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// order_graphic
			// 
			this.order_graphic.AutoSize = true;
			this.order_graphic.Location = new System.Drawing.Point(6, 57);
			this.order_graphic.Name = "order_graphic";
			this.order_graphic.Size = new System.Drawing.Size(136, 24);
			this.order_graphic.TabIndex = 5;
			this.order_graphic.TabStop = true;
			this.order_graphic.Text = "Service Order";
			this.order_graphic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.order_graphic.UseVisualStyleBackColor = true;
			this.order_graphic.CheckedChanged += new System.EventHandler(this.order_graphic_CheckedChanged);
			this.order_graphic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.order_graphic_MouseClick);
			// 
			// customer_graphic
			// 
			this.customer_graphic.AutoSize = true;
			this.customer_graphic.Location = new System.Drawing.Point(12, 26);
			this.customer_graphic.Name = "customer_graphic";
			this.customer_graphic.Size = new System.Drawing.Size(143, 24);
			this.customer_graphic.TabIndex = 5;
			this.customer_graphic.TabStop = true;
			this.customer_graphic.Text = "New Customer";
			this.customer_graphic.UseVisualStyleBackColor = true;
			this.customer_graphic.CheckedChanged += new System.EventHandler(this.customer_graphic_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(196, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Report Main Page";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(141, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 42);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// detail
			// 
			this.detail.Controls.Add(this.radioButton3);
			this.detail.Controls.Add(this.service_detail);
			this.detail.Controls.Add(this.customer_detail);
			this.detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.detail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.detail.Location = new System.Drawing.Point(18, 257);
			this.detail.Name = "detail";
			this.detail.Size = new System.Drawing.Size(409, 94);
			this.detail.TabIndex = 6;
			this.detail.TabStop = false;
			this.detail.Text = "Detail Reports";
			this.detail.Enter += new System.EventHandler(this.groupBox1_Enter_1);
			// 
			// service_detail
			// 
			this.service_detail.AutoSize = true;
			this.service_detail.Location = new System.Drawing.Point(16, 53);
			this.service_detail.Name = "service_detail";
			this.service_detail.Size = new System.Drawing.Size(154, 28);
			this.service_detail.TabIndex = 9;
			this.service_detail.TabStop = true;
			this.service_detail.Text = "Service Orders";
			this.service_detail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.service_detail.UseVisualStyleBackColor = true;
			this.service_detail.CheckedChanged += new System.EventHandler(this.service_detail_CheckedChanged);
			this.service_detail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.service_detail_MouseClick);
			// 
			// customer_detail
			// 
			this.customer_detail.AutoSize = true;
			this.customer_detail.Location = new System.Drawing.Point(16, 26);
			this.customer_detail.Name = "customer_detail";
			this.customer_detail.Size = new System.Drawing.Size(117, 28);
			this.customer_detail.TabIndex = 8;
			this.customer_detail.TabStop = true;
			this.customer_detail.Text = "Item Order";
			this.customer_detail.UseVisualStyleBackColor = true;
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Gray;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button18.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button18.Location = new System.Drawing.Point(18, 13);
			this.button18.Margin = new System.Windows.Forms.Padding(4);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(72, 37);
			this.button18.TabIndex = 8;
			this.button18.Text = "< Back";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new System.EventHandler(this.button18_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(181, 26);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(164, 24);
			this.radioButton1.TabIndex = 6;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Supplier Restock";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(181, 57);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(113, 24);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Item Order";
			this.radioButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(181, 26);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(158, 28);
			this.radioButton3.TabIndex = 10;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Inventory Order";
			this.radioButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// ReportMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
			this.ClientSize = new System.Drawing.Size(450, 370);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.detail);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.graph_report);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ReportMain";
			this.Text = "ReportMain";
			this.Load += new System.EventHandler(this.ReportMain_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReportMain_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReportMain_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReportMain_MouseUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.graph_report.ResumeLayout(false);
			this.graph_report.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.detail.ResumeLayout(false);
			this.detail.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox graph_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton order_graphic;
        private System.Windows.Forms.RadioButton customer_graphic;
        private System.Windows.Forms.GroupBox detail;
        private System.Windows.Forms.RadioButton service_detail;
        private System.Windows.Forms.RadioButton customer_detail;
        private System.Windows.Forms.Button button18;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
	}
}