using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int IS_FullTIME = 1, IS_PARTTIME = 2, EmpRatePerHr = 20, Emp_Full_Time_Hrs = 8, Emp_Part_time_Hrs = 4;
        int empHrs = 0, totalEmpWage;

        public void EmpDailyWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_FullTIME:
                    Console.WriteLine("Employee Working as a Full Time");
                    empHrs = Emp_Full_Time_Hrs;
                    break;
                case IS_PARTTIME:
                    Console.WriteLine("Employee Working as a Part Time");
                    empHrs = Emp_Part_time_Hrs;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            totalEmpWage = empHrs * EmpRatePerHr;
            Console.WriteLine("Day Employee Salary is : " + totalEmpWage);
        }
    }
}
