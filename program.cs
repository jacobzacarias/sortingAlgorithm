// Program.cs
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 7, 2, 1, 6, 8, 5, 3, 4 };

        // Choose the sorting algorithm (Quicksort in this case)
        ISortAlgorithm<int> sorter = new Quicksort<int>();

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        // Sort the array in ascending order
        sorter.Sort(numbers, true);

        Console.WriteLine("Array sorted in ascending order:");
        PrintArray(numbers);

        // Sort the array in descending order
        sorter.Sort(numbers, false);

        Console.WriteLine("Array sorted in descending order:");
        PrintArray(numbers);
    }

    static void PrintArray<T>(T[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}
