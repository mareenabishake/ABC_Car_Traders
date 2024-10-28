using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_Car_Traders.Main;

namespace ABC_Car_Traders
{
    public partial class RegistrationForm : Form
    {
        private LoginForm _loginForm;

        public RegistrationForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            _loginForm = loginForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any required fields are empty
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                   string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                   string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a new User object
                User user = new User();
                bool isRegistered = user.Register(txtUsername.Text, txtPassword.Text, txtName.Text, 
                                               txtEmail.Text, txtPhone.Text, txtAddress.Text);

                // Display registration success or failure message
                if (isRegistered)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _loginForm.Location = this.Location;
                    _loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}", 
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optional: Log the exception here
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _loginForm.Location = this.Location;
                _loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while returning to login: {ex.Message}", 
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optional: Log the exception here
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                base.OnFormClosing(e);
                if (_loginForm != null && !_loginForm.Visible)
                {
                    _loginForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while closing the form: {ex.Message}", 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
