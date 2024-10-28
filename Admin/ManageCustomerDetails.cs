using System;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;

namespace ABC_Car_Traders
{
    public partial class ManageCustomerDetails : Form
    {
        // Instance of User class to handle customer-related operations
        private User user;

        public ManageCustomerDetails()
        {
            InitializeComponent();
            user = new User();
            LoadCustomerDetails(); // Load all customer details on form load
        }

        // Loads all customer details into the DataGridView
        private void LoadCustomerDetails()
        {
            try
            {
                dgvCustomerDetails.DataSource = user.GetAllCustomerDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer details: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for adding new customers
        // Validates all required fields before creating new customer account
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || 
                    string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtCustomerEmail.Text) || 
                    string.IsNullOrEmpty(txtCustomerPhone.Text) || string.IsNullOrEmpty(txtCustomerAddress.Text))
                {
                    MessageBox.Show("All fields except Customer ID are required to add a new customer.", 
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate email format
                if (!IsValidEmail(txtCustomerEmail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.", 
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isAdded = user.Register(txtUsername.Text, txtPassword.Text, txtCustomerName.Text, 
                                           txtCustomerEmail.Text, txtCustomerPhone.Text, txtCustomerAddress.Text);

                if (isAdded)
                {
                    MessageBox.Show("Customer added successfully!", "Success", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadCustomerDetails();
                }
                else
                {
                    MessageBox.Show("Failed to add customer. The username might already exist.", 
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for editing existing customer details
        // Updates customer information in the database
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerID.Text))
                {
                    MessageBox.Show("Please select a customer to edit.", 
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtCustomerID.Text, out int customerID))
                {
                    MessageBox.Show("Invalid Customer ID.", 
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(txtCustomerEmail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.", 
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isUpdated = user.EditCustomer(customerID, txtCustomerName.Text, 
                                                 txtCustomerEmail.Text, txtCustomerPhone.Text, 
                                                 txtCustomerAddress.Text);

                if (isUpdated)
                {
                    MessageBox.Show("Customer updated successfully!", "Success", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadCustomerDetails();
                }
                else
                {
                    MessageBox.Show("Failed to update customer. The customer might not exist.", 
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for deleting customers
        // Removes customer account from the system
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerID.Text))
                {
                    MessageBox.Show("Please select a customer to delete.", 
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtCustomerID.Text, out int customerID))
                {
                    MessageBox.Show("Invalid Customer ID.", 
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", 
                                                    "Confirm Delete", 
                                                    MessageBoxButtons.YesNo, 
                                                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool isDeleted = user.DeleteCustomer(customerID);

                    if (isDeleted)
                    {
                        MessageBox.Show("Customer deleted successfully!", "Success", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadCustomerDetails();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete customer. The customer might not exist.", 
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clears all input fields after operations
        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
            txtCustomerPhone.Clear();
            txtCustomerAddress.Clear();
        }

        // Event handler for DataGridView cell click
        // Populates form fields with selected customer details
        private void dgvCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvCustomerDetails.Rows[e.RowIndex];

                    txtCustomerID.Text = row.Cells["UserID"].Value?.ToString();
                    txtUsername.Text = row.Cells["Username"].Value?.ToString();
                    txtPassword.Text = row.Cells["Password"].Value?.ToString();
                    txtCustomerName.Text = row.Cells["Name"].Value?.ToString();
                    txtCustomerEmail.Text = row.Cells["Email"].Value?.ToString();
                    txtCustomerPhone.Text = row.Cells["Phone"].Value?.ToString();
                    txtCustomerAddress.Text = row.Cells["Address"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting customer: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
