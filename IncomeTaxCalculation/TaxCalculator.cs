using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTaxCalculation
{
   public class TaxCalculator
    {
        public TaxCalculator(int age, double salary)
        {
            this.Salary = salary;
            this.Age = age;
        }
        private double Salary { get; set; }
        private int Age { get; set; }

        public const string AgeLessThanZeroMessage = "The age of the employeee can not be less than 0";
        public const string AgeIsNullMessage = "The age of the employeee can not be a null value";

        public void IsAgeValid(int age)
        {
            if (age <= 0)
            {
                throw new ArgumentOutOfRangeException("age", age, AgeLessThanZeroMessage);
            }
        }
        public void IsSalaryValid(double salary)
        {
            if (salary <= 0)
            {
                throw new ArgumentOutOfRangeException("salary", salary, AgeLessThanZeroMessage);
            }
        }
        private double _belowSixty
        {
            get
            {
                double taxRate = 0;
                taxRate = (Salary <= 250000) ? 0.0 : (Salary > 250000 && Salary <= 500000) ? 0.05 : (Salary > 500000 && Salary <= 1000000) ? 0.2 : 0.3;
                return taxRate;
            }
        }

        private double _sixtyToEighty
        {
            get
            {
                double taxRate = 0;
                taxRate = (Salary <= 300000) ? 0.0 : (Salary > 300000 && Salary <= 500000) ? 0.05 : (Salary > 500000 && Salary <= 1000000) ? 0.2 : 0.3;
                return taxRate;
            }
        }

        private double _aboveEighty
        {
            get
            {
                double taxRate = 0;
                taxRate = (Salary <= 500000) ? 0.0 : (Salary > 500000 && Salary <= 1000000) ? 0.2 : 0.3;
                return taxRate;
            }
        }

        public double CalculateTax()
        {
            double taxValue = 0;

            if (Age < 60)
            {
                taxValue = (Salary <= 500000) ? (_belowSixty * Salary) : (Salary > 500000 && Salary <= 1000000) ?
                 (_belowSixty * (Salary - 500000) + 12500) : ((_belowSixty * (Salary - 1000000)) + 112500);
            }
            else if (Age >= 60 && Age < 80)
            {

                taxValue = (Salary <= 500000) ? (_sixtyToEighty * Salary) : (Salary > 500000 && Salary <= 1000000) ?
                    ((_sixtyToEighty * (Salary - 500000)) + 10000) : ((_sixtyToEighty * (Salary - 1000000)) + 110000);
            }
            else if (Age >= 80)
            {
                taxValue = (Salary <= 1000000) ? (_aboveEighty * Salary) : ((_aboveEighty * (Salary - 1000000)) + 100000);
            }
            else
            {
                return 0;
            }
            return taxValue;
        }
    }
}
