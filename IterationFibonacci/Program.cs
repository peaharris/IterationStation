using System;

namespace IterationFibonacci
{
    class MainClass
    {
        //Background: The Fibonacci numbers are 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, and so on.
        //This sequence of numbers has a fairly straight-forward definition. There are two rules
        //(or formulas) that define the sequence:

        //The first two Fibonacci numbers are 0 and 1. This is by definition.
        //In order to to get any other Fibonacci number, the two previous Fibonacci numbers are added together.
        //This is by calculation or computation.

        //By these two rules, we see that 0 and 1 are the first two Fibonacci numbers. The third Fibonacci number
        //is the previous two added together (0 + 1 → 1). So the first three Fibonacci numbers are 0, 1, 1. The
        //fourth Fibonacci number is the previous two added together(1 + 1 → 2). So the first four Fibonacci numbers
        //are 0, 1, 1, 2. The fifth Fibonacci number is the previous two added together(1 + 2 → 3). So the first five
        //Fibonacci numbers are 0, 1, 1, 2, 3. And so on: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, . . .

        //Assignment: Write a program that will compute and print out the first 20 Fibonacci numbers, one on each
        //line.The computation and printing must be done inside of a loop.


        public static void Main(string[] args) //I KNOW THIS IS RIGHT BUT I DONT UNDERSTAND IT
        {
            for (int i = 0; i < 21; i++)
            {
                int a = 0;
                int b = 1;
                for (int c = 0; c < i; c++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                Console.WriteLine( a );
            }
        }
    }
}
