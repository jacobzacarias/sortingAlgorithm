using System;
using System.IO;

public static class FileIO
{
    public static void SaveArrayToFile(string filePath, int[] array)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (int num in array)
            {
                writer.WriteLine(num);
            }
        }
    }

    public static int[] LoadArrayFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("File not found.", filePath);
        }

        string[] lines = File.ReadAllLines(filePath);
        int[] array = new int[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            if (!int.TryParse(lines[i], out array[i]))
            {
                throw new FormatException($"Error parsing line {i + 1}: {lines[i]}");
            }
        }
        return array;
    }
}
