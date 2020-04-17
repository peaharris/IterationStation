using System;

namespace IterationHighestLowest
{
    class MainClass
    {   //Assignment: Start with the program below. It has 2 lines of starter code that generate a random number.
        //Finish the program so that it asks the user to try and guess the random number (between 1 and 100).
        //If the user guesses too high, tell the user so and let them guess again. If the user guesses too low,
        //tell the user so and let them guess again. Let the user guess over and over until they finally guess
        //correct. When they guess correct, tell them congratulations and end. The solution to this must use a loop.
        //Which specific loop is chosen is up to you. Once you get it working (and turned in), you might want to
        //try to see if you can get it working with each of the other two types of loops. One kind of loop will
        //probably be more difficult than the other two types.

        public static void Main(string[] args)
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 100);

            Console.Write("Try and guess the number in my head: ");
            int userGuess = int.Parse(Console.ReadLine());

            //I did it first as a do while loop, then as a while loop, it is commented out,
            //however I tried to do it in a for loop but not quite sure where to start

            //for (int userGuess = int.Parse(Console.ReadLine()); userGuess != randomNumber ; )

            do
            {
                if (userGuess > randomNumber)
                {
                    Console.WriteLine("You are too high! Guess again.");
                    userGuess = int.Parse(Console.ReadLine());
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("You are too low! Guess again.");
                    userGuess = int.Parse(Console.ReadLine());
                }
            } while (userGuess != randomNumber);

            Console.Write("Congratulations! Nice guess!");


            //while (userGuess != randomNumber)
            //{
            //    if (userGuess > randomNumber)
            //    {
            //        Console.WriteLine("You are too high! Guess again.");
            //        userGuess = int.Parse(Console.ReadLine());
            //    }
            //    else if (userGuess < randomNumber)
            //    {
            //        Console.WriteLine("You are too low! Guess again.");
            //        userGuess = int.Parse(Console.ReadLine());
            //    }
            //}
            //while (userGuess == randomNumber)
            //{
            //    Console.Write("Congratulations! Nice guess!");
            //    break;
            //}
        }
    }
}
