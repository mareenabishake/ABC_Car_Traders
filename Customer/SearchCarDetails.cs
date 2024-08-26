using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class SearchCarDetails : Form
    {
        private Car car;

        public SearchCarDetails()
        {
            InitializeComponent();
            car = new Car();
            LoadAllCarDetails();
        }

        // Load all car details into the DataGridView
        private void LoadAllCarDetails()
        {
            dgvCarDetails.DataSource = car.GetAllCarDetails();
        }

        // Search for car details based on CarID input
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarID.Text))
            {
                LoadAllCarDetails();
            }
            else
            {
                int carId = int.Parse(txtCarID.Text);
                dgvCarDetails.DataSource = car.GetCarDetails(carId);
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
