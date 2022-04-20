using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int IS_FUllTIME = 1, IS_PARTTIME = 2,
        Emp_Full_Time_Hrs = 8, Emp_Part_time_Hrs = 4;
        int empHrs = 0, day = 0, totalEmpSalary;
        public void multipleCompanyWage(string Company_Name, int Emp_Wage_Per_Hr, int Max_Work_Hr,
            int Emp_Working_Per_Month)
        {
            while (day <= Emp_Working_Per_Month && empHrs <= Max_Work_Hr)
            {
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FUllTIME:

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
            totalEmpSalary = empHrs * Emp_Wage_Per_Hr;
            Console.WriteLine("Company : " + Company_Name + ", Emp Working Hour : " + Emp_Wage_Per_Hr + 
                ", Maximum working Hour : " + Max_Work_Hr + ", Total Days In Month : " + Emp_Working_Per_Month);
            Console.WriteLine("Monthly Employee Salary is :" + totalEmpSalary);
        }
    }
}
