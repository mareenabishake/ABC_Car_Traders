using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    // Handles order processing and management for both cars and parts
    public class Order
    {
        public DatabaseHelper dbHelper;

        // Properties representing order information in the database
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set; }
        public int PartID { get; set; }
        public string OrderStatus { get; set; }

        public Order()
        {
            dbHelper = new DatabaseHelper();
        }

        private void ValidateOrder(int customerID, int? carID, int? partID, int? quantity)
        {
            if (customerID <= 0)
                throw new ValidationException("Invalid customer ID.");
            
            if (!carID.HasValue && !partID.HasValue)
                throw new ValidationException("Either car ID or part ID must be specified.");
            
            if (carID.HasValue && partID.HasValue)
                throw new ValidationException("Cannot order both car and part simultaneously.");
            
            if (partID.HasValue && (!quantity.HasValue || quantity.Value <= 0))
                throw new ValidationException("Quantity must be greater than 0 for part orders.");
        }

        public void PlaceOrder(int customerID, int? carID, int? partID, int? quantity)
        {
            try
            {
                ValidateOrder(customerID, carID, partID, quantity);

                // Verify inventory availability
                if (carID.HasValue)
                {
                    string checkCarQuery = "SELECT COUNT(*) as Count FROM Cars WHERE CarID = @CarID";
                    SqlParameter[] carParams = new SqlParameter[] {
                        new SqlParameter("@CarID", carID.Value)
                    };
                    DataTable carResult = dbHelper.ExecuteQuery(checkCarQuery, carParams);
                    int carExists = Convert.ToInt32(carResult.Rows[0]["Count"]);
                    
                    if (carExists == 0)
                        throw new ValidationException("Specified car is not available.");
                }

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
