using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {

        const int IS_FullTIME = 1, IS_PARTTIME = 2, EmpRatePerHr = 20,
        Emp_Full_Time_Hrs = 8, Emp_Part_time_Hrs = 4, Emp_Working_Per_Month = 20;
        int empHrs = 0, totalEmpSalary = 0;

        public void EmpMonthlyWage()
        {
            for (int i = 0; i <= Emp_Working_Per_Month; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_FullTIME:

                        empHrs += Emp_Full_Time_Hrs;
                        break;
                    case IS_PARTTIME:

                        empHrs += Emp_Part_time_Hrs;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

            }
            totalEmpSalary = empHrs * EmpRatePerHr;
            Console.WriteLine("Monthly Employee salary is :" + totalEmpSalary);
        }
    }
}
