//Sorting an array means to arrange its elements in increasing order. 
//Write a JavaScript function sortArray(value) to sort an array. 
//Use the "selection sort" algorithm: 
//-find the smallest element, 
//-move it at the first position, 
//-find the smallest from the rest, 
//-move it at the second position, etc. 
//Write JS program arraySorter.js that invokes your function 
//with the sample input data below and prints the output at the console. 
//Use a second array. 

function sortArray(arrayToSort) {
	'use strict';

	var sortedArray = [];

	while (arrayToSort.length > 0){
		sortedArray.push(findSmallestElement(arrayToSort));
	}

	function findSmallestElement() {
		var smallestElement = arrayToSort[0],
			arrayLength = arrayToSort.length;

		for (var i = 1; i < arrayLength; i++) {
			if (smallestElement > arrayToSort[i]) {
				smallestElement = arrayToSort[i];
			}
		}

		arrayToSort.splice(arrayToSort.indexOf(smallestElement), 1);

		return smallestElement;
	}

	console.log(sortedArray);
}

sortArray([5, 4, 3, 2, 1]);
sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);