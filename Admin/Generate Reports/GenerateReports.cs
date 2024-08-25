using ABC_Car_Traders.Classes.Utilities;
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
    public partial class GenerateReports : Form
    {
        private ReportGenerator reportGenerator;

        public GenerateReports()
        {
            InitializeComponent();
            reportGenerator = new ReportGenerator();
        }

        private void ShowReport(DataTable reportData, string reportTitle)
        {
            ReportDisplay reportDisplay = new ReportDisplay(reportData, reportTitle);
            reportDisplay.Show();
        }

        private void btnGenerateCustomerReport_Click(object sender, EventArgs e)
        {
            DataTable customerReport = reportGenerator.GenerateCustomerReport();
            ShowReport(customerReport, "Customer Report");
            this.Hide();
        }

        private void btnGenerateCarInventoryReport_Click(object sender, EventArgs e)
        {
            DataTable inventoryReport = reportGenerator.GenerateCarInventoryReport();
            ShowReport(inventoryReport, "Car Inventory Report");
            this.Hide();
        }

        private void btnGenerateCarPartInventoryReport_Click(object sender, EventArgs e)
        {
            DataTable inventoryReport = reportGenerator.GenerateCarPartInventoryReport();
            ShowReport(inventoryReport, "Car Part Inventory Report");
            this.Hide();
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
