// Quicksort.cs
public class Quicksort<T> : ISortAlgorithm<T> where T : IComparable<T>
{
    public void Sort(T[] array, bool ascending)
    {
        if (array == null || array.Length <= 1)
            return;

        QuicksortInternal(array, 0, array.Length - 1, ascending);
    }

    private void QuicksortInternal(T[] array, int low, int high, bool ascending)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, low, high, ascending);
            QuicksortInternal(array, low, partitionIndex - 1, ascending);
            QuicksortInternal(array, partitionIndex + 1, high, ascending);
        }
    }

    private int Partition(T[] array, int low, int high, bool ascending)
    {
        T pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if ((ascending && array[j].CompareTo(pivot) <= 0) ||
                (!ascending && array[j].CompareTo(pivot) >= 0))
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
