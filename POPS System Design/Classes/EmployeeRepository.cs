using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPS_System_Design.Classes
{
    public class EmployeeRepository
    {

        //Create a connection instance to the database
        private DatabaseConnection db = new DatabaseConnection();

        //Method for retrieving salesman from the database
        public List<Employee> GetSalesEmployees()
        {
            List<Employee> list = new List<Employee>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT empID, name 
                         FROM DbEmployee 
                         WHERE department = 'Sales'";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Employee
                        {
                            EmpID = reader.GetInt32("empID"),
                            Name = reader.GetString("name")
                        });
                    }
                }
            }

            return list;
        }
    }
}
