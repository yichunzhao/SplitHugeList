using System;
using System.Collections.Generic;

namespace SplitHugeList
{
    class Program
    {
        private static int PIECE_SIZE = 9;

        static void Main(string[] args)
        {
            var numbers = new List<int>() {2, 4, 90, 30, 40, 29, 76, 33, 12, 34, 45, 78, 98};
            Console.WriteLine(string.Join(",", numbers));

            var length = numbers.Count;

            var iteration = length / PIECE_SIZE;
            var remaining = length % PIECE_SIZE;

            Console.WriteLine("Iteration and remainder : " + string.Join(",", iteration, remaining));

            for (var i = 0; i < iteration; i++)
            {
                Console.WriteLine(string.Join(",", numbers.GetRange(i * PIECE_SIZE, PIECE_SIZE)));
            }

            // printout reminder; 
            Console.WriteLine("reminder: " + string.Join(",", numbers.GetRange(iteration * PIECE_SIZE, remaining)));
        }
    }
}