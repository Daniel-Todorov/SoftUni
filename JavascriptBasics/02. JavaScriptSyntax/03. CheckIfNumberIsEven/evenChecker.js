//Write a JavaScript function evenNumber(value) that checks if an integer number is even.
//Write JS program evenChecker.js to check if a few numbers are even.
//The result should be printed on the console (true or false).
//Run the program through Node.js.

'use strict';

function evenNumber(value) {
	var integerNumber = value || 0,
		isEven = false;

	if (integerNumber % 2 === 0) {
		isEven = true;
	}

	console.log(isEven);
}

evenNumber(3);
evenNumber(127);
evenNumber(588);