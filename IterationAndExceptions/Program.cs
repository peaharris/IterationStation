using System;

namespace QuizWeek5
{
    class MainClass
    {
        //The week 5 C# Quiz covers Iteration and Exceptions (Chapters 5 & 6) 
        //Using Visual Studio, create a new project and write a piece of C# code that does the following:

        //Prompts the user for a starting number.
        //Inputs a starting number into an integer variable.
        //Prompts the user for an ending number.
        //Inputs an ending number into a different integer variable.
        //Prints out all the numbers from the starting number up to and including the ending number. For example, if the user enters 10 as the start and 15 as the end, your program should print out 10, 11, 12, 13, 14, and 15.
        //If the user enters anything other than a valid integer for either number (start or end), this code should print out "Seriously?!" and end.

        //Do not use any Methods - your code should all be in Main().
        //Do not use any if statements or switch statements.

        public static void Main(string[] args)
        {
            int startNumber = 0;
            int endNumber = 1;

            try
            {
                Console.WriteLine("Please enter a starting number: "); //Prompts the user for a starting number.
                startNumber = int.Parse(Console.ReadLine()); //Inputs a starting number into an integer variable.
                Console.WriteLine("Please enter an ending number: "); //Prompts the user for an ending number.
                endNumber = int.Parse(Console.ReadLine());        //Inputs an ending number into a different integer variable.
            }
            catch (Exception e)
            {
                Console.WriteLine("Seriously?");//If the user enters anything other than a valid integer for either number (start or end), this code should print out "Seriously?!" and end.
            }

			do
			{
				Console.WriteLine(startNumber);//Prints out all the numbers from the starting number up to and including the ending number.
				startNumber++;
			} while (startNumber <= endNumber);

			//Bonus / Extra Credit(5 points): Before printing out any of the numbers, prompt the user for a third value
			//- an increment or step - and input that into an integer variable.Now, when your program prints out the
			//numbers requested, have it print the numbers out by that increment.For example, if the user enters 100 as
			//the start, 125 as the end, and 7 as the increment, your program should print out 100, 107, 114, and 121.

			int increment = 0;

            try
            {
                Console.WriteLine("Please enter a third value: ");
                increment = int.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("Seriously?");//If the user enters anything other than a valid integer for either number (start or end), this code should print out "Seriously?!" and end.
            }

            do
            {
                Console.WriteLine(startNumber);//Prints out all the numbers from the starting number up to and including the ending number.
                startNumber += increment; //when your program prints out the numbers requested, have it print the numbers out by that increment
            } while (startNumber <= endNumber);
        }
    }
}
