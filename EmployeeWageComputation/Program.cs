using System;
namespace EmployeeWageComputation
{
    public interface Program
    {
        public static void Main(string[] args)
        {
            WageComputation company = new WageComputation();
            company.AddCompanyEmpWage("Reliance", 400, 200, 10);
            company.AddCompanyEmpWage("Microsoft", 500, 150, 30);
            company.ComputeEmpWage();
            Console.WriteLine(company.ToString());
        }
    }
}