using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public class User
    {
        private DatabaseHelper dbHelper; // Helper object for database operations

        // Properties representing user details
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; } // Admin or Customer

        // Constructor initializes the DatabaseHelper object
        public User()
        {
            dbHelper = new DatabaseHelper();
        }

        // Method to register a new customer in the database
        public bool Register(string username, string password, string name, string email, string phone, string address)
        {
            try
            {
                string query = "INSERT INTO Users (Username, Password, Name, Email, Phone, Address, UserType) " +
                               "VALUES (@Username, @Password, @Name, @Email, @Phone, @Address, 'Customer')";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Address", address)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute query to insert a new customer
                return true; // Return true if the registration is successful
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return false; // Return false if an error occurs
            }
        }

        // Method to log in a user
        public bool Login(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password)
                };

                DataTable dt = dbHelper.ExecuteQuery(query, parameters); // Execute query to check user credentials
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    this.UserID = Convert.ToInt32(row["UserID"]);
                    this.Username = row["Username"].ToString();
                    this.Name = row["Name"].ToString();
                    this.Email = row["Email"].ToString();
                    this.UserType = row["UserType"].ToString();
                    return true; // Return true if login is successful
                }

                return false; // Return false if no matching user is found
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return false; // Return false if an error occurs
            }
        }

        // Method to edit an existing customer's details
        public bool EditCustomer(int customerId, string name, string email, string phone, string address)
        {
            try
            {
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address WHERE UserID = @UserID AND UserType = 'Customer'";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@UserID", customerId),
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Address", address)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute query to update customer details
                return true; // Return true if the update is successful
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return false; // Return false if an error occurs
            }
        }

        // Method to delete a customer from the database
        public bool DeleteCustomer(int customerId)
        {
            try
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID AND UserType = 'Customer'";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@UserID", customerId)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute query to delete a customer
                return true; // Return true if the delete is successful
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return false; // Return false if an error occurs
            }
        }

        // Method to get details of a specific customer
        public DataTable GetCustomerDetails(int customerID)
        {
            try
            {
                string query = "SELECT * FROM Users WHERE UserID = @UserID AND UserType = 'Customer'";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@UserID", customerID)
                };

                return dbHelper.ExecuteQuery(query, parameters); // Execute query to get customer details
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return null; // Return null if an error occurs
            }
        }

        // Method to get details of all customers
        public DataTable GetAllCustomerDetails()
        {
            try
            {
                string query = "SELECT * FROM Users WHERE UserType = 'Customer'";
                return dbHelper.ExecuteQuery(query); // Execute query to get all customer details
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return null; // Return null if an error occurs
            }
        }
    }
}
