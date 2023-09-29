using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    public class EmployeePayrollOperations
    {
        public static void CreateDatabase()
        {
            SqlConnection con = new SqlConnection("data source = (localdB)\\MSSQLLocalDB; initial catalog = master; integrated security = true");

            string query = "create database PayrollServiceDatabase2";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            cmd.ExecuteNonQuery();

            Console.WriteLine("Database created successfully");

            con.Close();
        }
    }
}
