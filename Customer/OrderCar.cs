using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class OrderCar : Form
    {
        private Order order;

        public OrderCar(User CurrentUser)
        {
            InitializeComponent();
            order = new Order();
            LoadCarDetails();
            txtCustomerID.Text = CurrentUser.UserID.ToString();
        }

        private void LoadCarDetails()
        {
            // Load all car details into the DataGridView
            Car car = new Car();
            dgvCarDetails.DataSource = car.GetAllCarDetails();
        }

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

        private void ClearFields()
        {
            txtCarID.Clear();
        }

        private void dgvCarDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCarDetails.Rows[e.RowIndex];
                txtCarID.Text = row.Cells["CarID"].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
