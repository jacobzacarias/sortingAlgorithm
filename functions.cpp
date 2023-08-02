// main.cpp
#include <iostream>
#include "sorting_algorithm.cpp"

void PrintArray(int* array, int size) {
    for (int i = 0; i < size; i++) {
        std::cout << array[i] << " ";
    }
    std::cout << std::endl;
}

int main() {
    int numbers[] = { 7, 2, 1, 6, 8, 5, 3, 4 };
    int size = sizeof(numbers) / sizeof(numbers[0]);

    std::cout << "Original array:" << std::endl;
    PrintArray(numbers, size);

    // Sort the array in ascending order
    QuickSort(numbers, 0, size - 1, true);

    std::cout << "Array sorted in ascending order:" << std::endl;
    PrintArray(numbers, size);

    // Sort the array in descending order
    QuickSort(numbers, 0, size - 1, false);

    std::cout << "Array sorted in descending order:" << std::endl;
    PrintArray(numbers, size);

    return 0;
}
