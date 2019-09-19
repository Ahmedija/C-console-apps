using System;

namespace Fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;



            bool Valid = false;
            int Number;


            while (Valid == false)
            {
                Console.Clear();
                Console.WriteLine("Welcome to fibonacci");
                Console.WriteLine("Please enter number of iterations: \n");
                string Input = Console.ReadLine();
                if (int.TryParse(Input, out Number))
                {
           
                    Valid = true;
                    for (int i = 0; i < Number; i++)
                    {
                        Console.Write(Fibonacci(i) + ", ");
           
                    }
                }
                else
                {
                    Console.WriteLine("\nNot an integer, please try again.");
                }

                Console.WriteLine("\n\nPress enter");
                Console.ReadLine();
            }
            


        }
    }
}


