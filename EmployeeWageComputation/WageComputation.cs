using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int IS_FUllTIME = 1, IS_PARTTIME = 2, Emp_Full_Time_Hrs = 8, Emp_Part_time_Hrs = 4;

        public string Company_Name;
        int Emp_Wage_Per_Hr, Emp_Working_Per_Month, Max_Work_Hr;
        int empHrs = 0, totalEmpSalary, day = 0, total_Emp_Hrs=0, emp_WageDaily;
        decimal total_Emp_Wage;

        public WageComputation(string Company_Name, int Emp_Wage_Per_Hr, int Emp_Working_Per_Month, int Max_Work_Hr)
        {
            this.Company_Name = Company_Name;
            this.Emp_Wage_Per_Hr = Emp_Wage_Per_Hr;
            this.Emp_Working_Per_Month = Emp_Working_Per_Month;
            this.Max_Work_Hr = Max_Work_Hr;
            this.total_Emp_Wage = total_Emp_Wage;
        }

        public void eachCompanyTotalWage()
        {
            while (day <= Emp_Working_Per_Month && empHrs <= Max_Work_Hr)
            {
                Random random = new Random();
                int check = random.Next(0, 3);

                switch (check)
                {
                    case IS_FUllTIME:
                        empHrs = Emp_Full_Time_Hrs;
                        break;
                    case IS_PARTTIME:
                        empHrs = Emp_Part_time_Hrs;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                day++;
                emp_WageDaily = empHrs * Emp_Wage_Per_Hr;
                total_Emp_Hrs += empHrs;
                total_Emp_Wage += emp_WageDaily;
            }
            totalEmpSalary = total_Emp_Hrs * Emp_Wage_Per_Hr;
            total_Emp_Wage = Emp_Wage_Per_Hr * Emp_Working_Per_Month;
            Console.WriteLine("\nEmployee wage for days '" + day + "' is = " + emp_WageDaily + " for '" + empHrs + "' Hrs." );
            Console.WriteLine("Total Employee Wage for company " + Company_Name + " is : " + totalEmpSalary);
        }
        public override string ToString()
        {
            return "Total Company Employee Wage of  " + this.Company_Name + " is : " + this.total_Emp_Wage + "\n";
        }
    }
}
