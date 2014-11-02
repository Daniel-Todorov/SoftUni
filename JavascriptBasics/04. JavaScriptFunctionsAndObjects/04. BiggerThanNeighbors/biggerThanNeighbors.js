//Write a JavaScript function biggerThanNeighbors(index,  arr) that accept a number and an integer array as parameters.
//The function should return a Boolean number: whether the element at the given position
//in the array is bigger than its two neighbors (when such exist).
//It should return undefined when the index doesn't exist.
//Write a JS program that invokes the function
//with the sample data below and prints the result at the console.

//NOTE!!! Again there is mismatch between the problem definition and the given example.
//I'm following the given example.

function biggerThanNeighbors(index,  arr) {
	'use strict';

	var result;

	if (typeof arr[index] === 'undefined') {
		result = 'invalid index';
	} else if (typeof arr[index - 1] === 'undefined' || typeof arr[index + 1] === 'undefined') {
		result = 'only one neighbor';
	} else if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) {
		result = 'bigger';
	} else {
		result = 'not bigger';
	}

	return result;
}

console.log(biggerThanNeighbors(2, [1, 2, 3, 3, 5]));
console.log(biggerThanNeighbors(2, [1, 2, 5, 3, 4]));
console.log(biggerThanNeighbors(5, [1, 2, 5, 3, 4]));
console.log(biggerThanNeighbors(0, [1, 2, 5, 3, 4]));