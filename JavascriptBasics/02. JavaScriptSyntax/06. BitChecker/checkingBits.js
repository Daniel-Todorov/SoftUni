//Write a JavaScript function bitChecker(value) that finds if the bit 3 an integer number (counting from 0) is 1.
//Write JS program checkingBits.js to check a few numbers.
//The result (true or false) should be printed on the console.
//Run the program through Node.js.

'use strict';

function bitChecker(value) {
	var integerNumber = value || 0,
		mask = 1 << 3,
		isBitThreeOne = (integerNumber & mask) >> 3 === 1 ? true : false;

	console.log(isBitThreeOne);
}

bitChecker(333);
bitChecker(425);
bitChecker(2567564754);