using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class TaxCalculation
    {
     public  void CalculateTax(float salary)
        {
            if (salary > 0)
            {
                float Annualsalary = salary * 12;
                double tax;
                if (Annualsalary > 500000)
                {
                    tax = Annualsalary * 0.1;
                }
                else
                {
                    tax = 0;
                }
                Console.WriteLine("tax amount:{0}",tax);
            }
            else
            {
                Console.WriteLine("Salary is Zero!! cant calculate tax");
            }
        }
       
    }
}
