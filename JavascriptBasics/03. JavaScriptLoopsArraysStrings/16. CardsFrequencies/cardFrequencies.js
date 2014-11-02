//Write a JavaScript function findCardFrequency(value) that that accepts the following parameters: 
//array of several cards (face + suit), separated by a space. 
//The function calculates and prints at the console the frequency of each card face in format "card_face -> frequency". 
//The frequency is calculated by the formula appearances / N and 
//is expressed in percentages with exactly 2 digits after the decimal point. 
//The card faces with their frequency should be printed in the order of the card face's first appearance in the input. 
//The same card can appear multiple times in the input, but its face should be listed only once in the output. 
//Write JS program cardFrequencies.js that invokes your function 
//with the sample input data below and prints the output at the console. 

function findCardFrequency(listOfCards) {
	'use strict';

	var cards = listOfCards.split(' '),
		numberOfCards = cards.length,
		cardCounter = {},
		cardPlacer = {},
		result = [],
		cardFace,
		percentage,
		counter = 0;

	for (var i = 0; i < numberOfCards; i++) {
		switch (cards[i][0]) {
			case '1': cardFace = '10'; break;
			case '2': cardFace = '2'; break;
			case '3': cardFace = '3'; break;
			case '4': cardFace = '4'; break;
			case '5': cardFace = '5'; break;
			case '6': cardFace = '6'; break;
			case '7': cardFace = '7'; break;
			case '8': cardFace = '8'; break;
			case '9': cardFace = '9'; break;
			case 'J': cardFace = 'J'; break;
			case 'Q': cardFace = 'Q'; break;
			case 'K': cardFace = 'K'; break;
			case 'A': cardFace = 'A'; break;
		}

		if (!cardCounter[cardFace]) {
			cardCounter[cardFace] = 1;
		} else {
			cardCounter[cardFace]++;
		}
	}

	for (var j = 0; j < numberOfCards; j++) {
		switch (cards[j][0]) {
			case '1': cardFace = '10'; break;
			case '2': cardFace = '2'; break;
			case '3': cardFace = '3'; break;
			case '4': cardFace = '4'; break;
			case '5': cardFace = '5'; break;
			case '6': cardFace = '6'; break;
			case '7': cardFace = '7'; break;
			case '8': cardFace = '8'; break;
			case '9': cardFace = '9'; break;
			case 'J': cardFace = 'J'; break;
			case 'Q': cardFace = 'Q'; break;
			case 'K': cardFace = 'K'; break;
			case 'A': cardFace = 'A'; break;
		}

		if (cardPlacer[cardFace] === undefined) {
			cardPlacer[cardFace] = counter;
			counter++;
		}
	}

	for (var card in cardPlacer) {
		percentage = ((cardCounter[card] / numberOfCards * 100).toFixed(2)) + '%';
		result[cardPlacer[card]] = card + ' -> ' + percentage;
	}

	console.log(result.join('\n'));
}

findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
console.log('-----------------------');
findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
console.log('-----------------------');
findCardFrequency('10♣ 10♥');