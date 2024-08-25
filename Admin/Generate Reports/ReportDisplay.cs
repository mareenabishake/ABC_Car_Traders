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
    public partial class ReportDisplay : Form
    {
        public ReportDisplay(DataTable reportData, string reportTitle)
        {
            InitializeComponent();
            lblReportTitle.Text = reportTitle;
            dgvReportDisplay.DataSource = reportData;
        }

        private void txtMenuStripManageCarDetails_Click(object sender, EventArgs e)
        {
            ManageCarDetails carDetailsForm = new ManageCarDetails();
            carDetailsForm.Show();
            this.Hide();
        }

        private void txtMenuStripManageCarParts_Click(object sender, EventArgs e)
        {
            ManageCarParts carPartsForm = new ManageCarParts();
            carPartsForm.Show();
            this.Hide();
        }

        private void txtMenuStripManageCustomerDetails_Click(object sender, EventArgs e)
        {
            ManageCustomerDetails customerDetailsForm = new ManageCustomerDetails();
            customerDetailsForm.Show();
            this.Hide();
        }

        private void txtMenuStripManageOrders_Click(object sender, EventArgs e)
        {
            ManageOrders ordersForm = new ManageOrders();
            ordersForm.Show();
            this.Hide();
        }

        private void txtMenuStripGenerateReports_Click(object sender, EventArgs e)
        {
            GenerateReports reportsForm = new GenerateReports();
            reportsForm.Show();
            this.Hide();
        }
    }
}