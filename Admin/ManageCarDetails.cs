using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ManageCarDetails : Form
    {
        private Car car;

        public ManageCarDetails()
        {
            InitializeComponent();
            car = new Car();
            LoadCarDetails();
        }

        private void LoadCarDetails()
        {
            dgvCarDetails.DataSource = car.GetAllCarDetails();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMake.Text) || string.IsNullOrEmpty(txtModel.Text) ||
                string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            car.AddCar(txtMake.Text, txtModel.Text, year, price);
            ClearFields();
            LoadCarDetails();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarID.Text))
            {
                MessageBox.Show("Please select a car to edit.");
                return;
            }

            int carID = int.Parse(txtCarID.Text);
            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            car.EditCar(carID, txtMake.Text, txtModel.Text, year, price);
            ClearFields();
            LoadCarDetails();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarID.Text))
            {
                MessageBox.Show("Please select a car to delete.");
                return;
            }

            int carID = int.Parse(txtCarID.Text);
            car.DeleteCar(carID);
            ClearFields();
            LoadCarDetails();
        }

        private void dgvCarDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCarDetails.Rows[e.RowIndex];
                txtCarID.Text = row.Cells["CarID"].Value.ToString();
                txtMake.Text = row.Cells["Make"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtYear.Text = row.Cells["Year"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtCarID.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }
    }
}
