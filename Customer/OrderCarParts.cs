using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class OrderCarParts : Form
    {
        private Order order;

        public OrderCarParts()
        {
            InitializeComponent();
            order = new Order();
            LoadCarPartDetails();
        }

        private void LoadCarPartDetails()
        {
            // Load all car part details into the DataGridView
            CarPart carPart = new CarPart();
            dgvPartDetails.DataSource = carPart.GetAllCarPartDetails();
        }


        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtPartID.Clear();
            txtQuantity.Clear();
        }

        private void dgvCarPartDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPartDetails.Rows[e.RowIndex];
                txtPartID.Text = row.Cells["PartID"].Value.ToString();
            }
        }

        private void btnOrderCarPart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtPartID.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Customer ID, Part ID, and Quantity are required to place an order.");
                return;
            }

            int customerID = int.Parse(txtCustomerID.Text);
            int partID = int.Parse(txtPartID.Text);
            int quantity = int.Parse(txtQuantity.Text);

            order.PlaceOrder(customerID, null, partID, quantity);

            MessageBox.Show("Car part order placed successfully!");
            ClearFields();
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
