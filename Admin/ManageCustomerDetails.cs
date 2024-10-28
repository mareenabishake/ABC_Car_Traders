using System;
using System.Data;
using System.Windows.Forms;

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
            dgvCustomerDetails.DataSource = user.GetAllCustomerDetails();
        }

        // Event handler for adding new customers
        // Validates all required fields before creating new customer account
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtCustomerEmail.Text) || string.IsNullOrEmpty(txtCustomerPhone.Text) || string.IsNullOrEmpty(txtCustomerAddress.Text))
            {
                MessageBox.Show("All fields except Customer ID are required to add a new customer.");
                return;
            }

            bool isAdded = user.Register(txtUsername.Text, txtPassword.Text, txtCustomerName.Text, txtCustomerEmail.Text, txtCustomerPhone.Text, txtCustomerAddress.Text);

            if (isAdded)
            {
                MessageBox.Show("Customer added successfully!");
                ClearFields();
                LoadCustomerDetails(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Failed to add customer.");
            }
        }

        // Event handler for editing existing customer details
        // Updates customer information in the database
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("Customer ID is required to edit customer details.");
                return;
            }

            bool isUpdated = user.EditCustomer(int.Parse(txtCustomerID.Text), txtCustomerName.Text, txtCustomerEmail.Text, txtCustomerPhone.Text, txtCustomerAddress.Text);

            if (isUpdated)
            {
                MessageBox.Show("Customer updated successfully!");
                ClearFields();
                LoadCustomerDetails(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Failed to update customer.");
            }
        }

        // Event handler for deleting customers
        // Removes customer account from the system
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("Customer ID is required to delete a customer.");
                return;
            }

            bool isDeleted = user.DeleteCustomer(int.Parse(txtCustomerID.Text));

            if (isDeleted)
            {
                MessageBox.Show("Customer deleted successfully!");
                ClearFields();
                LoadCustomerDetails(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Failed to delete customer.");
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomerDetails.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells["UserID"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString(); 
                txtCustomerName.Text = row.Cells["Name"].Value.ToString();
                txtCustomerEmail.Text = row.Cells["Email"].Value.ToString();
                txtCustomerPhone.Text = row.Cells["Phone"].Value.ToString();
                txtCustomerAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }
    }
}
