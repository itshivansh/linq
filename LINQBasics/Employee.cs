using System;
using System.Collections.Generic;
using System.Text;

namespace LINQBasics
{
    public class Employee
    {
        //Properties of Employees
        #region Properties of Employee
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double Employeesalary { get; set; }
        #endregion
        public Employee[] GetAllValuesofEmployees()
        {
            Employee[] Employeeobjarray = { new Employee{ EmployeeId = 1, EmployeeName = "Vikram" },
                                 new Employee{EmployeeId=2,EmployeeName ="Mukesh"},
                                 new Employee{EmployeeId=3,EmployeeName ="Nandita"},
                                 new Employee{EmployeeId=4,EmployeeName ="Nishanth"}
            };
            return Employeeobjarray;
        }
    }
    
}
