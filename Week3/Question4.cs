// Question #4:
// Develop a C# app that will determine the gross pay for each of three employees. The company pays
// straight time for the first 40 hours worked by each employee and 1.5 times for all hours worked in
// excess of 40 hours. You’re given a list of the three employees of the company, the number of hours
// each employee worked last week and the hourly rate of each employee. Your app should input this
// information for each employee, then should determine and display the employee’s gross pay.

using System;

namespace Week3
{
    class Employee
    {
        public string Name { get; set; }
        public int hours { get; set; }
        public int pay { get; set; }
        public double CalculateGrossPay(int hours, double pay)
        {
            double grossPay = 0;

            if (hours > 0 && hours <= 40)
            {
                grossPay = hours * pay;
            }
            else
            {
                int extrahours = hours - 40;
                grossPay = (hours * pay) + (extrahours * (pay * 1.5));
            }

            return grossPay;
        }

        public void PrintEmployeeDetails(Employee employee)
        {
            Console.WriteLine("Employee name is: {0}", employee.Name);
            Console.WriteLine("Employee worked for {0} hours.", employee.hours);
            Console.WriteLine("Employee hourly pay is: {0}", employee.pay);
            Console.WriteLine("The Gross pay of employee is: {0} ", employee.CalculateGrossPay(employee.hours, employee.pay));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("______________Employee1__________________");
            Employee employee1 = new Employee();
            employee1.Name = "Murtraza";
            employee1.hours = 50;
            employee1.pay = 1000;
            employee1.PrintEmployeeDetails(employee1);
            Console.WriteLine("");
            Console.WriteLine("______________Employee2__________________");
            Employee employee2 = new Employee();
            employee2.Name = "Butt";
            employee2.hours = 35;
            employee2.pay = 1000;
            employee2.PrintEmployeeDetails(employee2);
            Console.WriteLine("");
            Console.WriteLine("______________Employee3_________________");
            Employee employee3 = new Employee();
            employee3.Name = "ALi";
            employee3.hours = 40;
            employee3.pay = 1200;
            employee2.PrintEmployeeDetails(employee3);

        }
    }
}