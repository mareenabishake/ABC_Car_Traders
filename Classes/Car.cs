using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ABC_Car_Traders
{
    // Manages vehicle inventory and related operations in the ABC Car Traders system
    // Handles CRUD operations for car inventory and validation of car data
    public class Car
    {
        // Database helper instance for handling all database operations
        private DatabaseHelper dbHelper;

        // Properties representing car information in the database
        public int CarID { get; set; }        // Unique identifier for each car
        public string Make { get; set; }      // Manufacturer of the car
        public string Model { get; set; }     // Model name of the car
        public int Year { get; set; }         // Manufacturing year
        public decimal Price { get; set; }    // Sale price of the car

        // Constructor initializes database connection
        public Car()
        {
            dbHelper = new DatabaseHelper();
        }

        // Validates car data before database operations
        // Throws ValidationException if any validation fails
        private void ValidateCarData(string make, string model, int year, decimal price)
        {
            // Ensure make is provided
            if (string.IsNullOrWhiteSpace(make))
                throw new ValidationException("Make is required.");
            
            // Ensure model is provided    
            if (string.IsNullOrWhiteSpace(model))
                throw new ValidationException("Model is required.");
            
            // Validate year is within reasonable range
            // Allows for current year plus one for newer models
            if (year < 1900 || year > DateTime.Now.Year + 1)
                throw new ValidationException("Invalid year.");
            
            // Ensure price is positive
            if (price <= 0)
                throw new ValidationException("Price must be greater than 0.");
        }

        // Adds a new vehicle to the inventory
        // Performs validation and checks for duplicates before insertion
        public void AddCar(string make, string model, int year, decimal price)
        {
            try
            {
                // Validate all input data
                ValidateCarData(make, model, year, price);

                // Check if identical car exists using ExecuteQuery
                string checkQuery = "SELECT COUNT(*) as Count FROM Cars WHERE Make = @Make AND Model = @Model AND Year = @Year";
                SqlParameter[] checkParams = new SqlParameter[] {
                    new SqlParameter("@Make", make),
                    new SqlParameter("@Model", model),
                    new SqlParameter("@Year", year)
                };
                
                // Execute the check query and get result
                DataTable result = dbHelper.ExecuteQuery(checkQuery, checkParams);
                int existingCount = Convert.ToInt32(result.Rows[0]["Count"]);
                
                // Prevent duplicate entries
                if (existingCount > 0)
                    throw new ValidationException("This car model already exists in inventory.");

                // Prepare insert query with all car details
                string insertQuery = "INSERT INTO Cars (Make, Model, Year, Price) VALUES (@Make, @Model, @Year, @Price)";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Make", make),
                    new SqlParameter("@Model", model),
                    new SqlParameter("@Year", year),
                    new SqlParameter("@Price", price)
                };

                // Execute the insert operation
                dbHelper.ExecuteNonQuery(insertQuery, parameters);
                MessageBox.Show("Car added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                // Handle validation errors with appropriate message
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Handle any other errors that might occur
                MessageBox.Show($"Failed to add car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Updates existing vehicle information
        // Validates data before performing update
        public void EditCar(int carID, string make, string model, int year, decimal price)
        {
            try
            {
                // Validate all input data
                ValidateCarData(make, model, year, price);

                // Prepare update query
                string query = "UPDATE Cars SET Make = @Make, Model = @Model, Year = @Year, Price = @Price WHERE CarID = @CarID";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@CarID", carID),
                    new SqlParameter("@Make", make),
                    new SqlParameter("@Model", model),
                    new SqlParameter("@Year", year),
                    new SqlParameter("@Price", price)
                };

                // Execute the update operation
                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                // Handle validation errors
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Handle any other errors
                MessageBox.Show($"Failed to update car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Removes a vehicle from the inventory
        // Deletes the car record permanently from database
        public void DeleteCar(int carID)
        {
            try
            {
                // Prepare delete query
                string query = "DELETE FROM Cars WHERE CarID = @CarID";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@CarID", carID)
                };

                // Execute the delete operation
                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors during deletion
                MessageBox.Show($"Failed to delete car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Retrieves vehicle information based on ID or name
        // Returns filtered results or all cars if no filters provided
        public DataTable GetCarDetails(int? carID = null, string carName = null)
        {
            try
            {
                // Start with base query
                string query = "SELECT * FROM Cars WHERE 1=1";
                List<SqlParameter> parameters = new List<SqlParameter>();

                // Add CarID filter if provided
                if (carID.HasValue)
                {
                    query += " AND CarID = @CarID";
                    parameters.Add(new SqlParameter("@CarID", carID.Value));
                }

                // Add name search filter if provided
                if (!string.IsNullOrEmpty(carName))
                {
                    query += " AND (Make LIKE @CarName OR Model LIKE @CarName)";
                    parameters.Add(new SqlParameter("@CarName", "%" + carName + "%"));
                }

                // Execute query and return results
                return dbHelper.ExecuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                // Handle any errors during retrieval
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Retrieves all vehicles in the inventory
        // Returns complete list of cars without any filtering
        public DataTable GetAllCarDetails()
        {
            try
            {
                // Simple query to get all cars
                string query = "SELECT * FROM Cars";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                // Handle any errors during retrieval
                MessageBox.Show($"Failed to retrieve car details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
