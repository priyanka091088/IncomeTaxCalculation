using System;

namespace IncomeTaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking age and salary for an employee
            

            Console.WriteLine("Enter your age and salary");
            int age = Convert.ToInt32(Console.ReadLine());

            double salary = Convert.ToDouble(Console.ReadLine());

            //calling TaxValue method to calculate tax for the employee
            var person1 = new TaxCalculator(age, salary);
            double taxValue = person1.CalculateTax();



            Console.WriteLine($"The annual Income Tax value for employee of age: {age} and salary: {salary} is {taxValue}");
        }
    }
}
