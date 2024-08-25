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

        private void txtMenuStripSearchCarDetails_Click(object sender, EventArgs e)
        {
            SearchCarDetails searchCarDetailsForm = new SearchCarDetails();
            searchCarDetailsForm.Show();
            this.Hide();
        }

        private void txtMenuStripSearchCarParts_Click(object sender, EventArgs e)
        {
            SearchCarParts searchCarPartsForm = new SearchCarParts();
            searchCarPartsForm.Show();
            this.Hide();
        }

        private void txtMenuStripOrderCar_Click(object sender, EventArgs e)
        {
            OrderCar orderCarForm = new OrderCar();
            orderCarForm.Show();
            this.Hide();
        }

        private void txtMenuStripOrderCarParts_Click(object sender, EventArgs e)
        {
            OrderCarParts orderCarPartsForm = new OrderCarParts();
            orderCarPartsForm.Show();
            this.Hide();
        }

        private void txtMenuStripOrderStatus_Click(object sender, EventArgs e)
        {
            ViewOrderStatus viewOrderStatusForm = new ViewOrderStatus();
            viewOrderStatusForm.Show();
            this.Hide();
        }
    }
}
