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

        // Additional functions

        // 1. Find the maximum value in the array
        int max = FindMax(numbers);
        Console.WriteLine("Maximum value: " + max);

        // 2. Find the minimum value in the array
        int min = FindMin(numbers);
        Console.WriteLine("Minimum value: " + min);

        // 3. Calculate the sum of all elements in the array
        int sum = CalculateSum(numbers);
        Console.WriteLine("Sum of elements: " + sum);

        // 4. Calculate the average of all elements in the array
        double average = CalculateAverage(numbers);
        Console.WriteLine("Average of elements: " + average);

        // 5. Find the index of a specific element in the array
        int target = 6;
        int index = FindIndexOfElement(numbers, target);
        Console.WriteLine("Index of " + target + ": " + index);

        // 6. Reverse the array
        ReverseArray(numbers);
        Console.WriteLine("Reversed array:");
        PrintArray(numbers);

        // 7. Count the occurrences of a specific element in the array
        int count = CountOccurrences(numbers, 5);
        Console.WriteLine("Occurrences of 5: " + count);

        // 8. Calculate the product of all elements in the array
        int product = CalculateProduct(numbers);
        Console.WriteLine("Product of elements: " + product);

        // 9. Check if the array is sorted in ascending order
        bool isAscending = IsSortedAscending(numbers);
        Console.WriteLine("Array is sorted in ascending order: " + isAscending);

        // 10. Check if the array is sorted in descending order
        bool isDescending = IsSortedDescending(numbers);
        Console.WriteLine("Array is sorted in descending order: " + isDescending);
    }

    static void PrintArray<T>(T[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    static int FindMax(int[] array)
    {
        int max = int.MinValue;
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    static int FindMin(int[] array)
    {
        int min = int.MaxValue;
        foreach (int num in array)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }

    static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    static double CalculateAverage(int[] array)
    {
        if (array.Length == 0)
            return 0;

        int sum = CalculateSum(array);
        return (double)sum / array.Length;
    }

    static int FindIndexOfElement(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1; // Element not found
    }

    static void ReverseArray<T>(T[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            left++;
            right--;
        }
    }

    static int CountOccurrences(int[] array, int target)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num == target)
            {
                count++;
            }
        }
        return count;
    }

    static int CalculateProduct(int[] array)
    {
        int product = 1;
        foreach (int num in array)
        {
            product *= num;
        }
        return product;
    }

    static bool IsSortedAscending(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static bool IsSortedDescending(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                return false;
            }
        }
        return true;
    }
}

interface ISortAlgorithm<T>
{
    void Sort(T[] array, bool ascending);
}

class Quicksort<T> : ISort
