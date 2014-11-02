//Write a JavaScript function divisionBy3(value) that finds the sum of digits of integer number n (n > 9)
//and checks if the sum is divided by 3 without remainder.
//Write JS program divisionChecker.js to check a few numbers.
//The result should be printed on the console (“the number is divided by 3 without remainder”
//or “the number is not divided by 3 without remainder”).
//Run the program through Node.js.

//NOTE!!! The second test in the homework file is wrong. 189 IS divided by 3 without remainder.

'use strict';

function divisionBy3(value) {
	var integerNumber = value || 0,
		stringifiedNumber = integerNumber.toString(),
		lengthOfStringifiedNumber = stringifiedNumber.length,
		sumOfDigits = 0,
		resultMessage = '';

	for (var i = 0; i < lengthOfStringifiedNumber; i++) {
		sumOfDigits += Number(stringifiedNumber[i]);
	}

	if (sumOfDigits % 3 === 0) {
		resultMessage = 'the number is divided by 3 without remainder';
	} else {
		resultMessage = 'the number is not divided by 3 without remainder';
	}

	console.log(resultMessage);
}

divisionBy3(12);
divisionBy3(189);
divisionBy3(591);
divisionBy3(59);