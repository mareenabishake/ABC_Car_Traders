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
        private DatabaseHelper dbHelper;

        public ReportGenerator()
        {
            dbHelper = new DatabaseHelper();
        }

        public DataTable GenerateCarInventoryReport()
        {
            string query = "SELECT * FROM Cars";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GenerateCustomerReport()
        {
            string query = "SELECT * FROM Users WHERE UserType = 'Customer'";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GenerateCarPartInventoryReport()
        {
            string query = "SELECT * FROM CarParts"; 
            return dbHelper.ExecuteQuery(query);
        }
    }
}
