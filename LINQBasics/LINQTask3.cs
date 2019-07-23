using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
namespace LINQBasics
{
    public class LINQTask3
    {
        public readonly Employee[] eobjarray;
        public readonly Employee employeeObject;
        public LINQTask3()
        {
            employeeObject = new Employee();
            eobjarray = employeeObject.GetAllValuesofEmployees();
        }
        public delegate int MyDelegate(int myvalue);
        //access del-key ret-type Del-name(optional Parameters);
        public delegate int MyDeleagate(int x, int y);
        public ArrayList FunToReturnEvenNumberofItems()
        {
            //GenericListWtihLammdaOptions
            //Generic List to get Even Numbers form List and return ArrayList
            //use FinalAll functionality to get even number of items
            ArrayList myarrlist = new ArrayList();
            List<int> myintlist = new List<int> { 11, 21, 33, 46, 56, 89, 09, 67 };
            //use FindAll to get the evenNumbers
            return myarrlist;
        }

        public ArrayList FunToReturnOddNumberofItems()
        {
            //GenericListWtihLammdaOptions
            //Generic List to get Odd Numbers form List and return ArrayList
            //use FindAll functionality to get odd number of items

            ArrayList myarrOddlist = new ArrayList();
            List<int> myintlist = new List<int> { 11, 21, 33, 46, 56, 89, 09, 67 };
            //use FindAll to get the OddNumbers
            return myarrOddlist;
        }
        //Delegate with One Parameter
        public int FuntoUseDelegatewithLambda(int valuefromTestcase)
        {
            //Instantiation
            //Invocation
            //Use Delegate with Lambda 
            int finalresult =0; 
            return finalresult;
        }
        //Delegate with more than one Parameters
        public int FuntoUseDelegatewithLambdawithTwoParameters(int firstvalue,int secondvalue)
        {
            //Use MyDelegagte create a instance of Delegate 
            //use function i.e FuntoRetnBackAddedValues
            MyDeleagate mydelboj = FuntoRetnBackAddedValues;
            int finaresult = 0;
            return finaresult;
        }
        //Function to return back Addedvalues
        public int FuntoRetnBackAddedValues(int takexvalue, int takeyvalue)
        {
            int myresut = takexvalue + takeyvalue;
            return myresut;
        }
        //FuntoUseFuncDelegate
        public int FuntoUseFuncDelegate(int fisrstvaluetofuncdelegate)
        {
            //use FuntoReturnvarPlusOne
            //Use Func Delegate 
            //use function i.e FuntoReturnvarPlusOne and pass as a parameter to the delegate 
            //Object
           
            int finaresult= 0;
            return finaresult;
        }
        public static int FuntoReturnvarPlusOne(int myvarx)
        {
            int calculateresult = myvarx + 1;
            return calculateresult;
        }
        //use of Func delegate with class properties
        public int FuntoCheckfuncDelegatewithClassProperties()
        {
            //use Func delegate
            //use delegate() instead of calling separate method
            Func<int> myfuncobj = delegate ()
            {
                //Assign 10 value to class property i.e EmployeeId
                //EmployeeId set it as 10
                //Create a Object of Employee

                return employeeObject.EmployeeId = 10;
            };

            //call the delegate Object 
            int finalresultfromdelegate = 0;
            return finalresultfromdelegate;
        }
        
        public int FunToGetMaxValueofEmployeeId()
        {
            //Get the Max value of EmployeeId
            //using Lambda expression
            //use eobjarray as initialised in Line 10 and get the values 
            //to find the maximum values
            int mymaxvalue = 0;
            return mymaxvalue;

        }
        public int FunToGetMinValueofEmployeeId()
        {
            //Get the Max value of EmployeeId
            //using Lambda expression
            //use eobjarray as initialised in Line 10 and get the values 
            //to find the minimum values
            int myminvalue = 0;
            return myminvalue;
        }
    }
}
    
    

