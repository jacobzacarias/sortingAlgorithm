public class QuickSort<T> : ISortAlgorithm<T> where T : IComparable<T>
{
    public void Sort(T[] array, bool ascending)
    {
        if (array == null || array.Length <= 1)
            return;

        if (ascending)
            QuickSortAscending(array, 0, array.Length - 1);
        else
            QuickSortDescending(array, 0, array.Length - 1);
    }

    private void QuickSortAscending(T[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = PartitionAscending(array, low, high);
            QuickSortAscending(array, low, partitionIndex - 1);
            QuickSortAscending(array, partitionIndex + 1, high);
        }
    }

    private int PartitionAscending(T[] array, int low, int high)
    {
        T pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j].CompareTo(pivot) < 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private void QuickSortDescending(T[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = PartitionDescending(array, low, high);
            QuickSortDescending(array, low, partitionIndex - 1);
            QuickSortDescending(array, partitionIndex + 1, high);
        }
    }

    private int PartitionDescending(T[] array, int low, int high)
    {
        T pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j].CompareTo(pivot) > 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private void Swap(T[] array, int i, int j)
    {
        T temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
