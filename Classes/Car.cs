﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ABC_Car_Traders.Classes.Utilities;

namespace ABC_Car_Traders
{
    // Manages vehicle inventory and related operations
    public class Car
    {
        private DatabaseHelper dbHelper;

        // Properties representing car information in the database
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            dbHelper = new DatabaseHelper();
        }

        private void ValidateCarData(string make, string model, int year, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ValidationException("Make is required.");
                
            if (string.IsNullOrWhiteSpace(model))
                throw new ValidationException("Model is required.");
                
            if (year < 1900 || year > DateTime.Now.Year + 1)
                throw new ValidationException("Invalid year.");
                
            if (price <= 0)
                throw new ValidationException("Price must be greater than 0.");
        }

        // Adds a new vehicle to the inventory
        public void AddCar(string make, string model, int year, decimal price)
        {
            try
            {
                ValidateCarData(make, model, year, price);

                // Check if identical car exists
                string checkQuery = "SELECT COUNT(*) FROM Cars WHERE Make = @Make AND Model = @Model AND Year = @Year";
                SqlParameter[] checkParams = new SqlParameter[] {
                    new SqlParameter("@Make", make),
                    new SqlParameter("@Model", model),
                    new SqlParameter("@Year", year)
                };
                int existingCount = Convert.ToInt32(dbHelper.ExecuteScalar(checkQuery, checkParams));
                
                if (existingCount > 0)
                    throw new ValidationException("This car model already exists in inventory.");

                string query = "INSERT INTO Cars (Make, Model, Year, Price) " +
                               "VALUES (@Make, @Model, @Year, @Price)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Make", make),
                    new SqlParameter("@Model", model),
                    new SqlParameter("@Year", year),
                    new SqlParameter("@Price", price)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car added successfully!");
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Updates existing vehicle information
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

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Removes a vehicle from the inventory
        public void DeleteCar(int carID)
        {
            try
            {
                string query = "DELETE FROM Cars WHERE CarID = @CarID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CarID", carID)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Retrieval methods for vehicle information
        public DataTable GetCarDetails(int carID)
        {
            try
            {
                string query = "SELECT * FROM Cars WHERE CarID = @CarID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CarID", carID)
                };

                return dbHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable GetAllCarDetails()
        {
            try
            {
                string query = "SELECT * FROM Cars";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
