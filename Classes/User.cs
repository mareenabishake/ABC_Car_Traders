using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ABC_Car_Traders
{
    // Manages user-related operations including authentication, registration, and profile management.
    // This class handles all user data operations and validation for the ABC Car Traders system.
    public class User
    {
        // Database helper instance for handling all database operations
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

        // Initializes a new instance of the User class and creates a database helper connection.
        public User()
        {
            dbHelper = new DatabaseHelper();
        }

        // Validates user input data against business rules and formatting requirements.
        // Throws ValidationException if any validation fails.
        // Parameters:
        // - username: Must be at least 3 characters
        // - password: Must be at least 6 characters
        // - name: User's full name
        // - email: Must be in valid email format
        // - phone: Must be exactly 10 digits
        private void ValidateUserData(string username, string password, string name, string email, string phone)
        {
            // Validate username length and content
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
                throw new ValidationException("Username must be at least 3 characters long.");
            
            // Ensure password meets minimum security requirements
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                throw new ValidationException("Password must be at least 6 characters long.");
            
            // Verify name is provided
            if (string.IsNullOrWhiteSpace(name))
                throw new ValidationException("Name is required.");
            
            // Validate email format using regex pattern
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                throw new ValidationException("Invalid email format.");
            
            // Ensure phone number contains exactly 10 digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$"))
                throw new ValidationException("Phone number must be 10 digits.");
        }

        // Registers a new customer in the system after validating their information.
        // Performs duplicate username check before insertion.
        // Returns true if registration is successful, false otherwise
        public bool Register(string username, string password, string name, string email, string phone, string address)
        {
            try
            {
                // Validate all user input before proceeding
                ValidateUserData(username, password, name, email, phone);

                // Check for existing username to prevent duplicates
                string checkQuery = "SELECT COUNT(*) as Count FROM Users WHERE Username = @Username";
                SqlParameter[] checkParams = new SqlParameter[] {
                    new SqlParameter("@Username", username)
                };
                
                // Execute query and get result
                DataTable result = dbHelper.ExecuteQuery(checkQuery, checkParams);
                int existingCount = Convert.ToInt32(result.Rows[0]["Count"]);
                
                // Throw exception if username already exists
                if (existingCount > 0)
                    throw new ValidationException("Username already exists.");

                // Prepare insert query with all user details
                string insertQuery = "INSERT INTO Users (Username, Password, Name, Email, Phone, Address, UserType) " +
                                   "VALUES (@Username, @Password, @Name, @Email, @Phone, @Address, 'Customer')";
                
                // Set up parameters for the insert query
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Address", address)
                };

                // Execute the insert query
                dbHelper.ExecuteNonQuery(insertQuery, parameters);
                return true;
            }
            catch (ValidationException ex)
            {
                // Handle validation errors separately with a warning message
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                // Handle all other errors with an error message
                MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Authenticates user credentials and loads user profile data if successful.
        // Populates all user properties from database if authentication passes.
        // Returns true if login successful, false otherwise
        public bool Login(string username, string password)
        {
            try
            {
                // Prepare query to check credentials
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password)
                };

                // Execute query and check if user exists
                DataTable dt = dbHelper.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    // User found - populate user properties from database
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
                // No matching user found
                return false;
            }
            catch (Exception ex)
            {
                // Handle any database or conversion errors
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Updates existing customer information in the database.
        // Only allows updates to customer accounts (UserType = 'Customer').
        // Returns true if update successful, false if error occurs
        public bool EditCustomer(int customerId, string name, string email, string phone, string address)
        {
            try
            {
                // Prepare update query - only for customer type users
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address " +
                             "WHERE UserID = @UserID AND UserType = 'Customer'";
                
                // Set up parameters for the update
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@UserID", customerId),
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Address", address)
                };

                // Execute the update query
                dbHelper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                // Handle any errors during update
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Permanently removes a customer account from the system.
        // Only allows deletion of customer accounts (UserType = 'Customer').
        // Returns true if deletion successful, false if error occurs
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

        // Retrieves detailed information for a specific customer.
        // Returns null if customer not found or error occurs.
        // Returns: DataTable containing customer information or null
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

        // Retrieves a list of all customers in the system.
        // Filters for UserType = 'Customer' only.
        // Returns: DataTable containing all customer records or null if error occurs
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

        // Clears all current user session data and resets properties to default values.
        // Should be called when user logs out of the system.
        public void Logout()
        {
            // Reset all user properties to their default values
            UserID = 0;
            Username = null;
            Password = null;
            Name = null;
            Email = null;
            Phone = null;
            Address = null;
            UserType = null;
        }
    }
}
