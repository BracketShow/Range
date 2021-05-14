using System;
using System.Linq;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };

            var j = 0;
            var range = new string[3];
            for (int i = 2; i < 5; i++)
            {
                range[j++] = words[i];
            }

            Console.WriteLine($"{String.Join(" ", range)}");
        }
    }
}
