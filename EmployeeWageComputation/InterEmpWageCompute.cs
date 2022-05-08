using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface InterEmpWageCompute
    {
        public void AddCompanyEmpWage(string company_Name, int Emp_Wage_Per_Hr, int Emp_Working_Per_Month, int Max_Work_Hr);
        public void ComputeEmpWage();
        public int GetTotalEmpWage(string companyName);
    }
}
