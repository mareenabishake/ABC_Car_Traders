using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class OrderCarParts : Form
    {
        private Order order;

        public OrderCarParts(User CurrentUser)
        {
            InitializeComponent();
            order = new Order();
            LoadCarPartDetails();
            txtCustomerID.Text = CurrentUser.UserID.ToString();
        }

        // Populates available parts for ordering
        private void LoadCarPartDetails()
        {
            try
            {
                CarPart carPart = new CarPart();
                var partsData = carPart.GetAllCarPartDetails();
                if (partsData == null || partsData.Rows.Count == 0)
                {
                    MessageBox.Show("No parts available for ordering.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvPartDetails.DataSource = partsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading part details: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Resets form fields after order completion
        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtPartID.Clear();
            txtQuantity.Clear();
        }

        // Auto-fills part ID when selecting from parts grid
        private void dgvCarPartDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvPartDetails.Rows[e.RowIndex];
                    txtPartID.Text = row.Cells["PartID"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting part: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validates and processes the car part order
        private void btnOrderCarPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerID.Text) || 
                    string.IsNullOrEmpty(txtPartID.Text) || 
                    string.IsNullOrEmpty(txtQuantity.Text))
                {
                    MessageBox.Show("Customer ID, Part ID, and Quantity are required.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtCustomerID.Text, out int customerID) ||
                    !int.TryParse(txtPartID.Text, out int partID) ||
                    !int.TryParse(txtQuantity.Text, out int quantity))
                {
                    MessageBox.Show("Invalid input. Please enter valid numbers.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                order.PlaceOrder(customerID, null, partID, quantity);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
