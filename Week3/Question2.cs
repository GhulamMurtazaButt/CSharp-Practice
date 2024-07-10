// Write a method that takes an integer value and returns the number with its digits reversed. For
// example, given the number 57631, the method should return 13675. Note that there can be ANY
// number of digits in the given number. Incorporate the method into an app that reads a value from the
// user and displays the result. Then use this method to determine whether a given number is a
// palindrome or not. A palindrome is a number which is the same if you reverse it. e.g 54321012345 is a
// palindrome.

using System;

namespace Week3
{
    class Question2
    {
        static int reverse(int val)
        {
            int numb;
            int concat = 0;

            while (val != 0)
            {
                numb = val % 10;
                concat = concat * 10 + numb;
                val = val / 10;
            }
            
            return concat;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer to check its reverse: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("The reverse of integer is: {0}", reverse(value));
            if (value == reverse(value))
            {
                Console.WriteLine("Your entered value is PALINDROME");
            }



        }
    }
}