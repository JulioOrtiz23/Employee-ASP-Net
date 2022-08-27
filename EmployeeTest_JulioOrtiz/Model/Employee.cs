using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTest_JulioOrtiz
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(int employeeID, string employeeFirstName, string employeeLastName, string employeePhone, int employeeZip, DateTime hireDate)
        {
            this.EmployeeID = employeeID;
            this.EmployeeFirstName = employeeFirstName;
            this.EmployeeLastName = employeeLastName;
            this.EmployeePhone = employeePhone;
            this.EmployeeZip = employeeZip;
            this.HireDate = hireDate;
        }
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeePhone { get; set; }
        public int EmployeeZip { get; set; }
        public DateTime HireDate { get; set; }
    }
}