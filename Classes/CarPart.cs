using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    // Manages inventory and operations for car parts
    public class CarPart
    {
        private DatabaseHelper dbHelper;

        // Properties representing car part information in the database
        public int PartID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public CarPart()
        {
            dbHelper = new DatabaseHelper();
        }

        private void ValidatePartData(string name, string description, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ValidationException("Part name is required.");
                
            if (string.IsNullOrWhiteSpace(description))
                throw new ValidationException("Part description is required.");
                
            if (price <= 0)
                throw new ValidationException("Price must be greater than 0.");
        }

        public void AddCarPart(string name, string description, decimal price)
        {
            try
            {
                ValidatePartData(name, description, price);

                // Check if part exists using ExecuteQuery
                string checkQuery = "SELECT COUNT(*) as Count FROM CarParts WHERE Name = @Name";
                SqlParameter[] checkParams = new SqlParameter[] {
                    new SqlParameter("@Name", name)
                };
                
                DataTable result = dbHelper.ExecuteQuery(checkQuery, checkParams);
                int existingCount = Convert.ToInt32(result.Rows[0]["Count"]);
                
                if (existingCount > 0)
                    throw new ValidationException("A part with this name already exists.");

                string query = "INSERT INTO CarParts (Name, Description, Price) " +
                               "VALUES (@Name, @Description, @Price)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Description", description),
                    new SqlParameter("@Price", price)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car part added successfully!");
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add part: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car part updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteCarPart(int partID)
        {
            try
            {
                string query = "DELETE FROM CarParts WHERE PartID = @PartID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PartID", partID)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car part deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable GetCarPartDetails(int partID)
        {
            try
            {
                string query = "SELECT * FROM CarParts WHERE PartID = @PartID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PartID", partID)
                };

                return dbHelper.ExecuteQuery(query, parameters);
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
