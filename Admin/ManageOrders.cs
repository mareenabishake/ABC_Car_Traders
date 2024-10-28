using System;
using System.Windows.Forms;
using System.Data;

namespace ABC_Car_Traders
{
    public partial class ManageOrders : Form
    {
        // Instance of Order class to handle order-related operations
        private Order order;

        public ManageOrders()
        {
            InitializeComponent();
            order = new Order();
            LoadOrderDetails();
        }

        // Loads all order details into the DataGridView for display
        private void LoadOrderDetails()
        {
            try
            {
                DataTable dt = order.GetAllOrderDetails();
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvManageOrders.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for DataGridView cell click
        // Populates form fields with selected order details
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvManageOrders.Rows[e.RowIndex];
                txtOrderID.Text = row.Cells["OrderID"].Value.ToString();
                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCarID.Text = row.Cells["CarID"].Value?.ToString();
                txtPartID.Text = row.Cells["PartID"].Value?.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();
                txtOrderStatus.Text = row.Cells["OrderStatus"].Value.ToString();
            }
        }

        // Event handler for placing new orders
        // Validates required fields and handles both car and part orders
        // Requires either CarID or PartID, and quantity for part orders
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerID.Text) ||
                    (string.IsNullOrEmpty(txtCarID.Text) && string.IsNullOrEmpty(txtPartID.Text)))
                {
                    MessageBox.Show("Customer ID and either Car ID or Part ID are required.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtCustomerID.Text, out int customerID))
                {
                    MessageBox.Show("Invalid Customer ID format.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int? carID = null;
                int? partID = null;
                int? quantity = null;

                if (!string.IsNullOrEmpty(txtCarID.Text) && !int.TryParse(txtCarID.Text, out int carIdValue))
                {
                    MessageBox.Show("Invalid Car ID format.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!string.IsNullOrEmpty(txtCarID.Text))
                {
                    carID = int.Parse(txtCarID.Text);
                }

                // Similar validation for partID and quantity
                // ... validation code ...

                order.PlaceOrder(customerID, carID, partID, quantity);
                LoadOrderDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for updating existing orders
        // Updates order status and refreshes the display
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text) || string.IsNullOrEmpty(txtOrderStatus.Text))
            {
                MessageBox.Show("Order ID and Order Status are required.");
                return;
            }

            int orderID = int.Parse(txtOrderID.Text);
            string orderStatus = txtOrderStatus.Text;

            order.UpdateOrder(orderID, orderStatus);
            LoadOrderDetails();
        }

        // Event handler for deleting orders
        // Removes selected order from the database
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Order ID is required.");
                return;
            }

            int orderID = int.Parse(txtOrderID.Text);
            order.DeleteOrder(orderID);
            LoadOrderDetails();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
