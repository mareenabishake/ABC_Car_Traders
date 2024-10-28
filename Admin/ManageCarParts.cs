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
            try
            {
                dgvCarParts.DataSource = carPart.GetAllCarPartDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading car parts: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for adding new car parts
        // Validates required fields and adds part to inventory
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDescription.Text) ||
                    string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please fill in all the fields.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Please enter a valid price.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                carPart.AddCarPart(txtName.Text, txtDescription.Text, price);
                ClearFields();
                LoadCarPartDetails();
                MessageBox.Show("Part added successfully!", "Success", 
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding car part: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for editing existing car parts
        // Updates part information in the database
        private void btnEditPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPartID.Text))
                {
                    MessageBox.Show("Please select a part to edit.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtPartID.Text, out int partID))
                {
                    MessageBox.Show("Invalid Part ID.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Please enter a valid price.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                carPart.EditCarPart(partID, txtName.Text, txtDescription.Text, price);
                ClearFields();
                LoadCarPartDetails();
                MessageBox.Show("Part updated successfully!", "Success", 
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating car part: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for deleting car parts
        // Removes part from inventory system
        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPartID.Text))
                {
                    MessageBox.Show("Please select a part to delete.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtPartID.Text, out int partID))
                {
                    MessageBox.Show("Invalid Part ID.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", 
                                                    "Confirm Delete", 
                                                    MessageBoxButtons.YesNo, 
                                                    MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    carPart.DeleteCarPart(partID);
                    ClearFields();
                    LoadCarPartDetails();
                    MessageBox.Show("Part deleted successfully!", "Success", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting car part: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for DataGridView cell click
        // Populates form fields with selected part details
        private void dgvCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvCarParts.Rows[e.RowIndex];
                    txtPartID.Text = row.Cells["PartID"].Value?.ToString();
                    txtName.Text = row.Cells["Name"].Value?.ToString();
                    txtDescription.Text = row.Cells["Description"].Value?.ToString();
                    txtPrice.Text = row.Cells["Price"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting car part: {ex.Message}", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
