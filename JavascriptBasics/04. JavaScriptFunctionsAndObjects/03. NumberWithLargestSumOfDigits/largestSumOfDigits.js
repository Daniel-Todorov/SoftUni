//Write a JavaScript function findLargestBySumOfDigits(nums) that takes as an input a sequence of positive integer numbers
//and returns the element with the largest sum of its digits.
//The function should take a variable number of arguments.
//It should return undefined when 0 arguments are passed or when some of the arguments is not an integer number.
//Write a JS program largestSumOfDigits.js that invokes your function
//with the sample input data below and prints its output at the console.

//NOTE!!! Error in the problem definition. As first it says - positive integer numbers but later it says - integer numbers.
//In the example input -99 is displayed as valid number.

function findLargestBySumOfDigits() {
	'use strict';

	var input = arguments,
		numberOfElements = input.length,
		currentElementAsString,
		numberOfDigitsInCurrentElement,
		maxElement,
		currentSumOfDigits = 0,
		maxSumOfDigits = -1;

	if (numberOfElements <= 0) {
		return undefined;
	}

	for (var i = 0; i < numberOfElements; i++) {
		if (typeof input[i] !== 'number') {
			return undefined;
		} else if (input[i].toString().search(/\./) >= 0){
			return undefined;
		}

		currentElementAsString = input[i].toString().split('-').join('');
		numberOfDigitsInCurrentElement = currentElementAsString.length;
		for (var j = 0; j < numberOfDigitsInCurrentElement; j++) {
			currentSumOfDigits += parseInt(currentElementAsString[j]);
		}

		if (currentSumOfDigits > maxSumOfDigits) {
			maxSumOfDigits = currentSumOfDigits;
			maxElement = input[i];
		}

		currentSumOfDigits = 0;
	}

	return maxElement;
}

console.log(findLargestBySumOfDigits(5, 10, 15, 111));
console.log(findLargestBySumOfDigits(33, 44, -99, 0, 20));
console.log(findLargestBySumOfDigits('hello'));
console.log(findLargestBySumOfDigits(5, 3.3));