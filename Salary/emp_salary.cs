using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class emp_salary
    {
        static void Main(string[] args)
        {
            Employee E1 = new Hr();
            Employee E2 = new Developer();
            Console.WriteLine("The Salary Of HR :" + E1.CalSalary());
            Console.WriteLine("The Slary Of Developer :" + E2.CalSalary());
            Console.ReadKey();
        }
    }
}
