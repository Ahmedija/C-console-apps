using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using Zadatci_1;

namespace Zadatci_1
{

    public class UserTask
    {
        public UserTask(string Description)
        {
            this.UserInput = Description;
        }
        public string UserInput { get; set; }
        public override string ToString()
        {
            return UserInput;
        }
    }

}

namespace C_TaskManager
{
    internal class Program
    {
   
        private static int ReadInt32FromConsole()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry. Try again.");
                return -1;
            }
        }

        private static double ReadDoubleFromConsole()
        {
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry. Try again.");
                return -1;
            }
        }



        private static void Main(string[] args)
        {
            int num = 0;

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Please select what data type would you like to sort?");
                Console.WriteLine("1. Integers");
                Console.WriteLine("2. Doubles");
                Console.WriteLine("3. String");
                Console.WriteLine("4. EXIT");
                Console.WriteLine("---------------------------------------");

                num = ReadInt32FromConsole();

                switch (num)
                {

                    case 1:
                        {
                            int input;
                            int temp;


                            Console.WriteLine("Please enter how many integers would you like to input: ");
                            try
                            {
                                input = ReadInt32FromConsole();

                                int[] arr = new int[input];

                                Console.WriteLine("Please enter " + input + " integers: ");


                                int counter = 0;


                                //Do while loop for array elements user input
                                do {
                                    Console.Write("Enter " + counter + " element of the array: ");

                                    //Validation for user input of each element in array
                                    arr[counter] = ReadInt32FromConsole();
                                    if (arr[counter] != -1)
                                    {
                                        counter++;
                                    }
                                } while (counter < input);


                                //Bubble sort
                                for (int j = 0; j <= arr.Length - 2; j++)
                                {
                                    for (int i = 0; i <= arr.Length - 2; i++)
                                    {
                                        if (arr[i] > arr[i + 1])
                                        {
                                            temp = arr[i + 1];
                                            arr[i + 1] = arr[i];
                                            arr[i] = temp;
                                        }
                                    }
                                }

                                //Printing sorted array
                                Console.WriteLine("Sorted:");
                                foreach (int p in arr)
                                    Console.Write(p + " ");
                                Console.WriteLine("\nPress enter to continue.");
                                Console.Read();

                            }
                            catch
                            {

                            }


                        }
                        break;

                    case 2:
                        {
                            int input;
                            double temp;


                            Console.WriteLine("Please enter how many doubles would you like to input: ");
                            try
                            {
                                input = ReadInt32FromConsole();

                                double[] arr = new double[input];

                                Console.WriteLine("Please enter " + input + " doubles: ");


                                int counter = 0;


                                //Do while loop for array elements user input
                                do
                                {
                                    Console.Write("Enter " + counter + " element of the array: ");

                                    //Validation for user input of each element in array
                                    arr[counter] = ReadDoubleFromConsole();
                                    if (arr[counter] != -1)
                                    {
                                        counter++;
                                    }
                                } while (counter < input);


                                //Bubble sort
                                for (int j = 0; j <= arr.Length - 2; j++)
                                {
                                    for (int i = 0; i <= arr.Length - 2; i++)
                                    {
                                        if (arr[i] > arr[i + 1])
                                        {
                                            temp = arr[i + 1];
                                            arr[i + 1] = arr[i];
                                            arr[i] = temp;
                                        }
                                    }
                                }

                                //Printing sorted array
                                Console.WriteLine("Sorted:");
                                foreach (double p in arr)
                                    Console.Write(p + " ");
                                Console.WriteLine("\nPress enter to continue.");
                                Console.Read();


                            }
                            catch
                            {

                            }
                        }
                        break;      
                    case 3:
                        {

                            string[] arr;
                            string temp;
                            int input, i, j, l;


                            Console.WriteLine("Please enter how many strings would you like to input: ");



                            try
                            {
                                input = ReadInt32FromConsole();
                                arr = new string[input];
                                char[] letters = new char[input];
                                int counter = 0;

                                Console.WriteLine("Please enter " + input + " strings: ");




                                for (i = 0; i < input; i++)
                                {
                                    Console.WriteLine("Enter " + i + " element of the array: ");

                                    arr[i] = Console.ReadLine();

                                }



                                l = arr.Length;

                                for (i = 0; i < l; i++)
                                {
                                    for (j = 0; j < l - 1; j++)
                                    {
                                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                                        {
                                            temp = arr[j];
                                            arr[j] = arr[j + 1];
                                            arr[j + 1] = temp;
                                        }
                                    }
                                }
                                Console.Write("\n\nAfter sorting the array appears like : \n");

                                for (i = 0; i < l; i++)
                                {
                                    Console.WriteLine(arr[i] + " ");
                                }
                            }



                            catch
                            {

                            }





                        }
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Press a key to return to main menu...");
                Console.ReadKey();
            } while (num != 4);

        }


    }


}
