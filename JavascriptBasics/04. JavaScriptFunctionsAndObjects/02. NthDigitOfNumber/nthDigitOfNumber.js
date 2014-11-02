//Write a JavaScript function findNthDigit(arr) that accepts as a parameter an array of two numbers
//num and n and returns the n-th digit of given decimal number num counted from right to left.
//Return undefined when the number does not have n-th digit.
//Write a JS program nthDigitOfNumber.js that invokes your function
//with the sample input data below and prints the output at the console.

function findNthDigit(arr) {
	'use strict';

	var n = arr[0],
		rawNumAsString = arr[1].toString(),
		numAsString = rawNumAsString.split('.').join(''),
		reversedNumAsString = numAsString.split('').reverse().join(''),
		result = reversedNumAsString[n  - 1];

	console.log(result);
}

findNthDigit([1, 6]);
findNthDigit([2, -55]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);