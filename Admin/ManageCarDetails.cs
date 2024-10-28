using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ManageCarDetails : Form
    {
        // Instance of Car class to handle car-related operations
        private Car car;

        public ManageCarDetails()
        {
            InitializeComponent();
            car = new Car();
            LoadCarDetails();
        }

        // Loads all car details into the DataGridView
        private void LoadCarDetails()
        {
            try
            {
                var carData = car.GetAllCarDetails();
                if (carData == null || carData.Rows.Count == 0)
                {
                    MessageBox.Show("No cars found in inventory.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvCarDetails.DataSource = carData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading car details: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for adding new cars
        // Validates required fields and adds car to inventory
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMake.Text) || string.IsNullOrEmpty(txtModel.Text) ||
                    string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MessageBox.Show("Invalid year format.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price format.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                car.AddCar(txtMake.Text, txtModel.Text, year, price);
                ClearFields();
                LoadCarDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding car: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for editing existing cars
        // Updates car information in the database
        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarID.Text))
            {
                MessageBox.Show("Please select a car to edit.");
                return;
            }

            int carID = int.Parse(txtCarID.Text);
            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            car.EditCar(carID, txtMake.Text, txtModel.Text, year, price);
            ClearFields();
            LoadCarDetails();
        }

        // Event handler for deleting cars
        // Removes car from inventory system
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarID.Text))
            {
                MessageBox.Show("Please select a car to delete.");
                return;
            }

            int carID = int.Parse(txtCarID.Text);
            car.DeleteCar(carID);
            ClearFields();
            LoadCarDetails();
        }

        // Event handler for DataGridView cell click
        // Populates form fields with selected car details
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

        // Clears all input fields after operations
        private void ClearFields()
        {
            txtCarID.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }
    }
}
