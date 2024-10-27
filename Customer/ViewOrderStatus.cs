using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ViewOrderStatus : Form
    {
        private Order order;

        public ViewOrderStatus()
        {
            InitializeComponent();
            order = new Order();
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
                MessageBox.Show($"The status of your order (ID: {orderID}) is: {status}");
            }
            else
            {
                MessageBox.Show("Order not found or invalid Order ID.");
            }
        }
    }
}
