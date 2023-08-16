using System;

class Program
{
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] numbers = { 7, 2, 1, 6, 8, 5, 3, 4 };
        int size = numbers.Length;

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        // Sort the array in ascending order
        QuickSort(numbers, 0, size - 1, true);

        Console.WriteLine("Array sorted in ascending order:");
        PrintArray(numbers);

        // Sort the array in descending order
        QuickSort(numbers, 0, size - 1, false);

        Console.WriteLine("Array sorted in descending order:");
        PrintArray(numbers);
    }

    static void QuickSort(int[] array, int left, int right, bool ascending)
    {
        if (left < right)
        {
            int partitionIndex = Partition(array, left, right, ascending);
            QuickSort(array, left, partitionIndex - 1, ascending);
            QuickSort(array, partitionIndex + 1, right, ascending);
        }
    }

    static int Partition(int[] array, int left, int right, bool ascending)
    {
        int pivot = array[right];
        int partitionIndex = left;

        for (int i = left; i < right; i++)
        {
            if ((ascending && array[i] <= pivot) || (!ascending && array[i] >= pivot))
            {
                Swap(array, i, partitionIndex);
                partitionIndex++;
            }
        }

        Swap(array, partitionIndex, right);
        return partitionIndex;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
