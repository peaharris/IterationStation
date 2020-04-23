using System;

namespace IterationMenu
{
    class MainClass
    {
          //Write a C# program from scratch to do the following:

          //Print out a menu of choices
          //1. Count To 100
          //2. Count Down From 100
          //3. Count To 100 By 2's
          //4. Exit
          //Accept the user's choice and perform the chosen action.
          //If the user did not choose 4. Exit, then after performing the action, repeat(menu, input, action).
          //Keep repeating(menu, input, action) until the user chooses 4. Exit.

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

        static void PrintMenu()
        {
            Console.WriteLine("Please choose one of the following: ");
            Console.WriteLine("1. Count To 100");
            Console.WriteLine("2. Count Down From 100");
            Console.WriteLine("3. Count To 100 By 2's");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choice: ");

        }

        static void CountTo100By2s()
        {
            for (int i = 0; i < 101; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
