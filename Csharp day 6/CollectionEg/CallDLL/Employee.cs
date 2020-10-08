using System;
using EmployeeSalary;




namespace CallDLL
{
    class Employee
    {
        public int Eid { get; set; }
        public float salary { get; set; }

        

        static void Main()
        {
            //call the dll
            TaxCalculation taxCalculation = new TaxCalculation();
            taxCalculation.CalculateTax(900000.00f);
            Console.Read();

        }
    }

    

}
