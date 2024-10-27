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

        private void LoadAllCarDetails()
        {
            dgvCarDetails.DataSource = car.GetAllCarDetails();
        }

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
    }
}
