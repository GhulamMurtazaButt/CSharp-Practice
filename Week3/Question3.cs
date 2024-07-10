// Question #3:
// Implement the following integer methods:
// a) Method Celsius returns the Celsius equivalent of a Fahrenheit temperature, using the
// calculation
// c = 5.0 / 9.0 * (f - 32);
// b) Method Fahrenheit returns the Fahrenheit equivalent of a Celsius temperature, using the
// calculation
// f = 9.0 / 5.0 * c + 32;
// c) Use the methods from parts (a) and (b) to write an app that enables the user either to enter a
// Fahrenheit temperature and display the Celsius equivalent or to enter a Celsius temperature
// and display the Fahrenheit equivalent.

using System;

namespace Week3
{
    class Question3
    {
        static double Celsius(double f)
        {
            double c = 0;
            c = 5.0 / 9.0 * (f - 32);
            return c;
        }
        static double Fahrenheit(double c)
        {
            double f = 0;
            f = 9.0 / 5.0 * c + 32;
            return f;
        }


        static void Main(string[] args)
        {
            char ch;
            double f = 0;
            double c = 0;
            Console.WriteLine("Enter C to calculate Fahrenheit and F to calculate Celsius:");
            ch = Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(ch))
            {
                case 'c':
                    Console.WriteLine("Enter value of fahrenheit to calculate Celsius: ");
                    f = Double.Parse(Console.ReadLine());
                    Console.WriteLine("The {0} fahrenheit to celsius is {1}", f, Celsius(f));
                    break;
                case 'f':
                    Console.WriteLine("Enter value of celsius to calculate Fahrenheit: ");
                    c = Double.Parse(Console.ReadLine());
                    Console.WriteLine("The {0} celsius to fahrenheit is {1}", c, Fahrenheit(c));
                    break;

                default:
                    Console.WriteLine("You entered a wrong input");
                    break;
            }
        }
    }
}