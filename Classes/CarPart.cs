using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public class CarPart
    {
        private DatabaseHelper dbHelper;

        public int PartID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public CarPart()
        {
            dbHelper = new DatabaseHelper();
        }

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

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car part added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
