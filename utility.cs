using System;
using System.Linq;

public static class ArrayUtility
{
    public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }
        return array;
    }

    public static void ShuffleArray<T>(T[] array)
    {
        Random random = new Random();
        int n = array.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    public static int[] CopyArray(int[] source)
    {
        return (int[])source.Clone();
    }

    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        return array1.Concat(array2).ToArray();
    }

    public static void PrintArray<T>(T[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}
