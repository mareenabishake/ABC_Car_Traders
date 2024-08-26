using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public class Order
    {
        private DatabaseHelper dbHelper; // Helper object for database operations

        // Properties representing order details
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set; }
        public int PartID { get; set; }
        public string OrderStatus { get; set; }

        // Constructor initializes the DatabaseHelper object
        public Order()
        {
            dbHelper = new DatabaseHelper();
        }

        // Method to place a new order in the database
        public void PlaceOrder(int customerID, int? carID, int? partID, int? quantity)
        {
            try
            {
                string query = "INSERT INTO Orders (CustomerID, CarID, PartID, Quantity, OrderStatus) " +
                               "VALUES (@CustomerID, @CarID, @PartID, @Quantity, 'Pending')";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CustomerID", customerID),
                    new SqlParameter("@CarID", carID.HasValue ? (object)carID.Value : DBNull.Value),
                    new SqlParameter("@PartID", partID.HasValue ? (object)partID.Value : DBNull.Value),
                    new SqlParameter("@Quantity", partID.HasValue ? (object)(quantity ?? 1) : DBNull.Value)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute query to insert a new order
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
            }
        }

        // Method to update the status of an existing order
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

                dbHelper.ExecuteNonQuery(query, parameters); // Execute query to update order status
                MessageBox.Show("Order status updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
            }
        }

        // Method to delete an order from the database
        public void DeleteOrder(int orderID)
        {
            try
            {
                string query = "DELETE FROM Orders WHERE OrderID = @OrderID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderID", orderID)
                };

                dbHelper.ExecuteNonQuery(query, parameters); // Execute query to delete an order
                MessageBox.Show("Order deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
            }
        }

        // Method to retrieve the status of a specific order
        public string GetOrderStatus(int orderID)
        {
            try
            {
                string query = "SELECT OrderStatus FROM Orders WHERE OrderID = @OrderID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderID", orderID)
                };

                DataTable dt = dbHelper.ExecuteQuery(query, parameters); // Execute query to get order status
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["OrderStatus"].ToString(); // Return order status if found
                }
                else
                {
                    MessageBox.Show("Order not found.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return string.Empty;
            }
        }

        // Method to get details of a specific order
        public DataTable GetOrderDetails(int orderID)
        {
            try
            {
                string query = "SELECT * FROM Orders WHERE OrderID = @OrderID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderID", orderID)
                };

                return dbHelper.ExecuteQuery(query, parameters); // Execute query to get order details
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return null;
            }
        }

        // Method to get details of all orders
        public DataTable GetAllOrderDetails()
        {
            try
            {
                string query = "SELECT * FROM Orders";
                return dbHelper.ExecuteQuery(query); // Execute query to get all order details
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message in case of an exception
                return null;
            }
        }
    }
}
