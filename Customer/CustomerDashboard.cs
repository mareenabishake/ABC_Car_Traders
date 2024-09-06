using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        // Opens the SearchCarDetails form 
        private void btnSearchCarDetails_Click(object sender, EventArgs e)
        {
            SearchCarDetails searchCarDetailsForm = new SearchCarDetails();
            searchCarDetailsForm.Show();
            this.Hide();
        }

        // Opens the SearchCarParts form
        private void btnSearchCarParts_Click(object sender, EventArgs e)
        {
            SearchCarParts searchCarPartsForm = new SearchCarParts();
            searchCarPartsForm.Show();
            this.Hide();
        }

        // Opens the OrderCar form
        private void btnOrderCar_Click(object sender, EventArgs e)
        {
            OrderCar orderCarForm = new OrderCar();
            orderCarForm.Show();
            this.Hide();
        }

        // Opens the OrderCarParts form
        private void btnOrderCarParts_Click(object sender, EventArgs e)
        {
            OrderCarParts orderCarPartsForm = new OrderCarParts();
            orderCarPartsForm.Show();
            this.Hide();
        }

        // Opens the ViewOrderStatus form
        private void btnViewOrderStatus_Click(object sender, EventArgs e)
        {
            ViewOrderStatus viewOrderStatusForm = new ViewOrderStatus();
            viewOrderStatusForm.Show();
            this.Hide();
        }
    }
}
