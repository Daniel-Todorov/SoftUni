//Write a JavaScript function createArray(value) that allocates array of 20 integers
//and initializes each element by its index multiplied by 5.
//Write JS program arrayBuilder.js that invokes your function
//with the sample input data below and prints the output at the console.

function createArray(numberOfElements) {
	'use strict';

	var array = new Array(numberOfElements);

	for (var i = 0; i < numberOfElements; i++) {
		array[i] = i * 5;
	}

	return array;
}

var array = createArray(20);

console.log(array.join(', '));