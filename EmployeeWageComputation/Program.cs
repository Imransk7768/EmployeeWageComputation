using System;
namespace EmployeeWageComputation
{
    public interface Program
    {
        public static void Main(string[] args)
        {
            WageComputation Philips = new WageComputation("Philips", 20, 4, 10);
            Philips.eachCompanyTotalWage();
            Console.WriteLine(Philips.ToString());
            WageComputation Samsung = new WageComputation("Samsung", 23, 8, 10);
            Samsung.eachCompanyTotalWage();
            Console.WriteLine(Samsung.ToString());
            WageComputation Asus = new WageComputation("Asus", 25, 6, 12);
            Asus.eachCompanyTotalWage();
            Console.WriteLine(Asus.ToString());
        }
    }
}