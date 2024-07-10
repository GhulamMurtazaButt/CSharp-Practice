// Question #5:
// Write a program multiply and overload it for the following variants
// 1. Two Integers
// 2. Two Floats
// 3. Two Integer and one float
// 4. Two integers and two doubles
// 5. 1 integer and 1 byte and 1 long
// 6. 3 integers, 2 doubles, 4 longs
// 7. 1 short and 1 integer
// Write as many variants of #3,4,5,6,7 with the orders of the parameters changed. Make sure to call all
// of them from your main.

using System;

namespace Week3
{
    class Question5
    {
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static float Multiply(float a, float b)
        {
            return a * b;
        }
        static float Multiply(int a, int b, float c)
        {
            return a * b * c;
        }
        static double Multiply(int a, int b, double c, double d)
        {
            return a * b * c * d;
        }

        static double Multiply(float a, byte b, long c)
        {
            return a * b * c;
        }

        static double Multiply(int a, int b, int c, double d, double e, long f, long g, long h, long i)
        {
            return a * b * c * d * e * f * g * h * i;
        }

        static int Multiply (short a,  int b )
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Result 1: " + Multiply(2, 3));
            Console.WriteLine("Result 2: " + Multiply(2.5f, 3.5f));
            Console.WriteLine("Result 3: " + Multiply(2, 3, 1.5f));
            Console.WriteLine("Result 4: " + Multiply(2, 3, 1.5, 2.5));
            Console.WriteLine("Result 5: " + Multiply(1.5f, 3, 4000000000L));
            Console.WriteLine("Result 6: " + Multiply(2, 3, 4, 1.5, 2.5, 1000000000L, 2000000000L, 3000000000L, 4000000000L));
            Console.WriteLine("Result 7: " + Multiply(2, 3));


        }
    }
}