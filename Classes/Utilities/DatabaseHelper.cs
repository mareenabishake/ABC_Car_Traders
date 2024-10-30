using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    // Provides centralized database access and operations for the application
    public class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper()
        {
            // Set your connection string directly in the class
            connectionString = "Data Source=EXPERTBOOK\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders;Integrated Security=True;";
        }

        // Executes SQL queries that return data (SELECT statements)
        // Optional parameters allow for parameterized queries
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                // Create a new connection using the connection string
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Create a new command with the provided query and connection
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add any parameters if they were provided
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        // Create a data adapter to fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Create and fill a new DataTable with the query results
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle specific SQL Server related errors
                throw new Exception($"Database error occurred: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                throw new Exception($"An error occurred while executing the query: {ex.Message}", ex);
            }
        }

        // Executes SQL commands that modify data (INSERT, UPDATE, DELETE statements)
        // Optional parameters allow for parameterized queries
        public void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                // Create a new connection using the connection string
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Create a new command with the provided query and connection
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add any parameters if they were provided
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        // Open the connection (required for ExecuteNonQuery)
                        conn.Open();
                        
                        // Execute the command (INSERT, UPDATE, or DELETE)
                        cmd.ExecuteNonQuery();
                    }
                    // Connection automatically closes when the using block ends
                }
            }
            catch (SqlException ex)
            {
                // Handle specific SQL Server related errors
                throw new Exception($"Database error occurred: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                throw new Exception($"An error occurred while executing the command: {ex.Message}", ex);
            }
        }
    }
}
