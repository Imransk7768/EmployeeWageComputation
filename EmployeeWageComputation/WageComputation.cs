using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int IS_FullTIME = 1, EmpRatePerHr = 20, IS_FullHr = 8;
        int empHrs = 0, totalEmpWage;
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FullTIME)
                empHrs = IS_FullHr;
            else
                empHrs = 0;
            totalEmpWage = empHrs * EmpRatePerHr;
            Console.WriteLine("EMP Wage : " + totalEmpWage);
        }
    }
}
