using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Athletes_Info
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.ActiveControl = tbUsername;
            tbUsername.Focus();

            tbPassword.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\jazzybert26\Documents\Visual Studio 2013\Projects\Athletes Info\Athletes Info\ADB.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username = '" + tbUsername.Text +"' and Password = '" + tbPassword.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home ss = new Home();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are your sure you want to Exit the program?", "Confirm ", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
