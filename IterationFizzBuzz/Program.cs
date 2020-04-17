using System;

namespace IterationFizzBuzz
{
    class MainClass
    {
        //Write a C# program (probably all in Main) that prints out the numbers from 1 to 100,
        //each one on a separate line. In addition, for every number that is divisible by 3,
        //next to the number, print out the word "Fizz". In addition, for every number that is
        //divisible by 5, next to the number, print out the word "Buzz". If a number is divisible
        //by both 3 and 5, next to the number, print out the words "Fizz Buzz".
        public static void Main(string[] args)
        {
            for ( int i = 1; i < 101; i++)
            {
                string divisbleThree = "Fizz";
                string divisbleFive = "Buzz";

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + divisbleThree + divisbleFive);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + divisbleThree);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + divisbleFive);
                }
                else
                    Console.WriteLine(i);
            }

            Console.WriteLine("All Done!");
        }
    }
}
