function solve2(input) {
	'use strict';
	input.push('');

	var resultArray = [],
		numberOfLines = input.length,
		lengthOfCurrentLine;

	for (var x = 0; x < numberOfLines; x++) {
		resultArray.push([]);
	}

	for (var i = 0; i < numberOfLines - 1; i++) {
		lengthOfCurrentLine = input[i].length;

		if (resultArray[i][0] !== '*') {
			resultArray[i][0] = input[i][0];
		}

		for (var j = 0; j < lengthOfCurrentLine; j++) {
			try {
				if (input[i][j] === input[i + 1][j - 1] && input[i][j] === input[i + 1][j] && input[i][j] === input[i + 1][j + 1]) {
					resultArray[i][j] = '*';
					resultArray[i + 1][j - 1] = '*';
					resultArray[i + 1][j] = '*';
					resultArray[i + 1][j + 1] = '*';
				} else if (resultArray[i][j] !== '*') {
					resultArray[i][j] = input[i][j];
				}
			}
			catch (err) {
				if (resultArray[i][j] !== '*') {
					resultArray[i][j] = input[i][j];
				}
			}
		}
	}

	for (var y = 0; y < resultArray.length; y++) {
		resultArray[y] = resultArray[y].join('');
	}


	console.log(resultArray.join('\n'));
}

solve2(['abcdexgh', 'bbbdxxxh', 'abcxxxxx']);
solve2(['aa', 'aaa', 'aaaa', 'aaaaa']);
solve2(['ax', 'xxx', 'b', 'bbb', 'bbbb']);
solve2(['dffdsgyefg', 'ffffeyeee', 'jbfffays', 'dagfffdsss', 'dfdfa', 'dadaaadddf', 'sdaaaaa', 'daaaaaaasf'])