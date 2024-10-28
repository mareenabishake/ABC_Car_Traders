using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class SearchCarDetails : Form
    {
        private Car car;

        public SearchCarDetails()
        {
            InitializeComponent();
            car = new Car();
            LoadAllCarDetails();
        }

        // Populates grid with complete vehicle inventory
        private void LoadAllCarDetails()
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

        // Filters vehicles based on car ID or shows all if no ID specified
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // If both fields are empty, show all cars
                if (string.IsNullOrEmpty(txtCarID.Text) && string.IsNullOrEmpty(txtCarName.Text))
                {
                    LoadAllCarDetails();
                    return;
                }

                // Initialize variables for search parameters
                int? carId = null;
                string carName = txtCarName.Text.Trim();

                // Try parse car ID if provided
                if (!string.IsNullOrEmpty(txtCarID.Text))
                {
                    if (!int.TryParse(txtCarID.Text, out int id))
                    {
                        MessageBox.Show("Car ID must be a valid number.", "Validation Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    carId = id;
                }

                var result = car.GetCarDetails(carId, carName);
                if (result == null || result.Rows.Count == 0)
                {
                    MessageBox.Show("No cars found matching the search criteria.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvCarDetails.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for cars: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
