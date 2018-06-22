namespace Tikhe_POS
{
    partial class Employee
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pw_s = new System.Windows.Forms.Label();
            this.strength = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.hp_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pw_s);
            this.groupBox1.Controls.Add(this.strength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pass_txt);
            this.groupBox1.Controls.Add(this.user_txt);
            this.groupBox1.Controls.Add(this.nama_txt);
            this.groupBox1.Controls.Add(this.hp_txt);
            this.groupBox1.Controls.Add(this.email_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 360);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Employee";
            // 
            // pw_s
            // 
            this.pw_s.AutoSize = true;
            this.pw_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_s.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pw_s.Location = new System.Drawing.Point(192, 110);
            this.pw_s.Name = "pw_s";
            this.pw_s.Size = new System.Drawing.Size(0, 13);
            this.pw_s.TabIndex = 8;
            this.pw_s.Click += new System.EventHandler(this.pw_s_Click);
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strength.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.strength.Location = new System.Drawing.Point(212, 114);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(0, 13);
            this.strength.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(137, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Password Is";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(133, 83);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(198, 24);
            this.pass_txt.TabIndex = 5;
            this.pass_txt.TextChanged += new System.EventHandler(this.pass_txt_TextChanged);
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(133, 39);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(198, 24);
            this.user_txt.TabIndex = 5;
            // 
            // nama_txt
            // 
            this.nama_txt.Location = new System.Drawing.Point(133, 168);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(198, 24);
            this.nama_txt.TabIndex = 5;
            // 
            // hp_txt
            // 
            this.hp_txt.Location = new System.Drawing.Point(133, 258);
            this.hp_txt.Name = "hp_txt";
            this.hp_txt.Size = new System.Drawing.Size(198, 24);
            this.hp_txt.TabIndex = 5;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(133, 212);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(198, 24);
            this.email_txt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. HP ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(195, 303);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(44, 303);
            this.button22.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(109, 40);
            this.button22.TabIndex = 3;
            this.button22.Text = "Add";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(328, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data Employee";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gray;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(8, 6);
            this.button18.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(73, 28);
            this.button18.TabIndex = 18;
            this.button18.Text = "< Back";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 55);
            this.panel1.TabIndex = 17;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 360);
            this.dataGridView1.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(198, 24);
            this.textBox1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Retype - Pass";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(771, 585);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.TextBox hp_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label pw_s;
		private System.Windows.Forms.Label strength;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}