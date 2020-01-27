using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    public abstract class Employee
    {
        public int emp_id;
        public string emp_name;
        public string designation;
        public int Exp;
        public double AnnualSal;
        public DateTime date;

        public abstract double CalSalary();
    }

    public class Hr : Employee 
    {
        private double basicsalary;

        public override double CalSalary()
        {
            double basicsalary = 8000;
            int Exp = 4;
            return basicsalary * 1000 * (Exp);

        }
    }

    public class Developer : Employee
    {
        private double basicSalary1;
        public override double CalSalary()
        {
            double basicsalary1 = 8000;
            int Exp = 5;
            return basicsalary1 * 2000 * Exp;
        
        }
    }
        
}
