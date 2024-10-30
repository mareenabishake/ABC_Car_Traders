using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ABC_Car_Traders
{
    // Manages inventory and operations for car parts
    // Handles CRUD operations and validation for the parts inventory system
    public class CarPart
    {
        // Database helper instance for handling all database operations
        private DatabaseHelper dbHelper;

        // Properties representing car part information in the database
        public int PartID { get; set; }          // Unique identifier for each part
        public string Name { get; set; }         // Name/title of the part
        public string Description { get; set; }  // Detailed description of the part
        public decimal Price { get; set; }       // Sale price of the part

        // Constructor initializes database connection
        public CarPart()
        {
            dbHelper = new DatabaseHelper();
        }

        // Validates part data before database operations
        // Throws ValidationException if any validation fails
        private void ValidatePartData(string name, string description, decimal price)
        {
            // Ensure part name is provided
            if (string.IsNullOrWhiteSpace(name))
                throw new ValidationException("Part name is required.");
            
            // Ensure description is provided    
            if (string.IsNullOrWhiteSpace(description))
                throw new ValidationException("Part description is required.");
            
            // Ensure price is positive
            if (price <= 0)
                throw new ValidationException("Price must be greater than 0.");
        }

        // Adds a new part to the inventory
        // Performs validation and checks for duplicates before insertion
        public void AddCarPart(string name, string description, decimal price)
        {
            try
            {
                // Validate all input data
                ValidatePartData(name, description, price);

                // Check if part with same name exists
                string checkQuery = "SELECT COUNT(*) as Count FROM CarParts WHERE Name = @Name";
                SqlParameter[] checkParams = new SqlParameter[] {
                    new SqlParameter("@Name", name)
                };
                
                // Execute the check query and get result
                DataTable result = dbHelper.ExecuteQuery(checkQuery, checkParams);
                int existingCount = Convert.ToInt32(result.Rows[0]["Count"]);
                
                // Prevent duplicate entries
                if (existingCount > 0)
                    throw new ValidationException("A part with this name already exists.");

                // Prepare insert query with all part details
                string query = "INSERT INTO CarParts (Name, Description, Price) VALUES (@Name, @Description, @Price)";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Description", description),
                    new SqlParameter("@Price", price)
                };

                // Execute the insert operation
                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car part added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                // Handle validation errors with appropriate message
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Handle any other errors that might occur
                MessageBox.Show($"Failed to add part: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Updates existing part information
        // Validates data before performing update
        public void EditCarPart(int partID, string name, string description, decimal price)
        {
            try
            {
                // Validate all input data
                ValidatePartData(name, description, price);

                // Prepare update query
                string query = "UPDATE CarParts SET Name = @Name, Description = @Description, Price = @Price WHERE PartID = @PartID";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@PartID", partID),
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Description", description),
                    new SqlParameter("@Price", price)
                };

                // Execute the update operation
                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car part updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                // Handle validation errors
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Handle any other errors
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Removes a part from the inventory
        // Deletes the part record permanently from database
        public void DeleteCarPart(int partID)
        {
            try
            {
                // Prepare delete query
                string query = "DELETE FROM CarParts WHERE PartID = @PartID";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@PartID", partID)
                };

                // Execute the delete operation
                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car part deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors during deletion
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Retrieves part information based on ID or name
        // Returns filtered results or all parts if no filters provided
        public DataTable GetCarPartDetails(int? partID = null, string partName = null)
        {
            try
            {
                // Start with base query
                string query = "SELECT * FROM CarParts WHERE 1=1";
                List<SqlParameter> parameters = new List<SqlParameter>();

                // Add PartID filter if provided
                if (partID.HasValue)
                {
                    query += " AND PartID = @PartID";
                    parameters.Add(new SqlParameter("@PartID", partID.Value));
                }

                // Add name search filter if provided
                if (!string.IsNullOrEmpty(partName))
                {
                    query += " AND Name LIKE @PartName";
                    parameters.Add(new SqlParameter("@PartName", "%" + partName + "%"));
                }

                return dbHelper.ExecuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable GetAllCarPartDetails()
        {
            try
            {
                string query = "SELECT * FROM CarParts";
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
