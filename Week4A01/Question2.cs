// Question #2:
// Write a program that inputs a 5 digit number from the user. It then uses an int array to determine which
// number occurred how many times in that number. For example, if the user enters 11263, in this
// example number 1 occurred two times, 2 occurred 1 times, 6 occurred 1 times and 3 occurred 1 times.
// Similarly for input 99696, 9 occurred 3 times and 6 occurred 2 times.

using System;
namespace Week4A01
{
    class Question2
    {
        static int count(int numb)
        {
            int count = 0;
            do
            {
                numb /= 10;
                count++;

            } while (numb != 0);
            return count;
        }

       

        static void Main(string[] args)
        {
            int[] myarr = new int[5];
            
            int number = 0;
            int checkcount = 0;
            do
            {
                Console.WriteLine("Enter a five digit number: ");
                number = int.Parse(Console.ReadLine());

                checkcount = count(number);


                if (checkcount != 5)
                {
                    Console.WriteLine("Wrong Input");

                }
                else
                {
                    myarr[0] = number / 10000;
                    myarr[1] = number / 1000 - myarr[0] * 10;
                    myarr[2] = number / 100 - myarr[0] * 100 - myarr[1] * 10;
                    myarr[3] = number / 10 - myarr[0] * 1000 - myarr[1] * 100 - myarr[2] * 10;
                    myarr[4] = number - myarr[0] * 10000 - myarr[1] * 1000 - myarr[2] * 100 - myarr[3] * 10;


                }

            } while (checkcount != 5);

            int count1 = 0;
     
            Array.Sort(myarr);
            
            for (int i = 0;  i < myarr.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (myarr[i] == myarr[j])
                    {
                        count1++;
                    }
                }
                Console.WriteLine("{0} occurs at {1} times", myarr[i], count1);
                count1 = 0;
            }
        }

    }
}