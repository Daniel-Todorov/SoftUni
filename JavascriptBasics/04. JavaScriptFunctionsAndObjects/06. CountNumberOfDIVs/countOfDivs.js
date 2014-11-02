//Write a JavaScript function countDivs(html) to count the number of all DIVs in given HTML fragment passed as string.
//Write a JS program countOfDivs.js that invokes your function and prints the output at the console.

function countDivs(html) {
	'use strict';

	var matches = html.match(/<div/gi),
		numberOfDivs = matches.length;

	console.log(numberOfDivs);
}

var html = '<!DOCTYPE html>' +
	'<html>' +
	'<head lang="en">' +
		'<meta charset="UTF-8">' +
			'<title>index</title>' +
			'<script src="/yourScript.js" defer></script>' +
		'</head>' +
		'<body>' +
			'<div id="outerDiv">' +
				'<div class="first">' +
					'<div><div>hello</div></div>' +
				'</div>' +
				'<div>hi<div></div></div>' +
				'<div>I am a div</div>' +
			'</div>' +
		'</body>' +
	'</html>';

countDivs(html);