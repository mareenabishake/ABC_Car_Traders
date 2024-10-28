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

        // Populates grid with complete parts inventory
        private void LoadAllCarPartDetails()
        {
            try
            {
                var partsData = carPart.GetAllCarPartDetails();
                if (partsData == null || partsData.Rows.Count == 0)
                {
                    MessageBox.Show("No car parts found in inventory.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvCarParts.DataSource = partsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading car parts: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filters parts based on part ID or shows all if no ID specified
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // If both fields are empty, show all parts
                if (string.IsNullOrEmpty(txtPartID.Text) && string.IsNullOrEmpty(txtPartName.Text))
                {
                    LoadAllCarPartDetails();
                    return;
                }

                // Initialize variables for search parameters
                int? partId = null;
                string partName = txtPartName.Text.Trim();

                // Try parse part ID if provided
                if (!string.IsNullOrEmpty(txtPartID.Text))
                {
                    if (!int.TryParse(txtPartID.Text, out int id))
                    {
                        MessageBox.Show("Part ID must be a valid number.", "Validation Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    partId = id;
                }

                var result = carPart.GetCarPartDetails(partId, partName);
                if (result == null || result.Rows.Count == 0)
                {
                    MessageBox.Show("No parts found matching the search criteria.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvCarParts.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for parts: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
