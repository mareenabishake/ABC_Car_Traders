using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public class Car
    {
        private DatabaseHelper dbHelper; // Helper object for database operations

        // Properties representing car details
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        // Constructor initializes the DatabaseHelper object
        public Car()
        {
            dbHelper = new DatabaseHelper();
        }

        // Method to add a new car to the database
        public void AddCar(string make, string model, int year, decimal price)
        {
            try
            {
                string query = "INSERT INTO Cars (Make, Model, Year, Price) " +
                               "VALUES (@Make, @Model, @Year, @Price)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Make", make),
                    new SqlParameter("@Model", model),
                    new SqlParameter("@Year", year),
                    new SqlParameter("@Price", price)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute the query to insert a new car
                MessageBox.Show("Car added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
            }
        }

        // Method to edit an existing car's details
        public void EditCar(int carID, string make, string model, int year, decimal price)
        {
            try
            {
                string query = "UPDATE Cars SET Make = @Make, Model = @Model, Year = @Year, Price = @Price WHERE CarID = @CarID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CarID", carID),
                    new SqlParameter("@Make", make),
                    new SqlParameter("@Model", model),
                    new SqlParameter("@Year", year),
                    new SqlParameter("@Price", price)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute the query to update car details
                MessageBox.Show("Car updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
            }
        }

        // Method to delete a car from the database
        public void DeleteCar(int carID)
        {
            try
            {
                string query = "DELETE FROM Cars WHERE CarID = @CarID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CarID", carID)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute the query to delete a car
                MessageBox.Show("Car deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
            }
        }

        // Method to get details of a specific car
        public DataTable GetCarDetails(int carID)
        {
            try
            {
                string query = "SELECT * FROM Cars WHERE CarID = @CarID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CarID", carID)
                };

                return dbHelper.ExecuteQuery(query, parameters); // Execute the query to get car details
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return null;
            }
        }

        // Method to get details of all cars
        public DataTable GetAllCarDetails()
        {
            try
            {
                string query = "SELECT * FROM Cars";
                return dbHelper.ExecuteQuery(query); // Execute the query to get all car details
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return null;
            }
        }
    }
}
