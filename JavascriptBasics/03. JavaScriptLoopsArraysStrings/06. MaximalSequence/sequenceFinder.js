//Write a JavaScript function findMaxSequence(value) that finds the maximal sequence of equal elements
//in an array and returns the result as an array.
//If there is more than one sequence with the same maximal length, print the rightmost one.
//Write JS program sequenceFinder.js that invokes your function with
//the sample input data below and prints the output at the console.

function findMaxSequence(array) {
	'use strict';

	var maxSequenceArray = [],
		currentSequenceArray = [],
		arrayLength = array.length;

	for (var i = 0; i < arrayLength; i++) {
		currentSequenceArray.push(array[i]);

		while(array[i] === array[i+1]){
			currentSequenceArray.push(array[i+ 1]);
			i++;
		}

		if (currentSequenceArray.length >= maxSequenceArray.length) {
			maxSequenceArray = currentSequenceArray;
		}

		currentSequenceArray = [];
	}

	console.log(maxSequenceArray);
}

findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
findMaxSequence(['happy']);
findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);