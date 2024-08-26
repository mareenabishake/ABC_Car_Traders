using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Classes.Utilities
{
    public class ReportGenerator
    {
        private DatabaseHelper dbHelper; // Helper object to interact with the database

        // Constructor initializes the DatabaseHelper object
        public ReportGenerator()
        {
            dbHelper = new DatabaseHelper();
        }

        // Generates a report for car inventory
        public DataTable GenerateCarInventoryReport()
        {
            string query = "SELECT * FROM Cars"; // SQL query to select all cars
            return dbHelper.ExecuteQuery(query); // Executes the query and returns the result as a DataTable
        }

        // Generates a report for customers
        public DataTable GenerateCustomerReport()
        {
            string query = "SELECT * FROM Users WHERE UserType = 'Customer'"; // SQL query to select all customers
            return dbHelper.ExecuteQuery(query); // Executes the query and returns the result as a DataTable
        }

        // Generates a report for car parts inventory
        public DataTable GenerateCarPartInventoryReport()
        {
            string query = "SELECT * FROM CarParts"; // SQL query to select all car parts
            return dbHelper.ExecuteQuery(query); // Executes the query and returns the result as a DataTable
        }
    }
}
