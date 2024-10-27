using System;
using System.Windows.Forms;
using System.Data;

namespace ABC_Car_Traders
{
    public partial class ManageOrders : Form
    {
        private Order order;

        public ManageOrders()
        {
            InitializeComponent();
            order = new Order();
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            // Load all orders into the DataGridView
            DataTable dt = order.GetAllOrderDetails();
            dgvManageOrders.DataSource = dt;
        }

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

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
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

            // If partID is provided, quantity must also be provided
            if (partID.HasValue && !quantity.HasValue)
            {
                MessageBox.Show("Quantity is required when ordering a car part.");
                return;
            }

            order.PlaceOrder(customerID, carID, partID, quantity);
            MessageBox.Show("Order placed successfully!");
            LoadOrderDetails();
        }

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
