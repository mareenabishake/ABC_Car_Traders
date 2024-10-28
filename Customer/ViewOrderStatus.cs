using System;
using System.Data;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    // Displays and manages customer order status information
    public partial class ViewOrderStatus : Form
    {
        private Order order;
        private User currentUser;

        public ViewOrderStatus(User CurrentUser)
        {
            InitializeComponent();
            order = new Order();
            currentUser = CurrentUser;
            LoadCustomerOrders();
        }

        // Initializes form and loads customer's order history
        private void LoadCustomerOrders()
        {
            try
            {
                var orderData = order.GetCustomerOrderDetails(currentUser.UserID);
                if (orderData == null || orderData.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found for this customer.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvViewOrderStatus.DataSource = orderData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Retrieves and displays status for a specific order
        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrderID.Text))
                {
                    MessageBox.Show("Please enter a valid Order ID.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtOrderID.Text, out int orderID))
                {
                    MessageBox.Show("Order ID must be a valid number.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string status = order.GetOrderStatus(orderID);
                if (!string.IsNullOrEmpty(status))
                {
                    lblOrderStatus.Text = $"Your Order Status is: {status}";
                    lblOrderStatus.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving order status: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblOrderStatus.Visible = false;
            }
        }

        // Populates order ID field when selecting from order grid
        private void dgvViewOrderStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvViewOrderStatus.Rows[e.RowIndex];
                    txtOrderID.Text = row.Cells["OrderID"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting order: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
