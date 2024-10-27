using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public class User
    {
        private DatabaseHelper dbHelper;

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

                dbHelper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


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
