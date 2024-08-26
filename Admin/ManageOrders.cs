using System;
using System.Windows.Forms;
using System.Data;

namespace ABC_Car_Traders
{
    public partial class ManageOrders : Form
    {
        private Order order; // Object to manage orders

        public ManageOrders()
        {
            InitializeComponent();
            order = new Order(); // Initialize Order object
            LoadOrderDetails(); // Load order details into DataGridView on form load
        }

        // Loads all order details into the DataGridView
        private void LoadOrderDetails()
        {
            DataTable dt = order.GetAllOrderDetails();
            dgvManageOrders.DataSource = dt;
        }

        // Handles cell click event to load selected order details into input fields
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

        // Places a new order
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(txtCustomerID.Text) ||
                (string.IsNullOrEmpty(txtCarID.Text) && string.IsNullOrEmpty(txtPartID.Text)))
            {
                MessageBox.Show("Customer ID and either Car ID or Part ID are required.");
                return;
            }

            int customerID = int.Parse(txtCustomerID.Text);
            int? carID = string.IsNullOrEmpty(txtCarID.Text) ? (int?)null : int.Parse(txtCarID.Text);
            int? partID = string.IsNullOrEmpty(txtPartID.Text) ? (int?)null : int.Parse(txtPartID.Text);
            int? quantity = string.IsNullOrEmpty(txtQuantity.Text) ? (int?)null : int.Parse(txtQuantity.Text);

            // Check if quantity is provided when ordering a part
            if (partID.HasValue && !quantity.HasValue)
            {
                MessageBox.Show("Quantity is required when ordering a car part.");
                return;
            }

            // Place the order and refresh the DataGridView
            order.PlaceOrder(customerID, carID, partID, quantity);
            MessageBox.Show("Order placed successfully!");
            LoadOrderDetails();
        }

        // Updates an existing order
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(txtOrderID.Text) || string.IsNullOrEmpty(txtOrderStatus.Text))
            {
                MessageBox.Show("Order ID and Order Status are required.");
                return;
            }

            int orderID = int.Parse(txtOrderID.Text);
            string orderStatus = txtOrderStatus.Text;

            // Update the order status and refresh the DataGridView
            order.UpdateOrder(orderID, orderStatus);
            LoadOrderDetails();
        }

        // Deletes a selected order
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Validate order selection
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Order ID is required.");
                return;
            }

            int orderID = int.Parse(txtOrderID.Text);
            order.DeleteOrder(orderID); // Delete the order from the database
            LoadOrderDetails(); // Refresh the DataGridView
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
