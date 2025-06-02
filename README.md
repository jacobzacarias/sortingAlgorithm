# Sorting Algorithm in C#

This C# program demonstrates the implementation of the Quicksort algorithm to efficiently sort a collection of elements in ascending or descending order. Quicksort is a widely used sorting algorithm due to its efficiency and average-case time complexity of O(n log n).

## Instructions

1. **Run the Program**: Open the C# project in an IDE and run the program. The main program logic is located in `Program.cs`.

2. **Sorting Algorithm**: The program uses the Quicksort algorithm to sort an array of integers. The Quicksort algorithm is implemented as a separate class that implements the `ISortAlgorithm` interface.

3. **Custom Sorting Algorithms**: You can better understand the inner workings by using a different sorting algorithm by creating a new class that implements the `ISortAlgorithm` interface with a different sorting algorithm's implementation, like merge sort or insertion sort.

4. **Sorting Order**: The program sorts the array in ascending order and then in descending order. You can change the sorting order by passing `true` or `false` as the second argument to the `Sort` method of the sorting algorithm.

5. **Printing the Array**: The `PrintArray` method is used to display the contents of the array on the console before and after sorting.

## File Structure

- `Program.cs`: Contains the main program logic, initializing the array and using the sorting algorithm to sort it in ascending and descending order.

- `ISortAlgorithm.cs`: Defines the interface `ISortAlgorithm`, which any sorting algorithm class must implement.

- `Quicksort.cs`: Contains the implementation of the Quicksort algorithm.

## Usage

1. Clone the repository or download the source code files.

2. Open the project in an integrated C# development environment.

3. Build and run the program.

4. See the original array and the sorted arrays in ascending and descending order that is shown in the output.

## Contribution

Please by all means free to contribute to this project by adding more sorting algorithms, improving existing ones, or enhancing the code's efficiency. Your contributions are highly appreciated!
