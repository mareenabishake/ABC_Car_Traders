using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
               string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
               string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // Create a new User object
            User user = new User();
            bool isRegistered = user.Register(txtUsername.Text, txtPassword.Text, txtName.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text);

            // Display registration success or failure message
            if (isRegistered)
            {
                MessageBox.Show("Registration successful!");
                this.Close(); // Close the registration form
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Close the registration form and go back to the login form
            this.Close();
        }
    }
}