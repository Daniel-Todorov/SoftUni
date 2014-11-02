//Write a JavaScript function isPrime(value) that checks if an integer number is prime.
//Write JS program primeChecker.js that checks if a few numbers are prime.
//The result should be printed on the console (true or false) on the console.
//Run the program through Node.js.

'use strict';

function isPrime(value) {
	var integerNumber = value || 0,
		loopLimit = Math.sqrt(integerNumber),
		isPrimeNumber = true,
		divisionResult;

	if (integerNumber > 2) {
		for (var i = 2; i < loopLimit; i++) {
			if (integerNumber % i === 0) {
				isPrimeNumber = false;
				break;
			}
		}
	}

	console.log(isPrimeNumber);
}

isPrime(7);
isPrime(254);
isPrime(587);