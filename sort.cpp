// sorting_algorithm.cpp
#include <iostream>

template <typename T>
void QuickSort(T* array, int low, int high, bool ascending) {
    if (low < high) {
        int partitionIndex = Partition(array, low, high, ascending);
        QuickSort(array, low, partitionIndex - 1, ascending);
        QuickSort(array, partitionIndex + 1, high, ascending);
    }
}

template <typename T>
int Partition(T* array, int low, int high, bool ascending) {
    T pivot = array[high];
    int i = low - 1;

    for (int j = low; j < high; j++) {
        if ((ascending && array[j] <= pivot) ||
            (!ascending && array[j] >= pivot)) {
            i++;
            std::swap(array[i], array[j]);
        }
    }

    std::swap(array[i + 1], array[high]);
    return i + 1;
}
