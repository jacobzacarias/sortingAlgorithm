#include <iostream>
#include <cmath>
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

    // Calculate the square of each number
    for (int i = 0; i < size; i++) {
        numbers[i] *= numbers[i];
    }

    // Sort the array of squared values in ascending order
    QuickSort(numbers, 0, size - 1, true);

    std::cout << "Array sorted by squared values in ascending order:" << std::endl;
    PrintArray(numbers, size);

    // Calculate the square root of each squared value
    for (int i = 0; i < size; i++) {
        numbers[i] = static_cast<int>(std::sqrt(numbers[i]));
    }

    // Sort the array of square root values in ascending order
    QuickSort(numbers, 0, size - 1, true);

    std::cout << "Array sorted by square root of squared values in ascending order:" << std::endl;
    PrintArray(numbers, size);

    return 0;
}
