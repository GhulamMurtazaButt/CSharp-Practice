// Question #1:
// Use an array to solve the following problem:
// Write an app that inputs 10 numbers, each of which is between 10 and 100, inclusive. As each number
// is read, display it only if it’s not a duplicate of a number already read. Provide for the “worst case,” in
// which all five numbers are different.
// Display the complete set of unique values input after the user inputs each new value.

// using System;

// namespace Week4A01
// {
//     class Question1
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = new int[10];
//             int input = 0;
//             Console.WriteLine("Enter 10 numbers betweern 10 and 100");
//             for (int i = 0; i < numbers.Length; i++)
//             {

//                 input = int.Parse(Console.ReadLine());
//                 if(input >=10 && input <= 100)
//                 {
//                     numbers[i] = input;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Wrong Input: Enter a no between 10 and 100");
//                     i--;
//                 }


//             }

//             int check =0;

//             Console.WriteLine("___________________Unique Array printing_______________");
//             Array.Sort(numbers);
            
//             for (int i = 0; i < numbers.Length; i++)
//             {
//                 if (numbers[i] == numbers[i + 1])
//                 {
//                     check = numbers[i];

//                     continue;
                   
//                 }
//                 else
//                 {
//                     if (numbers[i] == check) { 
//                     continue;
//                     }

//                     Console.WriteLine(numbers[i]);
//                 }

//             }

//         }
//     }

// }

// Question #1:
// Use an array to solve the following problem:
// Write an app that inputs 10 numbers, each of which is between 10 and 100, inclusive. As each number
// is read, display it only if it’s not a duplicate of a number already read. Provide for the “worst case,” in
// which all five numbers are different.
// Display the complete set of unique values input after the user inputs each new value.

using System;

namespace Week4A01
{
    class Question1
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int input = 0;
            Console.WriteLine("Enter 10 numbers betweern 10 and 100");
            for (int i = 0; i < numbers.Length; i++)
            {

                input = int.Parse(Console.ReadLine());
                if (input >= 10 && input <= 100)
                {
                    numbers[i] = input;
                }
                else
                {
                    Console.WriteLine("Wrong Input: Enter a no between 10 and 100");
                    i--;
                }


            }

            int j = 0;

            Console.WriteLine("___________________Unique Array printing_______________");
            Array.Sort(numbers);Q

            for (int i = 0; i < numbers.Length; i++)
            {
                for (j = 0; j < numbers.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (numbers[i] == numbers[j])
                        break;
                }

                if (numbers.Length == j)
                {
                    Console.WriteLine(numbers[i] + " ");
                }
            }

        }

        }
    }
