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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the username and password from the text boxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if the fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Both username and password are required.");
                return;
            }

            // Create an instance of the User class
            User user = new User();

            // Attempt to login
            bool isLoggedIn = user.Login(username, password);

            if (isLoggedIn)
            {
                // Display success message in console
                MessageBox.Show("Login successful!");

                // Check the user type and open the appropriate dashboard
                if (user.UserType == "Admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                }
                else if (user.UserType == "Customer")
                {
                    CustomerDashboard customerDashboard = new CustomerDashboard();
                    customerDashboard.Show();
                }

                // Close the login form
                this.Hide();
            }
            else
            {
                // Display error message in console
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the registration form
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
