// Question #1:
// A small airline has just purchased a computer for its new automated reservations system. You have
// been asked to develop the new system. You’re to write an app to assign seats on each flight of the
// airline’s only plane (capacity: 10 seats).
// Display the following alternatives: Please type 1 for First Class and Please type 2 for Economy. If the
// user types 1, your app should assign a seat in the first-class section (seats 1–5). If the user types 2, your
// app should assign a seat in the economy section (seats 6–10). Use a one-dimensional array of type bool
// to represent the seating chart of the plane. Initialize all the elements of the array to false to indicate
// that all the seats are empty. As each seat is assigned, set the corresponding element of the array to
// true to indicate that the seat is no longer available.
// Your app should never assign a seat that has already been assigned. When the economy section is full,
// your app should ask the person if it’s acceptable to be placed in the first-class section (and vice versa).
// If yes, make the appropriate seat assignment. If no, display the message "Next flight leaves in 3 hours."

using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Week4A02
{
    class Question1
    {
       static bool[] capacity = new bool[10];
       static int economyseatcount = 0;
        static int firstclassseatcount = 5;

        static void Input()
        {

            int input = 0;

            
            do
            {
                Console.WriteLine("Select the corresponding menu option to proceed:");
                Console.WriteLine(" Please type 1 for First Class \n Please type 2 for Economy \n Please enter 3 to check seats \n Please type 4 to exit");

                Console.Write("Menu option> ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {

                    case 1:
                        FirstClass();
                        break;
                    case 2:
                        Economy();

                        break;
                    case 3:
                        seatscheck();

                        break;
                    case 4:

                        Console.WriteLine("----------Good Bye----------");
                        break;
                    default:
                        Console.WriteLine("----------Input Wrong: Please Enter right input----------");
                        break;

                }
            } while (input != 4);

        }

        static void Economy()
        {
            if (economyseatcount < 5)
            {
                capacity[economyseatcount] = true;
                economyseatcount++;
                Console.WriteLine("----------Seat Reserved----------");
            }
            else
            {
                Console.WriteLine("----------Seats are full: Next flight leaves in 3 hours----------");
                Console.WriteLine("----------If you want FirstClass seat Press 1----------");
                Input();
            }
        }

        static void FirstClass()
        {
            if (firstclassseatcount >= 5 && firstclassseatcount < 10)
            {
                capacity[firstclassseatcount] = true;
                firstclassseatcount++;
                Console.WriteLine("----------Seat Reserved----------");
            }
            else
            {
                Console.WriteLine("----------Seats are full: Next flight leaves in 3 hours----------");
                Console.WriteLine("----------I you want Econmy seat Press 2----------");
                    Input();
            }
        }

        static void seatscheck()
        {
            Console.WriteLine("Economy: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(capacity[i]);
            }
            Console.WriteLine("FirstClass: ");
            for (int i=5; i < 10; i++)
            {
                Console.WriteLine(capacity[i]);
            }
        }

        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                capacity[i] = false;
            }
            Console.WriteLine("----------Welcome to Airplane Seats Management System-------");

            Input();


        }
    }
}