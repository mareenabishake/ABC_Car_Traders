using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class SearchCarParts : Form
    {
        private CarPart carPart;

        public SearchCarParts()
        {
            InitializeComponent();
            carPart = new CarPart();
            LoadAllCarPartDetails();
        }

        private void LoadAllCarPartDetails()
        {
            dgvCarParts.DataSource = carPart.GetAllCarPartDetails();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPartID.Text))
            {
                LoadAllCarPartDetails();
            }
            else
            {
                int partId = int.Parse(txtPartID.Text);
                dgvCarParts.DataSource = carPart.GetCarPartDetails(partId);
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
