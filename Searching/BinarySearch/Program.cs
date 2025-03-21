using System;

class Program
{
    static int BinarySearch(int[] sortedArray, int target)
    {
        int left = 0;
        int right = sortedArray.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (sortedArray[mid] == target)
                return mid;

            if (sortedArray[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void RunTests()
    {
        int[] testArray = { 1, 3, 5, 7, 9, 11, 15 };

        Console.WriteLine(BinarySearch(testArray, 7) == 3 ? "Test 1 Passed" : "Test 1 Failed");
        Console.WriteLine(BinarySearch(testArray, 1) == 0 ? "Test 2 Passed" : "Test 2 Failed");
        Console.WriteLine(BinarySearch(testArray, 15) == 6 ? "Test 3 Passed" : "Test 3 Failed");
        Console.WriteLine(BinarySearch(testArray, 2) == -1 ? "Test 4 Passed" : "Test 4 Failed");
    }

    static void Main()
    {
        RunTests();
    }
}
