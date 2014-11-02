//Write a JavaScript function reverseString(value) that reverses string and returns it.
//Write JS program stringReverser.js that invokes your function
//with the sample input data below and prints the output at the console.

function reverseString(stringToReverse) {
	'use strict';

	var stringLength = stringToReverse.length,
		reversedString = [];

	for (var i = stringLength - 1; i >= 0; i--) {
		reversedString.push(stringToReverse[i]);
	}

	console.log(reversedString.join(''));
}

reverseString('sample');
reverseString('softUni');
reverseString('java script');