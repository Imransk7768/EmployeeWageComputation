using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        //constance value
        const int IS_FUllTIME = 1, IS_PARTTIME = 2, Emp_Full_Time_Hrs = 8, Emp_Part_time_Hrs = 4;
        public int numberOfCompany = 0;
        public EmpWageBuilderObject[] compEmpWageArray;
        public WageComputation()
        {
            this.compEmpWageArray = new EmpWageBuilderObject[5];
        }
        public void AddCompanyEmpWage(string company_Name, int Emp_Wage_Per_Hr, int Emp_Working_Per_Month, int Max_Work_Hr)
        {
            compEmpWageArray[this.numberOfCompany] = new EmpWageBuilderObject(company_Name, Emp_Wage_Per_Hr, Max_Work_Hr, Emp_Working_Per_Month);
            numberOfCompany++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < compEmpWageArray.Length; i++)
            {
                compEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.compEmpWageArray[i]));
                Console.WriteLine(this.compEmpWageArray[i].ToString());
            }
        }
        public int ComputeEmpWage(EmpWageBuilderObject empWageBuilderObject)
        {
            int empHrs = 0, totalEmpSalary = 0, totalEmpHrs = 0, day = 0;
            while (day <= empWageBuilderObject.emp_Working_Day_Pr_Month && empHrs < empWageBuilderObject.emp_Max_Working_Hr)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_FUllTIME:
                        empHrs += 8;
                        break;
                    case IS_PARTTIME:
                        empHrs += 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                day++;
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + empWageBuilderObject.emp_Working_Day_Pr_Month + ", Employee Hrs : " + empHrs);
            }
            return totalEmpSalary = totalEmpHrs * empWageBuilderObject.emp_Wage_Pr_Hr;
        }
    }
}
