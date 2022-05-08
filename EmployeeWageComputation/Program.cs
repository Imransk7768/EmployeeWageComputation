using System;
namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WageComputation company = new WageComputation();
            Console.WriteLine("Enter Company Name, \n EmpWage Working_Per Hours \n Total Working Hours \n Total Working Days In Month");
            string compName = Console.ReadLine();
            int EmpWage_Working_Pr_Hours = Convert.ToInt32(Console.ReadLine());
            int Total_Working_Hours = Convert.ToInt32(Console.ReadLine());
            int Total_Working_Das_In_Month = Convert.ToInt32(Console.ReadLine());
            company.AddCompanyEmpWage(compName, EmpWage_Working_Pr_Hours, Total_Working_Hours, Total_Working_Das_In_Month);
            company.ComputeEmpWage();
            Console.WriteLine("Total wage for " + compName + " is " + company.GetTotalEmpWage(compName));
        }
    }
}