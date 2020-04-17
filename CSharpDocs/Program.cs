using System;
using System.Collections.Generic;

namespace CSharpDocs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var names = new List<string> { "Priscilla", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
