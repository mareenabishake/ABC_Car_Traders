using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    // Handles order processing and management for both cars and parts
    // Manages the complete order lifecycle including validation, creation, and status updates
    public class Order
    {
        // Database helper instance for handling all database operations
        public DatabaseHelper dbHelper;

        // Properties representing order information in the database
        public int OrderID { get; set; }          // Unique identifier for each order
        public int CustomerID { get; set; }       // ID of the customer placing the order
        public int CarID { get; set; }            // ID of the car being ordered (if applicable)
        public int PartID { get; set; }           // ID of the part being ordered (if applicable)
        public string OrderStatus { get; set; }   // Current status of the order (Pending, Completed, Cancelled)

        // Constructor initializes database connection
        public Order()
        {
            dbHelper = new DatabaseHelper();
        }

        // Validates order data before processing
        // Ensures order meets business rules and data integrity requirements
        // Throws ValidationException if validation fails
        private void ValidateOrder(int customerID, int? carID, int? partID, int? quantity)
        {
            // Ensure customer ID is valid
            if (customerID <= 0)
                throw new ValidationException("Invalid customer ID.");
            
            // Ensure either car or part is specified, but not both
            if (!carID.HasValue && !partID.HasValue)
                throw new ValidationException("Either car ID or part ID must be specified.");
            
            if (carID.HasValue && partID.HasValue)
                throw new ValidationException("Cannot order both car and part simultaneously.");
            
            // Validate quantity for part orders
            if (partID.HasValue && (!quantity.HasValue || quantity.Value <= 0))
                throw new ValidationException("Quantity must be greater than 0 for part orders.");
        }

        // Places a new order in the system
        // Handles both car and part orders with appropriate validation
        public void PlaceOrder(int customerID, int? carID, int? partID, int? quantity)
        {
            try
            {
                // Validate order data before processing
                ValidateOrder(customerID, carID, partID, quantity);

                // Verify car availability if ordering a car
                if (carID.HasValue)
                {
                    // Check if the specified car exists in inventory
                    string checkCarQuery = "SELECT COUNT(*) as Count FROM Cars WHERE CarID = @CarID";
                    SqlParameter[] carParams = new SqlParameter[] {
                        new SqlParameter("@CarID", carID.Value)
                    };
                    DataTable carResult = dbHelper.ExecuteQuery(checkCarQuery, carParams);
                    int carExists = Convert.ToInt32(carResult.Rows[0]["Count"]);
                    
                    if (carExists == 0)
                        throw new ValidationException("Specified car is not available.");
                }

                // Verify part availability if ordering a part
                if (partID.HasValue)
                {
                    string checkPartQuery = "SELECT COUNT(*) as Count FROM CarParts WHERE PartID = @PartID";
                    SqlParameter[] partParams = new SqlParameter[] {
                        new SqlParameter("@PartID", partID.Value)
                    };
                    DataTable partResult = dbHelper.ExecuteQuery(checkPartQuery, partParams);
                    int partExists = Convert.ToInt32(partResult.Rows[0]["Count"]);
                    
                    if (partExists == 0)
                        throw new ValidationException("Specified part is not available.");
                }

                string query = "INSERT INTO Orders (CustomerID, CarID, PartID, Quantity, OrderStatus) " +
                               "VALUES (@CustomerID, @CarID, @PartID, @Quantity, 'Pending')";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CustomerID", customerID),
                    new SqlParameter("@CarID", carID.HasValue ? (object)carID.Value : DBNull.Value),
                    new SqlParameter("@PartID", partID.HasValue ? (object)partID.Value : DBNull.Value),
                    new SqlParameter("@Quantity", partID.HasValue ? (object)(quantity ?? 1) : DBNull.Value)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
            }
            catch (ValidationException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error placing order: {ex.Message}", ex);
            }
        }

        // Updates the status of an existing order (e.g., Pending, Completed, Cancelled)
        public void UpdateOrder(int orderID, string orderStatus)
        {
            try
            {
                string query = "UPDATE Orders SET OrderStatus = @OrderStatus WHERE OrderID = @OrderID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderID", orderID),
                    new SqlParameter("@OrderStatus", orderStatus)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Order status updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Removes an order from the system
        public void DeleteOrder(int orderID)
        {
            try
            {
                string query = "DELETE FROM Orders WHERE OrderID = @OrderID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderID", orderID)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Order deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Retrieves the current status of a specific order
        public string GetOrderStatus(int orderID)
        {
            try
            {
                string query = "SELECT OrderStatus FROM Orders WHERE OrderID = @OrderID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderID", orderID)
                };

                DataTable dt = dbHelper.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["OrderStatus"].ToString();
                }
                else
                {
                    MessageBox.Show("Order not found.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }


        public DataTable GetOrderDetails(int orderID)
        {
            try
            {
                string query = "SELECT * FROM Orders WHERE OrderID = @OrderID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderID", orderID)
                };

                return dbHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable GetAllOrderDetails()
        {
            try
            {
                string query = "SELECT * FROM Orders";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable GetCustomerOrderDetails(int customerID)
        {
            try
            {
                string query = "SELECT OrderID, CarID, PartID, Quantity, OrderStatus FROM Orders WHERE CustomerID = @CustomerID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CustomerID", customerID)
                };

                return dbHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
