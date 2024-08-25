using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public class Car
    {
        private DatabaseHelper dbHelper;

        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            dbHelper = new DatabaseHelper();
        }

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

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Car added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
