using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ManageCarParts : Form
    {
        private CarPart carPart;

        public ManageCarParts()
        {
            InitializeComponent();
            carPart = new CarPart();
            LoadCarPartDetails();
        }

        private void LoadCarPartDetails()
        {
            dgvCarParts.DataSource = carPart.GetAllCarPartDetails();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDescription.Text) ||
                string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            decimal price = decimal.Parse(txtPrice.Text);
            carPart.AddCarPart(txtName.Text, txtDescription.Text, price);
            ClearFields();
            LoadCarPartDetails();
        }

        private void btnEditPart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPartID.Text))
            {
                MessageBox.Show("Please select a part to edit.");
                return;
            }

            int partID = int.Parse(txtPartID.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            carPart.EditCarPart(partID, txtName.Text, txtDescription.Text, price);
            ClearFields();
            LoadCarPartDetails();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPartID.Text))
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            int partID = int.Parse(txtPartID.Text);
            carPart.DeleteCarPart(partID);
            ClearFields();
            LoadCarPartDetails();
        }

        private void dgvCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCarParts.Rows[e.RowIndex];
                txtPartID.Text = row.Cells["PartID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtPartID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
        }

        private void dgvCarParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
