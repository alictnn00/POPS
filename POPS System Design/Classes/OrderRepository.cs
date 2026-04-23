using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPS_System_Design.Classes
{
    public class OrderRepository
    {
        //Create a connection to the database
        private DatabaseConnection db = new DatabaseConnection();

        //Method for retrieving all customers from the database
        public List<Customer> GetAllCustomers()
        {
            List<Customer> list = new List<Customer>();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT custID, firstName, lastName FROM DbCustomer";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Customer
                        {
                            CustomerID = reader.GetInt32("custID"),
                            FirstName = reader.GetString("firstName"),
                            LastName = reader.GetString("lastName")
                        });
                    }
                }
            }
            return list;
        }

        //Method for inserting a new order into the database
        public int CreateOrder(int custID, int? empID)
        {
            int orderID;

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO DbOrder (custID, empID, orderDate, status)
                VALUES (@CustID, @EmpID, @Date, @Status);
                SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustID", custID);
                    cmd.Parameters.AddWithValue("@EmpID", (object)empID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Status", "Pending");

                    orderID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return orderID;
        }

        //Method for inserting order details into the database
        public void AddOrderDetail(int orderID, int productID, decimal unitPrice, int quantity)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO DbOrderDetails 
                (orderID, productID, unitPrice, quantityOrdered, salesTax, totalPrice)
                VALUES (@OrderID, @ProductID, @Price, @Qty, @Tax, @Total)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    decimal tax = unitPrice * quantity * 0.07m; // 7% tax
                    decimal total = (unitPrice * quantity) + tax;

                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@Price", unitPrice);
                    cmd.Parameters.AddWithValue("@Qty", quantity);
                    cmd.Parameters.AddWithValue("@Tax", tax);
                    cmd.Parameters.AddWithValue("@Total", total);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<OrderView> GetAllOrders()
        {
            List<OrderView> list = new List<OrderView>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT o.orderID,
                       CONCAT(c.firstName, ' ', c.lastName) AS customerName,
                       e.name AS salesmanName,
                       o.orderDate,
                       o.status
                FROM DbOrder o
                JOIN DbCustomer c ON o.custID = c.custID
                LEFT JOIN DbEmployee e ON o.empID = e.empID
                ORDER BY o.orderID DESC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new OrderView
                        {
                            OrderID = reader.GetInt32("orderID"),
                            CustomerName = reader.GetString("customerName"),
                            SalesmanName = reader["salesmanName"]?.ToString(),
                            OrderDate = reader.GetDateTime("orderDate"),
                            Status = reader.GetString("status")
                        });
                    }
                }
            }

            return list;
        }

        //Method for retrieving order details based on selected Order's Order ID
        public List<OrderDetailView> GetOrderDetails(int orderID)
        {
            List<OrderDetailView> list = new List<OrderDetailView>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT d.productID,
                       p.productName,
                       d.unitPrice,
                       d.quantityOrdered,
                       d.totalPrice
                FROM DbOrderDetails d
                JOIN DbProduct p ON d.productID = p.productID
                WHERE d.orderID = @OrderID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new OrderDetailView
                            {
                                ProductID = reader.GetInt32("productID"),
                                ProductName = reader.GetString("productName"),
                                UnitPrice = reader.GetDecimal("unitPrice"),
                                Quantity = reader.GetInt32("quantityOrdered"),
                                Total = reader.GetDecimal("totalPrice")
                            });
                        }
                    }
                }
            }

            return list;
        }

        //Method for searching orders based on Order ID or Customer Name
        public List<OrderView> SearchOrders(string searchType, string keyword)
        {
            List<OrderView> list = new List<OrderView>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT o.orderID,
                       CONCAT(c.firstName, ' ', c.lastName) AS customerName,
                       e.name AS salesmanName,
                       o.orderDate,
                       o.status
                FROM DbOrder o
                JOIN DbCustomer c ON o.custID = c.custID
                LEFT JOIN DbEmployee e ON o.empID = e.empID
                WHERE ";

                if (searchType == "Order ID")
                {
                    query += "o.orderID = @Keyword";
                }
                else if (searchType == "Customer Name")
                {
                    query += "CONCAT(c.firstName, ' ', c.lastName) LIKE @Keyword";
                }

                query += " ORDER BY o.orderID DESC";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (searchType == "Order ID")
                        cmd.Parameters.AddWithValue("@Keyword", int.Parse(keyword));
                    else
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new OrderView
                            {
                                OrderID = reader.GetInt32("orderID"),
                                CustomerName = reader.GetString("customerName"),
                                SalesmanName = reader["salesmanName"]?.ToString(),
                                OrderDate = reader.GetDateTime("orderDate"),
                                Status = reader.GetString("status")
                            });
                        }
                    }
                }
            }

            return list;
        }

    }
}
