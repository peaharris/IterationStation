using System;

namespace DemoLoops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //WHILE LOOP
            //int i = 1;
            //while (i < 5 && i >0 || i ==239)
            //{
            //Console.WriteLine(i);
            //i++;
            //}
            //WHILE LOOP EX 2
            int i = 1;
            while ( i < 5 )
            {
                Console.WriteLine("i = " + i);
                i++;

                if ( i == 3 )
                {
                    continue; //skips all the other lines returns to the while expresion
                    //break;  you stop the loop and finish 
                }

                Console.WriteLine("i squared = " + i * i);
            }


            //FOR LOOP
            //for ( int i = 0 ; i < 5 ; i++)
            //{
            //Console.WriteLine(i);
            //Console.WriteLine(i * i);
            //}

            //DO WHILE LOOP  goo for menu type of thing
            do
            {
                Console.WriteLine(i);
                Console.WriteLine(i * i);
                i++;
            } while (i <= 5);
        }
    }
}
