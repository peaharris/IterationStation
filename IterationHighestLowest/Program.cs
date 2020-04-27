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
            Random r = new Random();  //this generates a random variable
            int randomNumber = r.Next(1, 100);  //this creates an int variable called randomNumber and generates a value from 1 to 100
                                                // Console.WriteLine(randomNumber);  //this checks the randomNumber value


            // D O  W H I L E  L O O P
            //this gurantees that you will go through the loop at least once
            int userGuess = 0;

            do
            {
                Console.Write("Try and guess the number in my head: "); //asks the user for a number
                userGuess = int.Parse(Console.ReadLine()); //turns that user input into an int variable called userGuess


                if (userGuess > randomNumber) //if the guess is too high
                {
                    Console.WriteLine("You are too high! Guess again.");
                }
                else if (userGuess < randomNumber) //if the guess is too low
                {
                    Console.WriteLine("You are too low! Guess again.");
                }
            } while (userGuess != randomNumber); //when the userGuess is NOT equal to randomNumber, it starts the do loop again
            //when the userGuess does = randomNumber than it exits the do while loop

            Console.Write("Congratulations! You Guessed it! What are the chances?!");



            // W H I L E  L O O P
            //Used when you dont know how many times you will go through the loop

            //Console.Write("Try and guess the number in my head: ");
            //int userGuess = int.Parse(Console.ReadLine());   

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




            // F O R  L O O P
            //for loops are usually used for counting, and used the most


            //for (int userGuess = -1; userGuess != randomNumber; )  //-1 will always fail in the loop because it is not 1 to 100
            //    //no third statement, this will still work, the iterator (incrementer) is empty
            //{
            //    Console.Write("Try and guess the number in my head: "); //asks the user for a number
            //    userGuess = int.Parse(Console.ReadLine()); //turns that user input into an int variable called userGuess


            //    if (userGuess > randomNumber) //if the guess is too high
            //    {
            //        Console.WriteLine("You are too high! Guess again.");
            //    }
            //    else if (userGuess < randomNumber) //if the guess is too low
            //    {
            //        Console.WriteLine("You are too low! Guess again.");
            //    }

            //}   Console.Write("Congratulations! You Guessed it! What are the chances?!");
        }
    }
}
