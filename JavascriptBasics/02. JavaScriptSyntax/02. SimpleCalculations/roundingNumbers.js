//Write a JavaScript function roundNumber(value) that rounds floating-point number using Math.round(), Math.floor().
//Write a JS program roundingNumbers.js that rounds a few sample values.
//Run the program through Node.js.

'use strict';

function roundNumber(value) {
	var numberToRound = value || 0,
		roundedByRound = Math.round(numberToRound),
		roundedByFloor = Math.floor(numberToRound);

	console.log(roundedByFloor);
	console.log(roundedByRound);
}

roundNumber(22.7);
roundNumber(12.3);
roundNumber(58.7);