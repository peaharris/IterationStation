using System;

namespace IterationConvert
{
    class MainClass
    {
        public static void Main(string[] args)
            //Q: How are a for loop and a while loop similar?
                //A for loop and while loop are similiar because it can execute its statements multiple times over
                //they both contain a boolean expression within their parameters. Both can continue curly brackets,
                // continue and break statements. 
            //Q: How are a for loop and a while loop different?
                //For loops and whil loops differ because a while loop utilizes an existing variable and even
                //after the while loop curly brackets, that variable still exists after the loop is complete.
                //For loops have to create their own variables that only exist in it scope.

            //Given the code snippet below, convert the for loop into a while loop.

        {
            //for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine(i);
            //}

            int i = 1;
            while ( i <= 10)
            {
                Console.WriteLine(i);
                i ++;
            }
        }
    }
}
