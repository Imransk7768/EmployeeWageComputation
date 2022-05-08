using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilderObject
    {
        public string company_Name;
        public int emp_Wage_Pr_Hr, emp_Max_Working_Hr, emp_Working_Day_Pr_Month;
        public decimal total_Emp_Wage;

        public EmpWageBuilderObject(string company_Name, int Emp_Wage_Per_Hr, int Emp_Working_Per_Month, int Max_Work_Hr)
        {
            this.company_Name = company_Name;
            this.emp_Wage_Pr_Hr = Emp_Wage_Per_Hr;
            this.emp_Max_Working_Hr = Max_Work_Hr;
            this.emp_Working_Day_Pr_Month = Emp_Working_Per_Month;
        }
        public void SetTotalEmpWage(int total_Emp_Wage)
        {
            this.total_Emp_Wage = total_Emp_Wage;
        }
        public string toString()
        {
            return "Total Employee wage for Company " + this.company_Name + " is " + this.total_Emp_Wage;
        }
    }
}