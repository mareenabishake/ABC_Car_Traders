using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Car_Traders; // Add this line to access the DatabaseHelper class

namespace ABC_Car_Traders.Classes.Utilities
{
    internal class ReportGenerator
    {
        private readonly DatabaseHelper dbHelper;

        public ReportGenerator()
        {
            dbHelper = new DatabaseHelper();
        }

        public static void GeneratePdfReport(DataTable data, string reportTitle, string outputPath)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));
            document.Open();

            // Add title
            Paragraph title = new Paragraph(reportTitle, new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);
            document.Add(Chunk.NEWLINE);

            // Check if the DataTable has any columns
            if (data.Columns.Count > 0)
            {
                // Create table
                PdfPTable table = new PdfPTable(data.Columns.Count);
                table.WidthPercentage = 100;

                // Add headers
                foreach (DataColumn column in data.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                // Add data
                foreach (DataRow row in data.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), new Font(Font.FontFamily.HELVETICA, 10)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                document.Add(table);
            }
            else
            {
                // Add a message when there's no data
                Paragraph noData = new Paragraph("No data available for this report.", new Font(Font.FontFamily.HELVETICA, 12));
                document.Add(noData);
            }

            document.Close();
        }

        public DataTable GenerateCustomerReport()
        {
            string query = @"
                SELECT 
                    UserID,
                    Username,
                    Name,
                    Email,
                    Phone,
                    Address,
                    UserType
                FROM 
                    Users
                WHERE 
                    UserType = 'Customer'
                ORDER BY 
                    Name";

            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GenerateCarInventoryReport()
        {
            string query = @"
                SELECT 
                    CarID,
                    Make,
                    Model,
                    Year,
                    Price
                FROM 
                    Cars
                ORDER BY 
                    Make, Model, Year";

            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GenerateCarPartInventoryReport()
        {
            string query = @"
                SELECT 
                    PartID,
                    Name,
                    Description,
                    Price
                FROM 
                    CarParts
                ORDER BY 
                    Name";

            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GenerateOrderReport()
        {
            string query = @"
                SELECT 
                    o.OrderID,
                    u.Name AS CustomerName,
                    c.Make + ' ' + c.Model AS Car,
                    cp.Name AS PartName,
                    o.Quantity,
                    o.OrderStatus
                FROM 
                    Orders o
                    LEFT JOIN Users u ON o.CustomerID = u.UserID
                    LEFT JOIN Cars c ON o.CarID = c.CarID
                    LEFT JOIN CarParts cp ON o.PartID = cp.PartID
                ORDER BY 
                    o.OrderID";

            return dbHelper.ExecuteQuery(query);
        }
    }
}
