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
using System.Diagnostics;


namespace ABC_Car_Traders
{
    public partial class GenerateReports : Form
    {
        // Instance of ReportGenerator to handle report data retrieval and formatting
        private ReportGenerator reportGenerator;

        public GenerateReports()
        {
            InitializeComponent();
            reportGenerator = new ReportGenerator();
        }

        // Helper method to generate PDF report and automatically open it
        // Parameters:
        // - reportData: DataTable containing the report data
        // - reportTitle: Title to display at the top of the PDF
        // - fileName: Name of the PDF file to be saved
        private void GenerateAndOpenPdfReport(DataTable reportData, string reportTitle, string fileName)
        {
            try
            {
                if (reportData == null || reportData.Rows.Count == 0)
                {
                    MessageBox.Show("No data available for report.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string outputPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{fileName}";
                ReportGenerator.GeneratePdfReport(reportData, reportTitle, outputPath);
                Process.Start(outputPath);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Access denied when saving report: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for generating customer report
        // Retrieves customer data and generates PDF report
        private void btnGenerateCustomerReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable customerReport = reportGenerator.GenerateCustomerReport();
                GenerateAndOpenPdfReport(customerReport, "Customer Report", "CustomerReport.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating customer report: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for generating car inventory report
        // Creates PDF containing all cars in inventory with details
        private void btnGenerateCarInventoryReport_Click(object sender, EventArgs e)
        {
            DataTable inventoryReport = reportGenerator.GenerateCarInventoryReport();
            GenerateAndOpenPdfReport(inventoryReport, "Car Inventory Report", "CarInventoryReport.pdf");
        }

        // Event handler for generating car parts inventory report
        // Creates PDF listing all car parts with descriptions and prices
        private void btnGenerateCarPartInventoryReport_Click(object sender, EventArgs e)
        {
            DataTable inventoryReport = reportGenerator.GenerateCarPartInventoryReport();
            GenerateAndOpenPdfReport(inventoryReport, "Car Part Inventory Report", "CarPartInventoryReport.pdf");
        }

        // Event handler for generating order report
        // Creates PDF containing all order information including status
        private void btnGenerateOrderReport_Click_1(object sender, EventArgs e)
        {
            DataTable orderReport = reportGenerator.GenerateOrderReport();
            GenerateAndOpenPdfReport(orderReport, "Order Report", "OrderReport.pdf");
        }
    }
}
