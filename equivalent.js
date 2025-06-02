class Quicksort {
    sort(array, ascending) {
        if (array.length <= 1) {
            return array;
        }

        const pivot = array[0];
        const left = [];
        const right = [];

        for (let i = 1; i < array.length; i++) {
            if (array[i] < pivot) {
                left.push(array[i]);
            } else {
                right.push(array[i]);
            }
        }

        if (ascending) {
            return this.sort(left, true).concat(pivot, this.sort(right, true));
        } else {
            return this.sort(right, false).concat(pivot, this.sort(left, false));
        }
    }
}

function printArray(array) {
    console.log(array.join(', '));
}

function findMax(array) {
    return Math.max(...array);
}

function findMin(array) {
    return Math.min(...array);
}

function calculateSum(array) {
    return array.reduce((sum, num) => sum + num, 0);
}

function calculateAverage(array) {
    if (array.length === 0) return 0;

    const sum = calculateSum(array);
    return sum / array.length;
}

function findIndexOfElement(array, target) {
    return array.indexOf(target);
}

function reverseArray(array) {
    return array.slice().reverse();
}

function countOccurrences(array, target) {
    return array.filter(num => num === target).length;
}

function calculateProduct(array) {
    return array.reduce((product, num) => product * num, 1);
}

function isSortedAscending(array) {
    for (let i = 1; i < array.length; i++) {
        if (array[i] < array[i - 1]) {
            return false;
        }
    }
    return true;
}

function isSortedDescending(array) {
    for (let i = 1; i < array.length; i++) {
        if (array[i] > array[i - 1]) {
            return false;
        }
    }
    return true;
}

const numbers = [7, 2, 1, 6, 8, 5, 3, 4];
const sorter = new Quicksort();

console.log('Original array:');
printArray(numbers);

const ascendingSorted = sorter.sort(numbers.slice(), true);
console.log('Array sorted in ascending order:');
printArray(ascendingSorted);

const descendingSorted = sorter.sort(numbers.slice(), false);
console.log('Array sorted in descending order:');
printArray(descendingSorted);

const max = findMax(numbers);
console.log('Maximum value:', max);

const min = findMin(numbers);
console.log('Minimum value:', min);

const sum = calculateSum(numbers);
console.log('Sum of elements:', sum);

const average = calculateAverage(numbers);
console.log('Average of elements:', average);

const target = 6;
const index = findIndexOfElement(numbers, target);
console.log(`Index of ${target}:`, index);

const reversed = reverseArray(numbers.slice());
console.log('Reversed array:');
printArray(reversed);

const occurrences = countOccurrences(numbers, 5);
console.log('Occurrences of 5:', occurrences);

const product = calculateProduct(numbers);
console.log('Product of elements:', product);

const ascending = isSortedAscending(numbers);
console.log('Array is sorted in ascending order:', ascending);

const descending = isSortedDescending(numbers);
console.log('Array is sorted in descending order:', descending);
