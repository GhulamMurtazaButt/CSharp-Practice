// Question #6:
// For this exercise any method that you create SHOULD NOT have a return type. Use void returns only.
// - Write a method that calculates the area of a circle (use Math.PI for the formula). The method
// should take a parameter p as a referenced parameter.
// - Write a method that calculates the circumference of a circle (use Math.PI for the formula).
// The method should take a parameter p as a referenced parameter.

using System;

namespace Week3
{
    class Question6
    {
        static void AreaofCircle(ref double rad)
        {
            if (rad > 0)
            {
                double Area = Math.PI * rad * rad;
                Console.WriteLine("The Area of Circle is {0}", Area);
            }
            else
            {
                Console.WriteLine("Radius should be positive.");
            }
        }

        static void CircumferenceofCircle(ref double rad)
        {
            if (rad > 0)
            {
                double Circumference = 2 * Math.PI * rad;
                Console.WriteLine("The Circumference of circle is {0}", Circumference);
            }
            else
            {
                Console.WriteLine("Radius should be positive.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of radius to find Area of Circle: ");
            double radius = Double.Parse(Console.ReadLine());
            AreaofCircle(ref radius);

            Console.WriteLine("Enter the value of radius to find Circumference of Circle: ");
            double radius2 = Double.Parse(Console.ReadLine());
            CircumferenceofCircle(ref radius2);
        }
    }
}