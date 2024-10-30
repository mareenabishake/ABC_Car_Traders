using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Car_Traders; 

namespace ABC_Car_Traders.Classes.Utilities
{
    internal class ReportGenerator
    {
        private readonly DatabaseHelper dbHelper;

        public ReportGenerator()
        {
            dbHelper = new DatabaseHelper();
        }

        // Generates various business reports in PDF format using iTextSharp
        public static void GeneratePdfReport(DataTable data, string reportTitle, string outputPath)
        {
            Document document = null;
            try
            {
                // Initialize a new PDF document
                document = new Document();

                // Create a PDF writer instance to write to the specified file
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));
                document.Open();

                // Create and add the title to the document
                Paragraph title = new Paragraph(reportTitle, new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);
                document.Add(Chunk.NEWLINE);

                // Check if the DataTable has any columns to display
                if (data.Columns.Count > 0)
                {
                    // Initialize the PDF table with the same number of columns as the DataTable
                    PdfPTable table = new PdfPTable(data.Columns.Count);
                    table.WidthPercentage = 100; // Make table full width

                    // Add column headers to the PDF table
                    foreach (DataColumn column in data.Columns)
                    {
                        // Create header cells with bold font
                        PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, 
                            new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    // Add data rows to the PDF table
                    foreach (DataRow row in data.Rows)
                    {
                        foreach (object item in row.ItemArray)
                        {
                            // Create data cells with regular font
                            PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), 
                                new Font(Font.FontFamily.HELVETICA, 10)));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }
                    }

                    // Add the completed table to the document
                    document.Add(table);
                }
                else
                {
                    // Display a message when no data is available
                    Paragraph noData = new Paragraph("No data available for this report.", 
                        new Font(Font.FontFamily.HELVETICA, 12));
                    document.Add(noData);
                }

                document.Close();
            }
            catch (IOException ex)
            {
                // Handle file access errors
                throw new Exception($"Error accessing the file: {ex.Message}", ex);
            }
            catch (DocumentException ex)
            {
                // Handle PDF document generation errors
                throw new Exception($"Error generating PDF document: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                throw new Exception($"An unexpected error occurred while generating the report: {ex.Message}", ex);
            }
            finally
            {
                // Ensure document is properly closed even if an error occurs
                if (document != null && document.IsOpen())
                {
                    document.Close();
                }
            }
        }

        // Generates a report of all customers in the system
        public DataTable GenerateCustomerReport()
        {
            try
            {
                // SQL query to get all customer information
                // Filters for customer type users only and orders by name
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

                // Execute query and return results
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                // Handle any errors during report generation
                throw new Exception($"Error generating customer report: {ex.Message}", ex);
            }
        }

        // Generates a report of current car inventory
        public DataTable GenerateCarInventoryReport()
        {
            try
            {
                // SQL query to get all car inventory information
                // Orders results by make, model, and year for easy reading
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

                // Execute query and return results
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                // Handle any errors during report generation
                throw new Exception($"Error generating car inventory report: {ex.Message}", ex);
            }
        }

        // Generates a report of current parts inventory
        public DataTable GenerateCarPartInventoryReport()
        {
            try
            {
                // SQL query to get all car parts information
                // Orders results by part name for easy reference
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

                // Execute query and return results
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                // Handle any errors during report generation
                throw new Exception($"Error generating car part inventory report: {ex.Message}", ex);
            }
        }

        // Generates a comprehensive order report including customer and product details
        public DataTable GenerateOrderReport()
        {
            try
            {
                // SQL query to get comprehensive order information
                // Joins multiple tables to get customer and product details
                // LEFT JOINs used to include orders even if car or part is null
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

                // Execute query and return results
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                // Handle any errors during report generation
                throw new Exception($"Error generating order report: {ex.Message}", ex);
            }
        }
    }
}
