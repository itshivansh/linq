using System;
using System.Collections.Generic;
using System.Text;
namespace LINQBasics
{
    public class LINQTask2
    {
        public readonly Employee[] eobjarray;
        public readonly Employee employeeObject;
        public LINQTask2()
        {
            employeeObject = new Employee();
            eobjarray = employeeObject.GetAllValuesofEmployees();
        }
        public int[] FunToSendSelectedEmployeeIds()
        {
            
            int[] sendmyselectedEmployeeIds = new int[3];
            //int i = 0;
            //Return the Employee Ids from 1 to 3  using foreach loop iteration 
            //use foreach without LINQ Concept to know the reason of using the LINQ
            
            return sendmyselectedEmployeeIds;
        }
    }
}
