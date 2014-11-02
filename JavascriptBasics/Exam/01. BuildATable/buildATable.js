function solve(input) {
	'use strict';

	var startNumber = parseInt(input[0]),
		endNumber = parseInt(input[1]),
		result = '';

	result += '<table>\n';
	result += '<tr><th>Num</th><th>Square</th><th>Fib</th></tr>\n';

	for (var n = startNumber; n <= endNumber; n++) {
		result += '<tr><td>' + n +'</td><td>' + (n * n) +'</td><td>' + isFibonacci(n) + '</td></tr>\n';
	}

	result += '</table>';

	function isFibonacci(n) {
		var x = 5 * n * n - 4,
			y = 5 * n * n + 4,
			sX = parseInt(Math.sqrt(x)),
			sY = parseInt(Math.sqrt(y));

		if (sX * sX === x || sY * sY === y) {
			return 'yes';
		} else {
			return 'no';
		}
	}

	console.log(result);
}

solve([2, 6]);