//Write a JavaScript function findMostFreqNum(value) that finds the most frequent number in an array. 
//If multiple numbers appear the same maximal number of times, print the leftmost of them. 
//Write JS program numberFinder.js that invokes your function 
//with the sample input data below and prints the output at the console. 

function findMostFreqNum(arrayOfNumbers) {
	'use strict';

	var arrayOfNumbersLength = arrayOfNumbers.length,
		sortedNumbers = {},
		mostFrequentNumber,
		maxNumberFrequency = 0;

	for (var i = 0; i < arrayOfNumbersLength; i++) {
		if (sortedNumbers[arrayOfNumbers[i]] === undefined) {
			sortedNumbers[arrayOfNumbers[i]] = 1;
		} else {
			sortedNumbers[arrayOfNumbers[i]]++;
		}
	}

	for (var number in sortedNumbers) {
		if (sortedNumbers[number] > maxNumberFrequency) {
			maxNumberFrequency = sortedNumbers[number];
			mostFrequentNumber = number;
		}
	}

	console.log(mostFrequentNumber + ' (' + maxNumberFrequency + ' times)');
}

findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);