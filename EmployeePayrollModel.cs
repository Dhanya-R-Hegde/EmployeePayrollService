using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    public class EmployeePayrollModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public long PhoneNumber { get; set; }

        public char Gender { get; set; }

        public string StratDate { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public long PinCode { get; set; }

        public double Salary { get; set; }


    }
}
