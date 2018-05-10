namespace Tikhe_POS
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.employee_btn = new Tikhe_POS.CircularButton();
            this.service_btn = new Tikhe_POS.CircularButton();
            this.supplier_btn = new Tikhe_POS.CircularButton();
            this.customer_btn = new Tikhe_POS.CircularButton();
            this.restock_btn = new Tikhe_POS.CircularButton();
            this.sales_btn = new Tikhe_POS.CircularButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 55);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(407, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tikhe - Point Of Sales and Repots";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome, Nama Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(63, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(211, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(361, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(58, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Restock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(226, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(373, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Report";
            // 
            // employee_btn
            // 
            this.employee_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(195)))), ((int)(((byte)(197)))));
            this.employee_btn.FlatAppearance.BorderSize = 0;
            this.employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_btn.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_btn.ForeColor = System.Drawing.Color.Transparent;
            this.employee_btn.Image = ((System.Drawing.Image)(resources.GetObject("employee_btn.Image")));
            this.employee_btn.Location = new System.Drawing.Point(355, 141);
            this.employee_btn.Name = "employee_btn";
            this.employee_btn.Size = new System.Drawing.Size(85, 86);
            this.employee_btn.TabIndex = 4;
            this.employee_btn.UseVisualStyleBackColor = false;
            // 
            // service_btn
            // 
            this.service_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.service_btn.FlatAppearance.BorderSize = 0;
            this.service_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.service_btn.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_btn.ForeColor = System.Drawing.Color.Black;
            this.service_btn.Image = ((System.Drawing.Image)(resources.GetObject("service_btn.Image")));
            this.service_btn.Location = new System.Drawing.Point(355, 278);
            this.service_btn.Name = "service_btn";
            this.service_btn.Size = new System.Drawing.Size(85, 86);
            this.service_btn.TabIndex = 4;
            this.service_btn.UseVisualStyleBackColor = false;
            this.service_btn.Click += new System.EventHandler(this.service_btn_Click);
            // 
            // supplier_btn
            // 
            this.supplier_btn.BackColor = System.Drawing.Color.Purple;
            this.supplier_btn.FlatAppearance.BorderSize = 0;
            this.supplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier_btn.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_btn.ForeColor = System.Drawing.Color.Transparent;
            this.supplier_btn.Image = ((System.Drawing.Image)(resources.GetObject("supplier_btn.Image")));
            this.supplier_btn.Location = new System.Drawing.Point(205, 141);
            this.supplier_btn.Name = "supplier_btn";
            this.supplier_btn.Size = new System.Drawing.Size(85, 86);
            this.supplier_btn.TabIndex = 3;
            this.supplier_btn.UseVisualStyleBackColor = false;
            // 
            // customer_btn
            // 
            this.customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(122)))), ((int)(((byte)(209)))));
            this.customer_btn.FlatAppearance.BorderSize = 0;
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_btn.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.ForeColor = System.Drawing.Color.Transparent;
            this.customer_btn.Image = ((System.Drawing.Image)(resources.GetObject("customer_btn.Image")));
            this.customer_btn.Location = new System.Drawing.Point(55, 141);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(85, 86);
            this.customer_btn.TabIndex = 2;
            this.customer_btn.UseVisualStyleBackColor = false;
            // 
            // restock_btn
            // 
            this.restock_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(172)))), ((int)(((byte)(141)))));
            this.restock_btn.FlatAppearance.BorderSize = 0;
            this.restock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restock_btn.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restock_btn.ForeColor = System.Drawing.Color.Black;
            this.restock_btn.Image = ((System.Drawing.Image)(resources.GetObject("restock_btn.Image")));
            this.restock_btn.Location = new System.Drawing.Point(55, 278);
            this.restock_btn.Name = "restock_btn";
            this.restock_btn.Size = new System.Drawing.Size(84, 86);
            this.restock_btn.TabIndex = 1;
            this.restock_btn.UseVisualStyleBackColor = false;
            this.restock_btn.Click += new System.EventHandler(this.restock_btn_Click);
            // 
            // sales_btn
            // 
            this.sales_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sales_btn.FlatAppearance.BorderSize = 0;
            this.sales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales_btn.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_btn.ForeColor = System.Drawing.Color.Black;
            this.sales_btn.Image = ((System.Drawing.Image)(resources.GetObject("sales_btn.Image")));
            this.sales_btn.Location = new System.Drawing.Point(205, 278);
            this.sales_btn.Name = "sales_btn";
            this.sales_btn.Size = new System.Drawing.Size(85, 86);
            this.sales_btn.TabIndex = 1;
            this.sales_btn.UseVisualStyleBackColor = false;
            this.sales_btn.Click += new System.EventHandler(this.sales_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(492, 422);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employee_btn);
            this.Controls.Add(this.service_btn);
            this.Controls.Add(this.supplier_btn);
            this.Controls.Add(this.customer_btn);
            this.Controls.Add(this.restock_btn);
            this.Controls.Add(this.sales_btn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " T-POS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private CircularButton sales_btn;
        private CircularButton restock_btn;
        private CircularButton customer_btn;
        private CircularButton supplier_btn;
        private CircularButton service_btn;
        private CircularButton employee_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

