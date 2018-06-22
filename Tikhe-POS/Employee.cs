using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseNet.Database;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Tikhe_POS
{
    public partial class Employee : Form
    {
        
        public Employee()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nama_txt.Text = "";
            pass_txt.Text = "";
            textBox1.Text = "";
            email_txt.Text = "";
            hp_txt.Text = "";
            user_txt.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            String username = user_txt.Text;
            String password = pass_txt.Text;
            String nama = nama_txt.Text;
            String email = email_txt.Text;
            String hp = hp_txt.Text;
            if(textBox1.Text == password)
            {
                FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Employees");
                FirebaseDB firebaseDBEmployees = firebaseDB.Node(username);
                var data = @"{'username' : '" + username + "','password' : '" + password + "','nama' : '" + nama + "','email' : '" + email + "','hp' : '" + hp + "'}";
                firebaseDBEmployees.Put(data);
                MessageBox.Show("Data berhasil ditambahkan");

                employeedataBindingSource.Add(new Employee_data() { Username = username, Password = password, Email = email, HP = hp, Nama = nama });
            }
            else
            {
                MessageBox.Show("Password Doesn't Match !");
            }
            
        }
        int TogMove;
        int X, Y;
        private void Employee_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void Employee_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

		private void pw_s_Click(object sender, EventArgs e)
		{

		}

		public enum PasswordScore
		{
			Blank = 0,
			VeryWeak = 1,
			Weak = 2,
			Medium = 3,
			Strong = 4,
			VeryStrong = 5
		}

		public static PasswordScore CheckStrength(string password)
		{
			int score = 1;
			if (password.Length < 1)
				return PasswordScore.Blank;
			if (password.Length < 4)
				return PasswordScore.VeryWeak;
			if (password.Length >= 6)
				score++;
			if (password.Length >= 8)
				score++;
			if (Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success)
				score++;
			if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
			  Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
				score++;
			if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
				score++;
			return (PasswordScore)score;
		}

		private void pass_txt_TextChanged(object sender, EventArgs e)
		{
			String pws = CheckStrength(pass_txt.Text).ToString();
			pw_s.Text = pws;
		}
        int selectedRow;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            user_txt.Text = row.Cells[1].Value.ToString();
            nama_txt.Text = row.Cells[0].Value.ToString();
            email_txt.Text = row.Cells[4].Value.ToString();
            hp_txt.Text = row.Cells[2].Value.ToString();
        }
        FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Supplier");
        private void update_btn_Click(object sender, EventArgs e)
        {
            if (nama_txt.Text == "" || email_txt.Text == "" || hp_txt.Text == "" || user_txt.Text == "" || pass_txt.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Semua Wajib Diisi !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainMenu form = new MainMenu();
                form.Show(); Hide();
            }
            else
            {
                DataGridViewRow newRow = dataGridView1.Rows[selectedRow];
                newRow.Cells[0].Value = nama_txt.Text;
                newRow.Cells[2].Value = hp_txt.Text;
                newRow.Cells[1].Value = user_txt.Text;
                newRow.Cells[4].Value = email_txt.Text;
                newRow.Cells[3].Value = pass_txt.Text;

                FirebaseDB firebaseSupplier = firebaseDB.Node(newRow.Cells[0].Value.ToString());
                FirebaseResponse coba = firebaseSupplier.Get();
                dynamic stuff = JObject.Parse(coba.JSONContent);

                var data = @"{'username' : '" + user_txt.Text + "','password' : '" + pass_txt.Text + "','nama' : '" + nama_txt.Text + "','email' : '" + email_txt.Text + "','hp' : '" + hp_txt.Text + "'}";

                firebaseSupplier.Patch(data);

                nama_txt.Text = "";
                pass_txt.Text = "";
                hp_txt.Text = "";
                email_txt.Text = "";
                user_txt.Text = "";
                textBox1.Text = "";

            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            nama_txt.Text = "";
            user_txt.Text = "";
            hp_txt.Text = "";
            email_txt.Text = "";
            pass_txt.Text = "";
            textBox1.Text = "";

            DataGridViewRow newRow = dataGridView1.Rows[selectedRow];
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void Employee_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
