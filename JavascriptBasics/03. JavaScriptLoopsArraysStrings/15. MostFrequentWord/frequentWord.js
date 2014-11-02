//Write a JavaScript function findMostFreqWord(value) that finds the most frequent word in a text and prints it, 
//as well as how many times it appears in format "word -> count". 
//Consider any non-letter character as a word separator. 
//Ignore the character casing. If several words have the same maximal frequency, print all of them in alphabetical order. 
//Write JS program frequentWord.js that invokes your function 
//with the sample input data below and prints the output at the console. 

function findMostFreqWord(text) {
	'use strict';

	var textToLower = text.toLowerCase(),
		wordsInText = textToLower.split(/\W+/),
		numberOfWords = wordsInText.length,
		wordCounter = {},
		maxFrequency = 0,
		output = [];

	for (var i = 0; i < numberOfWords; i++) {
		if (!wordCounter[wordsInText[i]]) {
			wordCounter[wordsInText[i]] = 1;
		} else {
			wordCounter[wordsInText[i]]++;
		}
	}

	for (var word in wordCounter) {
		if (wordCounter[word] > maxFrequency) {
			maxFrequency = wordCounter[word];
		}
	}

	for (word in wordCounter) {
		if (wordCounter[word] === maxFrequency) {
			output.push(word + ' -> ' + wordCounter[word] + ' times');
		}
	}

	output.sort();

	console.log(output.join('\n'));
}

findMostFreqWord('in the middle of the night');
console.log('------------------------------------');
findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
console.log('------------------------------------');
findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');