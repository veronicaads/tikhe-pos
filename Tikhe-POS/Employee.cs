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
            FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Employees");
            FirebaseDB firebaseDBEmployees = firebaseDB.Node(username);
            var data = @"{'username' : '" + username + "','password' : '" + password +"'}";
            firebaseDBEmployees.Put(data);
			MessageBox.Show("Data berhasil ditambahkan");
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

		private void Employee_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
