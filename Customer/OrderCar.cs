using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class OrderCar : Form
    {
        private Order order;

        public OrderCar(User CurrentUser)
        {
            InitializeComponent();
            order = new Order();
            LoadCarDetails();
            txtCustomerID.Text = CurrentUser.UserID.ToString();
        }

        // Populates available vehicles for ordering
        private void LoadCarDetails()
        {
            try
            {
                Car car = new Car();
                var carData = car.GetAllCarDetails();
                if (carData == null || carData.Rows.Count == 0)
                {
                    MessageBox.Show("No cars available for ordering.", "Information", 
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

        // Validates and processes the vehicle order
        private void btnOrderCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerID.Text) || 
                    string.IsNullOrEmpty(txtCarID.Text))
                {
                    MessageBox.Show("Customer ID and Car ID are required.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtCustomerID.Text, out int customerID) ||
                    !int.TryParse(txtCarID.Text, out int carID))
                {
                    MessageBox.Show("Invalid input. Please enter valid numbers.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                order.PlaceOrder(customerID, carID, null, null);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Resets form fields after order completion
        private void ClearFields()
        {
            txtCarID.Clear();
        }

        // Auto-fills car ID when selecting from vehicle grid
        private void dgvCarDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvCarDetails.Rows[e.RowIndex];
                    txtCarID.Text = row.Cells["CarID"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting car: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
