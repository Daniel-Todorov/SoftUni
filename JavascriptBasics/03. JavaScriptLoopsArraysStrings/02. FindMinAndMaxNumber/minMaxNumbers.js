//02. Write a JavaScript function findMinAndMax(value) that accepts as parameter an array of numbers.
//The function finds the minimum and the maximum number.
//Write a JS program minMaxNumbers.js that invokes your function with
//the sample input data below and prints the output at the console.

function findMinAndMax(arrayOfNumbers) {
	'use strict';

	var maxNumber = -Infinity,
		minNumber = Infinity,
		numbersCount = arrayOfNumbers.length;

	for (var i = 0; i < numbersCount; i++) {
		if (arrayOfNumbers[i] > maxNumber) {
			maxNumber = arrayOfNumbers[i];
		}
		if (arrayOfNumbers[i] < minNumber) {
			minNumber = arrayOfNumbers[i];
		}
	}

	console.log('Min -> ' + minNumber);
	console.log('Max -> ' + maxNumber);
}

findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]);
findMinAndMax([2, 2, 2, 2, 2]);
findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]);