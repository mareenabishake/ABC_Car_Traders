using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ManageCarParts : Form
    {
        private CarPart carPart; // Object to manage car parts

        public ManageCarParts()
        {
            InitializeComponent();
            carPart = new CarPart(); // Initialize CarPart object
            LoadCarPartDetails(); // Load car part details into DataGridView
        }

        // Loads car part details into DataGridView
        private void LoadCarPartDetails()
        {
            dgvCarParts.DataSource = carPart.GetAllCarPartDetails();
        }

        // Adds a new car part
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDescription.Text) ||
                string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            decimal price = decimal.Parse(txtPrice.Text);

            // Add car part to the database
            carPart.AddCarPart(txtName.Text, txtDescription.Text, price);
            ClearFields(); // Clear input fields
            LoadCarPartDetails(); // Refresh DataGridView
        }

        // Edits an existing car part
        private void btnEditPart_Click(object sender, EventArgs e)
        {
            // Validate part selection
            if (string.IsNullOrEmpty(txtPartID.Text))
            {
                MessageBox.Show("Please select a part to edit.");
                return;
            }

            int partID = int.Parse(txtPartID.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            // Edit car part details in the database
            carPart.EditCarPart(partID, txtName.Text, txtDescription.Text, price);
            ClearFields(); // Clear input fields
            LoadCarPartDetails(); // Refresh DataGridView
        }

        // Deletes a selected car part
        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            // Validate part selection
            if (string.IsNullOrEmpty(txtPartID.Text))
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            int partID = int.Parse(txtPartID.Text);
            carPart.DeleteCarPart(partID); // Delete car part from the database
            ClearFields(); // Clear input fields
            LoadCarPartDetails(); // Refresh DataGridView
        }

        // Handles cell click event to load selected car part details into input fields
        private void dgvCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCarParts.Rows[e.RowIndex];
                txtPartID.Text = row.Cells["PartID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        // Clears input fields
        private void ClearFields()
        {
            txtPartID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
        }

        // Menu strip events to navigate between different forms
        private void txtMenuStripManageCarDetails_Click(object sender, EventArgs e)
        {
            ManageCarDetails carDetailsForm = new ManageCarDetails();
            carDetailsForm.Show();
            this.Hide();
        }

        private void txtMenuStripManageCarParts_Click(object sender, EventArgs e)
        {
            ManageCarParts carPartsForm = new ManageCarParts();
            carPartsForm.Show();
            this.Hide();
        }

        private void txtMenuStripManageCustomerDetails_Click(object sender, EventArgs e)
        {
            ManageCustomerDetails customerDetailsForm = new ManageCustomerDetails();
            customerDetailsForm.Show();
            this.Hide();
        }

        private void txtMenuStripManageOrders_Click(object sender, EventArgs e)
        {
            ManageOrders ordersForm = new ManageOrders();
            ordersForm.Show();
            this.Hide();
        }

        private void txtMenuStripGenerateReports_Click(object sender, EventArgs e)
        {
            GenerateReports reportsForm = new GenerateReports();
            reportsForm.Show();
            this.Hide();
        }
    }
}
