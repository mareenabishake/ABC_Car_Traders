using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_Car_Traders.Main; // Add this if MainForm is in a different namespace

namespace ABC_Car_Traders
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Both username and password are required.");
                return;
            }

            User user = new User();

            if (user.Login(username, password))
            {
                mainForm = new MainForm(user.UserType, user);
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Location = this.Location;
            registrationForm.StartPosition = FormStartPosition.Manual;
            registrationForm.FormClosing += delegate { this.Show(); };
            registrationForm.Show();
            this.Hide();
        }
    }
}
