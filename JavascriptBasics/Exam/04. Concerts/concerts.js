function solve(input) {
	'use strict';

	var result = {},
		numberOfLines = input.length,
		infoInCurrentLine;

	for (var i = 0; i < numberOfLines; i++) {
		infoInCurrentLine = input[i].split(' | ');

		if (typeof result[infoInCurrentLine[1]] === 'undefined') {
			result[infoInCurrentLine[1]] = {};
		}

		if (typeof result[infoInCurrentLine[1]][infoInCurrentLine[3]] === 'undefined') {
			result[infoInCurrentLine[1]][infoInCurrentLine[3]] = [];
		}

		result[infoInCurrentLine[1]][infoInCurrentLine[3]].push(infoInCurrentLine[0]);
	}

	result = sortObj(result);

	for (var city in result) {
		result[city] = sortObj(result[city]);

		for (var stadium in result[city]) {
			result[city][stadium] = result[city][stadium].reduce(function(a,b){if(a.indexOf(b)<0)a.push(b);return a;},[]);
			result[city][stadium].sort();
		}
	}

	function sortObj(obj, type) {
		var tempArray = [];
		for (var key in obj) {
			if (obj.hasOwnProperty(key)) {
				tempArray.push(key);
			}
		}
		if (typeof type === 'function') {
			tempArray.sort(type);
		} else if (type === 'value') {
			tempArray.sort(function(a,b) {
				var x = obj[a];
				var y = obj[b];
				return ((x < y) ? -1 : ((x > y) ? 1 : 0));
			});
		} else {
			tempArray.sort();
		}
		var result = {};
		for (var i=0; i<tempArray.length; i++) {
			result[tempArray[i]] = obj[tempArray[i]];
		}
		return result;
	}

	console.log(JSON.stringify(result));
}

solve([
	'ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
	'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
	'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
	'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
	'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
	'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
	'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
	'Helloween | London | 28-Jul-2014 | Wembley Stadium',
	'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
	'Metallica | London | 03-Oct-2014 | Olympic Stadium',
	'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
	'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium'
])