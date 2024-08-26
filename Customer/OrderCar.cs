using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class OrderCar : Form
    {
        private Order order;

        public OrderCar()
        {
            InitializeComponent();
            order = new Order();
            LoadCarDetails();
        }

        // Loads all car details into the DataGridView
        private void LoadCarDetails()
        {
            Car car = new Car();
            dgvCarDetails.DataSource = car.GetAllCarDetails();
        }

        // Places a new car order
        private void btnOrderCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtCarID.Text))
            {
                MessageBox.Show("Customer ID and Car ID are required to place an order.");
                return;
            }

            int customerID = int.Parse(txtCustomerID.Text);
            int carID = int.Parse(txtCarID.Text);

            order.PlaceOrder(customerID, carID, null, null);
            MessageBox.Show("Car order placed successfully!");
            ClearFields();
        }

        // Clears input fields
        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtCarID.Clear();
        }

        // Loads selected car details into input fields
        private void dgvCarDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCarDetails.Rows[e.RowIndex];
                txtCarID.Text = row.Cells["CarID"].Value.ToString();
            }
        }

        // Menu strip navigation methods
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
