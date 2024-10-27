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
        private ReportGenerator reportGenerator;

        public GenerateReports()
        {
            InitializeComponent();
            reportGenerator = new ReportGenerator();
        }

        private void GenerateAndOpenPdfReport(DataTable reportData, string reportTitle, string fileName)
        {
            string outputPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{fileName}";
            ReportGenerator.GeneratePdfReport(reportData, reportTitle, outputPath);
            Process.Start(outputPath);
        }

        private void btnGenerateCustomerReport_Click(object sender, EventArgs e)
        {
            DataTable customerReport = reportGenerator.GenerateCustomerReport();
            GenerateAndOpenPdfReport(customerReport, "Customer Report", "CustomerReport.pdf");
        }

        private void btnGenerateCarInventoryReport_Click(object sender, EventArgs e)
        {
            DataTable inventoryReport = reportGenerator.GenerateCarInventoryReport();
            GenerateAndOpenPdfReport(inventoryReport, "Car Inventory Report", "CarInventoryReport.pdf");
        }

        private void btnGenerateCarPartInventoryReport_Click(object sender, EventArgs e)
        {
            DataTable inventoryReport = reportGenerator.GenerateCarPartInventoryReport();
            GenerateAndOpenPdfReport(inventoryReport, "Car Part Inventory Report", "CarPartInventoryReport.pdf");
        }

        private void btnGenerateOrderReport_Click_1(object sender, EventArgs e)
        {
            DataTable orderReport = reportGenerator.GenerateOrderReport();
            GenerateAndOpenPdfReport(orderReport, "Order Report", "OrderReport.pdf");
        }
    }
}
