using System;
using static System.Console;

namespace bootcamp.Solutions
{
    class Trash
    { public void Problem() // Masal
        {
            for(int i = 2; i <= 10; i++)
            {
                int fact = i;
                System.Console.Write($"{i}!=");

                for(int k = 1; k < i; k++)
                {
                    Console.Write($"{k}*");
                    fact *= k;
                }
                Console.WriteLine($"{i}={fact}");
            }
        }
    }
}