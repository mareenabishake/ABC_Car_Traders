using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ManageCarDetails : Form
    {
        private Car car; // Car object to manage car details

        public ManageCarDetails()
        {
            InitializeComponent();
            car = new Car(); // Initialize Car object
            LoadCarDetails(); // Load car details into DataGridView
        }

        // Loads car details into the DataGridView
        private void LoadCarDetails()
        {
            dgvCarDetails.DataSource = car.GetAllCarDetails();
        }

        // Adds a new car
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(txtMake.Text) || string.IsNullOrEmpty(txtModel.Text) ||
                string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            // Add car to the database
            car.AddCar(txtMake.Text, txtModel.Text, year, price);
            ClearFields(); // Clear input fields
            LoadCarDetails(); // Refresh DataGridView
        }

        // Edits an existing car
        private void btnEditCar_Click(object sender, EventArgs e)
        {
            // Validate car selection
            if (string.IsNullOrEmpty(txtCarID.Text))
            {
                MessageBox.Show("Please select a car to edit.");
                return;
            }

            int carID = int.Parse(txtCarID.Text);
            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            // Edit car details in the database
            car.EditCar(carID, txtMake.Text, txtModel.Text, year, price);
            ClearFields(); // Clear input fields
            LoadCarDetails(); // Refresh DataGridView
        }

        // Deletes a selected car
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            // Validate car selection
            if (string.IsNullOrEmpty(txtCarID.Text))
            {
                MessageBox.Show("Please select a car to delete.");
                return;
            }

            int carID = int.Parse(txtCarID.Text);
            car.DeleteCar(carID); // Delete car from the database
            ClearFields(); // Clear input fields
            LoadCarDetails(); // Refresh DataGridView
        }

        // Handles cell click event to load selected car details into input fields
        private void dgvCarDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCarDetails.Rows[e.RowIndex];
                txtCarID.Text = row.Cells["CarID"].Value.ToString();
                txtMake.Text = row.Cells["Make"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtYear.Text = row.Cells["Year"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        // Clears input fields
        private void ClearFields()
        {
            txtCarID.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
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
