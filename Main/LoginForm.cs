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

        // Validates user credentials and initiates login process
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Both username and password are required.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User user = new User();
                if (user.Login(txtUsername.Text, txtPassword.Text))
                {
                    mainForm = new MainForm(user.UserType, user);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigates to registration form while preserving form position
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                RegistrationForm registrationForm = new RegistrationForm(this);
                registrationForm.Location = this.Location;
                registrationForm.StartPosition = FormStartPosition.Manual;
                registrationForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening registration form: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles application exit with confirmation dialog
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
