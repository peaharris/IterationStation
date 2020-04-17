using System;

namespace IterationMenu
{
    class MainClass
    {
         public static void Main(string[] args)
         {
            int userChoice;

            do
            {
                PrintMenu();
                userChoice= int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {
                    for (int i = 0; i < 101; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if ( userChoice == 2)
                {
                    for (int i = 100; i >= 0; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (userChoice == 3)
                {
                    CountTo100By2s();
                }
                else if (userChoice < 1 || userChoice > 4)
                {
                    Console.WriteLine("Error");
                }
            } while (userChoice != 4);

            Console.WriteLine("All Done!");
        }

        static void CountTo100By2s()
        {
            for (int i = 0; i < 101; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("Please choose one of the following: ");
            Console.WriteLine("1. Count To 100");
            Console.WriteLine("2. Count Down From 100");
            Console.WriteLine("3. Count To 100 By 2's");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choice: ");

        }
    }
}
