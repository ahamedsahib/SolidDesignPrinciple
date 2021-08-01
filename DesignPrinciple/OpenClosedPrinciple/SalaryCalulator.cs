using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciple.OpenClosedPrinciple
{
    public abstract class SalaryCalculator
  {
        public abstract double CalculateSalary();
    }

    public class SeniorDev : SalaryCalculator
    {
        public override double CalculateSalary()
        {
            double bp=10000, hra=2000, sb=800,totalSalary;
            totalSalary = bp + hra + sb;
            return totalSalary;
        }
    }
    public class JuniorDev : SalaryCalculator
    {
        public override double CalculateSalary()
        {
            double bp = 5000, hra = 1000, sb = 300, totalSalary;
            totalSalary = bp + hra + sb;
            return totalSalary;
        }
    }
}
