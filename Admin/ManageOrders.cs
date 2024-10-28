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

    }
}
