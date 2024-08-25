using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public class Order
    {
        private DatabaseHelper dbHelper;

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set; }
        public int PartID { get; set; }
        public string OrderStatus { get; set; }

        public Order()
        {
            dbHelper = new DatabaseHelper();
        }

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

                dbHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
    }
}
