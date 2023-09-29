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

        public static SqlConnection con = new SqlConnection("data source = (localdB)\\MSSQLLocalDB; initial catalog = PayrollServiceDatabase2; integrated security = true");

        public static void CreateTable()
        {
            string query = "create table EmployeePayroll(Id bigint primary key identity(1, 1), Name varchar(20) not null, PhoneNumber bigint not null, Gender varchar(1) check(Gender in ('M', 'F')) not null, StartDate Date not null, City varchar(15) not null, Country varchar(15) not null, PinCode bigint not null, Salary float not null);";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table created successfully");
            con.Close();
        }
    }
}
