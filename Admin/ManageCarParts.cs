using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ManageCarParts : Form
    {
        // Instance of CarPart class to handle part-related operations
        private CarPart carPart;

        public ManageCarParts()
        {
            InitializeComponent();
            carPart = new CarPart();
            LoadCarPartDetails();
        }

        // Loads all car part details into the DataGridView
        private void LoadCarPartDetails()
        {
            dgvCarParts.DataSource = carPart.GetAllCarPartDetails();
        }

        // Event handler for adding new car parts
        // Validates required fields and adds part to inventory
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

        // Event handler for editing existing car parts
        // Updates part information in the database
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

        // Event handler for deleting car parts
        // Removes part from inventory system
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

        // Event handler for DataGridView cell click
        // Populates form fields with selected part details
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

        // Clears all input fields after operations
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
