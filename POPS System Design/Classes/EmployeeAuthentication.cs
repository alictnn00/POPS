using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPS_System_Design.Classes
{
    public class EmployeeAuthentication
    {
        //Create a connection to the database
        private DatabaseConnection db = new DatabaseConnection();

        public Employee AuthenticateEmployee(string email, string password)
        {
            Employee emp = null;

            using (MySqlConnection conn = db.GetConnection())
            {
                //Open the connection
                conn.Open();

                //SQL Query to check if the email and password match an employee in the database
                string query = @"SELECT empID, name, role, department, email 
                             FROM DbEmployee 
                             WHERE email = @Email AND password = @Password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emp = new Employee()
                            {
                                EmpID = reader.GetInt32("empID"),
                                Name = reader.GetString("name"),
                                Role = reader.GetString("role"),
                                Department = reader.GetString("department"),
                                Email = reader.GetString("email")
                            };
                        }
                    }
                }
            }
            return emp;
        }
    }
}