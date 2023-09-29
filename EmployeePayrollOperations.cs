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

        public static void InsertIntoTable()
        {
            string query = "Insert into EmployeePayroll values('Dhanya', 8431384824, 'F', '02/26/2001', 'Shimoga', 'India', 577421, 1000000.0)";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data inserted successfully");
            con.Close();
        }

        public static void DisplayData()
        {
            EmployeePayrollModel model = new EmployeePayrollModel();
            string query = "Select * from EmployeePayroll";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                Console.WriteLine("------Data------");
                while (sqlDataReader.Read())
                {
                    model.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    model.Name = Convert.ToString(sqlDataReader["Name"]);
                    model.PhoneNumber = Convert.ToInt64(sqlDataReader["PhoneNumber"]);
                    model.Gender = Convert.ToChar(sqlDataReader["Gender"]);
                    model.StratDate = Convert.ToString(sqlDataReader["StartDate"]);
                    model.City = Convert.ToString(sqlDataReader["City"]);
                    model.Country = Convert.ToString(sqlDataReader["Country"]);
                    model.PinCode = Convert.ToInt64(sqlDataReader["PinCode"]);
                    model.Salary = Convert.ToDouble(sqlDataReader["Salary"]);
                    
                    Console.WriteLine("Id : {0}\nName : {1}\nPhoneNumber : {2}\nGender : {3}\nStartDate : {4}\nCity : {5}\nCountry : {6}\nPinCode : {7}\nSalary : {8}", model.Id, model.Name, model.PhoneNumber, model.Gender, model.StratDate, model.City, model.Country, model.PinCode, model.Salary);
                }
            }
            con.Close();
        }
    }
}
