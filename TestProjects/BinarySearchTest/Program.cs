using System;
using Algorithms.Search;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 5, 7, 9, 11, 13 };
        int target = 7;

        int index = BinarySearch.binary_search(array, target);

        if (index >= 0)
        {
            Console.WriteLine($"Number {target} found on position {index}");
        }
        else
        {
            Console.WriteLine($"Number {target} not found");
        }
    }
}
