using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class OrderCarParts : Form
    {
        private Order order;

        public OrderCarParts(User CurrentUser)
        {
            InitializeComponent();
            order = new Order();
            LoadCarPartDetails();
            txtCustomerID.Text = CurrentUser.UserID.ToString();
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
    }
}
