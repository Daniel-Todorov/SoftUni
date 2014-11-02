//Write a JavaScript function lastDigitAsText(number) that returns the last digit of given integer as an English word. 
//Write a JS program lastDigitOfNumber.js that invokes your function 
//with the sample input data below and prints the output at the console. 

function lastDigitAsText(number) {
	'use strict';

	var numberAsString = number.toString(),
		lastDigitAsString = numberAsString[numberAsString.length - 1],
		lastDigitAsWord;

	switch (lastDigitAsString) {
		case '0': lastDigitAsWord = 'Zero'; break;
		case '1': lastDigitAsWord = 'One'; break;
		case '2': lastDigitAsWord = 'Two'; break;
		case '3': lastDigitAsWord = 'Three'; break;
		case '4': lastDigitAsWord = 'Four'; break;
		case '5': lastDigitAsWord = 'Five'; break;
		case '6': lastDigitAsWord = 'Six'; break;
		case '7': lastDigitAsWord = 'Seven'; break;
		case '8': lastDigitAsWord = 'Eight'; break;
		case '9': lastDigitAsWord = 'Nine'; break;
		default:
			throw new Error('Invalid last digit!');
	}

	console.log(lastDigitAsWord);
}

lastDigitAsText(6);
lastDigitAsText(-55);
lastDigitAsText(133);
lastDigitAsText(14567);