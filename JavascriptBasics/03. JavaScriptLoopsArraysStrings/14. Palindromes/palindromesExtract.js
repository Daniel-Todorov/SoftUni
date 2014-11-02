//Write a JavaScript function findPalindromes(value) that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
//Write JS program palindromesExtract.js that invokes your function
//with the sample input data below and prints the output at the console.

function findPalindromes(text) {
	'use strict';

	var words = text.split(/\W+/),
		numberOfWords = words.length,
		palindromes = [],
		isPalindrome,
		word,
		wordLength;

	for (var i = 0; i < numberOfWords; i++) {
		word = words[i].toLowerCase();
		wordLength = word.length;
		isPalindrome = true;
		if (wordLength > 0) {
			for (var j = 0; j < wordLength; j++) {
				if (word[0 + j] !== word[wordLength - 1 - j]) {
					isPalindrome = false;
				}
			}

			if (isPalindrome === true) {
				palindromes.push(word);
			}
		}
	}

	console.log(palindromes.join(', '));
}

findPalindromes('There is a man, his name was Bob.');