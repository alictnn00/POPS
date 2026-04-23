using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPS_System_Design.Classes
{
    public class ProductRepository
    {
        //Create a connection instance to the database
        private DatabaseConnection db = new DatabaseConnection();

        //Method for retrieving all products from the database
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection conn = db.GetConnection())
            {
                //Open the connection to the database
                conn.Open();

                //Query to select all products from the DbProduct table
                string query = "SELECT productID, productName, price, inventoryAmount FROM DbProduct";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            ProductID = reader.GetInt32("productID"),
                            ProductName = reader.GetString("productName"),
                            Price = reader.GetDecimal("price"),
                            InventoryAmount = reader.GetInt32("inventoryAmount")
                        });
                    }
                }
            }

            return products;
        }

        //Method for searching products based on Search Type
        public List<Product> SearchProducts(string searchType, string keyword)
        {
            List<Product> list = new List<Product>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT productID, productName, price, inventoryAmount 
                         FROM DbProduct WHERE ";

                if (searchType == "Product ID")
                {
                    query += "productID = @Keyword";
                }
                else if (searchType == "Product Name")
                {
                    query += "productName LIKE @Keyword";
                }

                query += " ORDER BY productID DESC";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (searchType == "Product ID")
                        cmd.Parameters.AddWithValue("@Keyword", int.Parse(keyword));
                    else
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Product
                            {
                                ProductID = reader.GetInt32("productID"),
                                ProductName = reader.GetString("productName"),
                                Price = reader.GetDecimal("price"),
                                InventoryAmount = reader.GetInt32("inventoryAmount")
                            });
                        }
                    }
                }
            }

            return list;
        }


    }
}
