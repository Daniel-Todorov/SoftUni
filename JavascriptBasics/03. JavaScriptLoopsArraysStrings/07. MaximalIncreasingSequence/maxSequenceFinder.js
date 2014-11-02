//Write a JavaScript function findMaxSequence(value) that finds the maximal increasing sequence 
//in an array of numbers and returns the result as an array. 
//If there is no increasing sequence the function returns 'no'.
//Write JS program maxSequenceFinder.js that invokes your function 
//with the sample input data below and prints the output at the console. 

function findMaxSequence(arrayOfNumbers) {
	'use strict';

	var maxIncreasingSequence = [],
		currentIncreasingSequence = [],
		arrayLength = arrayOfNumbers.length;

	for (var i = 0; i < arrayLength; i++) {
		currentIncreasingSequence.push(arrayOfNumbers[i]);

		while(arrayOfNumbers[i] < arrayOfNumbers[i+1]){
			currentIncreasingSequence.push(arrayOfNumbers[i+ 1]);
			i++;
		}

		if (currentIncreasingSequence.length >= maxIncreasingSequence.length) {
			maxIncreasingSequence = currentIncreasingSequence;
		}

		currentIncreasingSequence = [];
	}

	if (maxIncreasingSequence.length > 1) {
		console.log(maxIncreasingSequence);
	} else {
		console.log('no');
	}
}

findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
findMaxSequence([3, 2, 1]);