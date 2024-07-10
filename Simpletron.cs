//Simpletron in CSharp C#

using System;

namespace Module1
{
    class Simpletron
    {
        public int[] memory = new int[100];
        int instructionRegister = 0;
        int accumulator = 0;
        int instuctionCounter = 0;
        int operationCode = 0;
        int operand = 0;


        public void Print()
        {
            Console.WriteLine("Registers: ");
            Console.WriteLine("accumulator  +{0}", accumulator);
            Console.WriteLine("instructionCounter  ", instuctionCounter);
            Console.WriteLine("instructionRegister +{0}", instructionRegister);
            Console.WriteLine("operationCode  ", operationCode);
            Console.WriteLine("operand  ", operand);
            Console.WriteLine("MEMORY");
            for (int i =0; i<memory.Length; i++)
            {
                Console.Write("+{0}\t", memory[i]);
            }
        }

        public void Run()
        {
            for (int i = 0; i < memory.Length; i++)
            {
                instructionRegister = memory[instuctionCounter];
                Instructions(instructionRegister);
                instuctionCounter++;
            }
            
        }

        public void Instructions(int instructionRegister)
        {
            operationCode = instructionRegister / 100;
            operand = instructionRegister % 100;

            switch(operationCode)
            {
                case 10:
                    Console.WriteLine("Enter an integer: ");
                    int input = int.Parse(Console.ReadLine());
                    memory[operand] = input;
                    break;

                case 11:
                    Console.WriteLine(memory[operand]);
                    break;

                case 20:
                    accumulator = memory[operand];
                    break;

                case 21:
                    memory[operand] = accumulator;
                    break;

                case 30:
                    accumulator += memory[operand];
                    break;

                case 31:
                    
                    accumulator -= memory[operand];
                    
                    break;

                case 32:
                    accumulator /= memory[operand];
                    break;

                case 33:
                    accumulator *= memory[operand];
                    break;

                case 40:
                    instuctionCounter = operand;
                    break;

                case 41:
                    if (accumulator < 0)
                    {
                        Console.WriteLine("Number is less");
                        instuctionCounter = operand;
                    }
                    else
                    {
                        Console.WriteLine("Number is greater");
                    }
                    break;

                case 42: 
                    if(accumulator == 0)
                    {
                        Console.WriteLine("Numbers are equal");
                        instuctionCounter = operand;
                    }
                    break;

                case 43:
                    Console.WriteLine("*** Simpletron execution terminated ***");
                    break;




            }
        }


    }

    class MainClass {

        static void Main(string[] args)
        {
            Simpletron simpletron = new Simpletron();   
            int input;
            int counter = 0;
            Console.WriteLine("*** Welcome to Simpletron! ***");
            Console.WriteLine("*** Please enter your program one instruction ***");
            Console.WriteLine("*** ( or data word ) at a time into the input ***");
            Console.WriteLine("*** text field. I will display the location ***");
            Console.WriteLine("*** number and a question mark (?). You then ***");
            Console.WriteLine("*** type the word for that location. Enter ***");
            Console.WriteLine("*** -99999 to stop entering your program. ***");

            do
            {

                Console.Write("0{0} ? ", counter);
                input = int.Parse(Console.ReadLine());
                simpletron.memory[counter] = input;
                counter++;

            } while (input != -99999);

            Console.WriteLine("*** Program loading completed ***");
            Console.WriteLine("*** Program execution begins ***");

            simpletron.Run();
            simpletron.Print();
        }
    }
}

