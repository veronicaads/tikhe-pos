namespace Tikhe_POS
{
    partial class ReportInput
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
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.submit_button = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cabang = new System.Windows.Forms.ComboBox();
			this.subservice = new System.Windows.Forms.ComboBox();
			this.service = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(144, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Report Input";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label3.Location = new System.Drawing.Point(38, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Service Type";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label4.Location = new System.Drawing.Point(37, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "SubService Type";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label5.Location = new System.Drawing.Point(37, 281);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Store Location";
			// 
			// submit_button
			// 
			this.submit_button.Location = new System.Drawing.Point(160, 320);
			this.submit_button.Name = "submit_button";
			this.submit_button.Size = new System.Drawing.Size(109, 31);
			this.submit_button.TabIndex = 5;
			this.submit_button.Text = "Submit";
			this.submit_button.UseVisualStyleBackColor = true;
			this.submit_button.Click += new System.EventHandler(this.submitbutton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Location = new System.Drawing.Point(-2, 50);
			this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(408, 65);
			this.panel1.TabIndex = 6;
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
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(14, 20);
			this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(207, 32);
			this.label7.TabIndex = 1;
			this.label7.Text = "Tikhe - Report";
			// 
			// cabang
			// 
			this.cabang.FormattingEnabled = true;
			this.cabang.Items.AddRange(new object[] {
            "UMN",
            "Mercubuana",
            "Pertamina",
            "Atma Jaya"});
			this.cabang.Location = new System.Drawing.Point(161, 278);
			this.cabang.Name = "cabang";
			this.cabang.Size = new System.Drawing.Size(207, 21);
			this.cabang.TabIndex = 7;
			this.cabang.Text = "Location";
			this.cabang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// subservice
			// 
			this.subservice.FormattingEnabled = true;
			this.subservice.Location = new System.Drawing.Point(161, 245);
			this.subservice.Name = "subservice";
			this.subservice.Size = new System.Drawing.Size(207, 21);
			this.subservice.TabIndex = 8;
			this.subservice.Text = "Subservice";
			// 
			// service
			// 
			this.service.FormattingEnabled = true;
			this.service.Items.AddRange(new object[] {
            "Reclean",
            "Repaint",
            "Repair"});
			this.service.Location = new System.Drawing.Point(160, 213);
			this.service.Name = "service";
			this.service.Size = new System.Drawing.Size(208, 21);
			this.service.TabIndex = 9;
			this.service.Text = "Service";
			this.service.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(160, 152);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
			this.dateTimePicker1.TabIndex = 14;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(161, 182);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(207, 20);
			this.dateTimePicker2.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label8.Location = new System.Drawing.Point(37, 153);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 16);
			this.label8.TabIndex = 16;
			this.label8.Text = "Start Date";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label9.Location = new System.Drawing.Point(38, 182);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 16);
			this.label9.TabIndex = 17;
			this.label9.Text = "End Date";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(364, 10);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(29, 27);
			this.button3.TabIndex = 18;
			this.button3.Text = "X";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ReportInput
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
			this.ClientSize = new System.Drawing.Size(406, 397);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.service);
			this.Controls.Add(this.subservice);
			this.Controls.Add(this.cabang);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.submit_button);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ReportInput";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cabang;
        private System.Windows.Forms.ComboBox subservice;
        private System.Windows.Forms.ComboBox service;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}