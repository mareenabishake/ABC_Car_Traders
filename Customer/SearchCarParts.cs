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
    }
}
