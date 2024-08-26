using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public class CarPart
    {
        private DatabaseHelper dbHelper; // Helper object for database operations

        // Properties representing car part details
        public int PartID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Constructor initializes the DatabaseHelper object
        public CarPart()
        {
            dbHelper = new DatabaseHelper();
        }

        // Method to add a new car part to the database
        public void AddCarPart(string name, string description, decimal price)
        {
            try
            {
                string query = "INSERT INTO CarParts (Name, Description, Price) " +
                               "VALUES (@Name, @Description, @Price)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Description", description),
                    new SqlParameter("@Price", price)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute the query to insert a new car part
                MessageBox.Show("Car part added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
            }
        }

        // Method to edit an existing car part's details
        public void EditCarPart(int partID, string name, string description, decimal price)
        {
            try
            {
                string query = "UPDATE CarParts SET Name = @Name, Description = @Description, Price = @Price WHERE PartID = @PartID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PartID", partID),
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Description", description),
                    new SqlParameter("@Price", price)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute the query to update car part details
                MessageBox.Show("Car part updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
            }
        }

        // Method to delete a car part from the database
        public void DeleteCarPart(int partID)
        {
            try
            {
                string query = "DELETE FROM CarParts WHERE PartID = @PartID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PartID", partID)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute the query to delete a car part
                MessageBox.Show("Car part deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
            }
        }

        // Method to get details of a specific car part
        public DataTable GetCarPartDetails(int partID)
        {
            try
            {
                string query = "SELECT * FROM CarParts WHERE PartID = @PartID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PartID", partID)
                };

                return dbHelper.ExecuteQuery(query, parameters); // Execute the query to get car part details
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return null;
            }
        }

        // Method to get details of all car parts
        public DataTable GetAllCarPartDetails()
        {
            try
            {
                string query = "SELECT * FROM CarParts";
                return dbHelper.ExecuteQuery(query); // Execute the query to get all car part details
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return null;
            }
        }
    }
}
