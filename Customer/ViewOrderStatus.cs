using System;
using System.Data;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
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

        private void LoadCustomerOrders()
        {
            dgvViewOrderStatus.DataSource = order.GetCustomerOrderDetails(currentUser.UserID);
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please enter a valid Order ID.");
                return;
            }

            int orderID = int.Parse(txtOrderID.Text);
            string status = order.GetOrderStatus(orderID);

            if (!string.IsNullOrEmpty(status))
            {
                lblOrderStatus.Text = $"Your Order Status is: {status}";
                lblOrderStatus.Visible = true;
            }
            else
            {
                MessageBox.Show("Order not found or invalid Order ID.");
                lblOrderStatus.Visible = false;
            }
        }

        private void dgvViewOrderStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvViewOrderStatus.Rows[e.RowIndex];
                txtOrderID.Text = row.Cells["OrderID"].Value.ToString();
            }
        }
    }
}
