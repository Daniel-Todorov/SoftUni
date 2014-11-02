//01. Write a JavaScript function printNumbers(n) that accepts as parameter integer n.
//The function finds all integer numbers from 1 to n that are not divisible by 4 or by 5.
//Write a JS program numberChecker.js that invokes your function with
//the sample input data below and prints the output at the console.

function printNumbers(n) {
	'use strict';

	var numbersFulfillingCondition = [];

	if (n <= 0) {
		console.log('no');

		return;
	}

	for (var i = 1; i <= n; i++) {
		if (i % 4 !== 0 && i % 5 !== 0) {
			numbersFulfillingCondition.push(i);
		}
	}

	console.log(numbersFulfillingCondition.join(', '));
}

printNumbers(20);
printNumbers(-5);
printNumbers(13);