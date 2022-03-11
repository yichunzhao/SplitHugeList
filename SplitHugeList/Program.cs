using System;
using System.Collections.Generic;

namespace SplitHugeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {2, 4, 90, 30, 40, 29, 76, 33, 12, 34};
            Console.WriteLine(string.Join(",",numbers));

            // for (int i = 0; i < numbers.Count; i++)
            // {
            //     Console.WriteLine(numbers[i]);
            // }
        }
    }
}