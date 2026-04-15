using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace POPS_System_Design.Classes
{
    public class CustomerRepository
    {
        //Create a connection to the database
        private DatabaseConnection db = new DatabaseConnection();

        //Method/Command for Inserting a new customer into the database
        public int AddCustomer(Customer customer)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                //Open the connection
                conn.Open();

                //SQL Query to insert a new customer into the database
                string query = @"
                INSERT INTO DbCustomer
                (firstName, lastName, email, phone, street, state, city, zip)
                VALUES
                (@firstName,@lastName, @email, @phone, @street, @state, @city, @zip)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Parameters
                cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@lastName", customer.LastName);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@phone", customer.Phone);

                cmd.Parameters.AddWithValue("@street", customer.Address.Street);
                cmd.Parameters.AddWithValue("@state", customer.Address.State);
                cmd.Parameters.AddWithValue("@city", customer.Address.City);
                cmd.Parameters.AddWithValue("@zip", customer.Address.Zip);

                //Execute the query
                cmd.ExecuteNonQuery();

                return (int)cmd.LastInsertedId;
            }
        }

        //Method/Command for retrieving all customer from Customer table in the database
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (MySqlConnection conn = db.GetConnection())
            {
                //Open the connection
                conn.Open();
                //SQL Query to select all customers from the database
                string query = "SELECT * FROM DbCustomer";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer()
                        {
                            CustomerID = reader.GetInt32("custID"),
                            FirstName = reader.GetString("firstName"),
                            LastName = reader.GetString("lastName"),
                            Email = reader.GetString("email"),
                            Phone = reader.GetString("phone"),
                            Address = new Address()
                            {
                                Street = reader.GetString("street"),
                                City = reader.GetString("city"),
                                State = reader.GetString("state"),
                                Zip = reader.GetString("zip")
                            }
                        };
                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }
    }
}
