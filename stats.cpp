using System;
using System.Linq;

public static class StatisticsCalculator
{
    public static double CalculateMedian(int[] array)
    {
        if (array.Length == 0)
            throw new ArgumentException("Array cannot be empty.");

        var sortedArray = array.OrderBy(x => x).ToArray();
        int midIndex = array.Length / 2;

        if (array.Length % 2 == 0)
            return (sortedArray[midIndex - 1] + sortedArray[midIndex]) / 2.0;
        else
            return sortedArray[midIndex];
    }

    public static int CalculateMode(int[] array)
    {
        if (array.Length == 0)
            throw new ArgumentException("Array cannot be empty.");

        var groups = array.GroupBy(x => x);
        int maxFrequency = groups.Max(g => g.Count());
        return groups.First(g => g.Count() == maxFrequency).Key;
    }

    public static double CalculateVariance(int[] array)
    {
        if (array.Length == 0)
            throw new ArgumentException("Array cannot be empty.");

        double mean = array.Average();
        double sumOfSquares = array.Sum(x => Math.Pow(x - mean, 2));
        return sumOfSquares / array.Length;
    }

    public static double CalculateStandardDeviation(int[] array)
    {
        double variance = CalculateVariance(array);
        return Math.Sqrt(variance);
    }
}
