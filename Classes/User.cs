using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ABC_Car_Traders
{
    // Manages user-related operations including authentication, registration, and profile management
    public class User
    {
        private DatabaseHelper dbHelper;

        // Properties representing user information in the database
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserType { get; set; } // Admin or Customer

        public User()
        {
            dbHelper = new DatabaseHelper();
        }

        private void ValidateUserData(string username, string password, string name, string email, string phone)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
                throw new ValidationException("Username must be at least 3 characters long.");
            
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                throw new ValidationException("Password must be at least 6 characters long.");
            
            if (string.IsNullOrWhiteSpace(name))
                throw new ValidationException("Name is required.");
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                throw new ValidationException("Invalid email format.");
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$"))
                throw new ValidationException("Phone number must be 10 digits.");
        }

        // Registers a new customer in the system with basic information
        public bool Register(string username, string password, string name, string email, string phone, string address)
        {
            try
            {
                ValidateUserData(username, password, name, email, phone);

                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlParameter[] checkParams = new SqlParameter[] { new SqlParameter("@Username", username) };
                int existingCount = Convert.ToInt32(dbHelper.ExecuteScalar(checkQuery, checkParams));
                
                if (existingCount > 0)
                    throw new ValidationException("Username already exists.");

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

                dbHelper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // Authenticates user credentials and loads user data if successful
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

                DataTable dt = dbHelper.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    this.UserID = Convert.ToInt32(row["UserID"]);
                    this.Username = row["Username"].ToString();
                    this.Name = row["Name"].ToString();
                    this.Email = row["Email"].ToString();
                    this.Phone = row["Phone"].ToString();
                    this.Address = row["Address"].ToString();
                    this.UserType = row["UserType"].ToString();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Updates customer information in the database
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

                dbHelper.ExecuteNonQuery(query, parameters);
                return true; // Return true if the update is successful
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; // Return false if an error occurs
            }
        }

        // Removes a customer account from the system
        public bool DeleteCustomer(int customerId)
        {
            try
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID AND UserType = 'Customer'";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@UserID", customerId)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
                return true; // Return true if the delete is successful
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; // Return false if an error occurs
            }
        }


        // Retrieves detailed information for a specific customer
        public DataTable GetCustomerDetails(int customerID)
        {
            try
            {
                string query = "SELECT * FROM Users WHERE UserID = @UserID AND UserType = 'Customer'";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@UserID", customerID)
                };

                return dbHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Retrieves a list of all customers in the system
        public DataTable GetAllCustomerDetails()
        {
            try
            {
                string query = "SELECT * FROM Users WHERE UserType = 'Customer'";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Clears current user session data
        public void Logout()
        {
            // Reset all user properties
            UserID = 0;
            Username = null;
            Password = null;
            Name = null;
            Email = null;
            UserType = null;
        }
    }
}
