//You are given an HTML file holding a table of elements and a button titled "Hide Odd Rows".
//Write JavaScript code hideOddRows.js that attaches to the button click event and hides the odd rows of the table when clicked.

window.onload = function () {
	'use strict';

	var hideOddRowsButton = document.querySelector('#btnHideOddRows'),
		table = document.querySelector('table');

	hideOddRowsButton.addEventListener('click', hideOddRows, false);

	function hideOddRows() {
		var oddRows = table.querySelectorAll('tr:nth-of-type(2n + 1)'),
			numberOfOddRows = oddRows.length;

		for (var i = 0; i < numberOfOddRows; i++) {
			oddRows[i].style.display = 'none';
		}
	}
}


