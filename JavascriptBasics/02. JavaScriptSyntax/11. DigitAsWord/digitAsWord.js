//Write a JavaScript function convertDigitToWord(value) that prints the name of an integer number n (0<n<10)
//in English using switch statement.
//Write JS program digitAsWord.js that prints a few digits on the console.
//Run the program through Node.js.

'use strict';

function convertDigitToWord(n) {
	var englishNameOfDigit;

	switch (n) {
		case 1: englishNameOfDigit = 'one'; break;
		case 2: englishNameOfDigit = 'two'; break;
		case 3: englishNameOfDigit = 'three'; break;
		case 4: englishNameOfDigit = 'four'; break;
		case 5: englishNameOfDigit = 'five'; break;
		case 6: englishNameOfDigit = 'six'; break;
		case 7: englishNameOfDigit = 'seven'; break;
		case 8: englishNameOfDigit = 'eight'; break;
		case 9: englishNameOfDigit = 'nine'; break;
		defeault: englishNameOfDigit = 'unsupported digit'; break;
	}

	console.log(englishNameOfDigit);
}

convertDigitToWord(8);
convertDigitToWord(3);
convertDigitToWord(5);