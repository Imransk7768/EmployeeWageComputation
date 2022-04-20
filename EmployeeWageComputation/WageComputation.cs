using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int IS_FUllTIME = 1, IS_PARTTIME = 2, EmpRatePerHr = 20,
        Emp_Full_Time_Hrs = 8, Emp_Part_time_Hrs = 4, Emp_Working_Per_Month = 20,
        Max_Work_Hr = 100;
        int empHrs = 0, day = 0, salary, sum, totalEmpSalary;
        public int Max_Working_Hr { get; set; }
        public void MaxEmpMonthlyWage()
        {
            for (int i = 1; i <= 20; i++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FUllTIME:
                        empHrs = 8;
                        break;
                    case IS_PARTTIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                salary = empHrs * EmpRatePerHr;
                Console.WriteLine("Day" + i + " " + salary);
                totalEmpSalary = totalEmpSalary + salary;
                if (empHrs <= 100)
                {
                    sum = sum + empHrs;
                }
            }
            Console.WriteLine("Total Salary of 20 Days : " + totalEmpSalary);
            Console.WriteLine("Total Working Hrs is : " + sum);
        }
    }
}
