//Write a JavaScript function reverseWordsInString(str) to reverse the characters of every word
//in the string but leaves the words in the same order.
//Words are considered to be sequences of characters separated by spaces.
//Write a JavaScript program reverseWords.js that prints on the console the output.

function reverseWordsInString(str) {
	'use strict';

	var words = str.split(' '),
		numberOfWords = words.length,
		charsOfCurrentWord;

	for (var i = 0; i < numberOfWords; i++) {
		charsOfCurrentWord = words[i].split('');
		charsOfCurrentWord.reverse();
		words[i] = charsOfCurrentWord.join('');
	}

	console.log(words.join(' '));
}

reverseWordsInString('Hello, how are you.');
reverseWordsInString('Life is pretty good, isn’t it?');