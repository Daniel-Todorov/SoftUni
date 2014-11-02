//Write a JavaScript code that prints the mouse coordinates in a text area when we move the mouse over the HTML document.

window.onload = function () {
	'use strict';

	var textArea = document.querySelector('textarea'),
		text = '';

	textArea.style.display = 'inline-block';
	textArea.style.width = '50%';
	textArea.style.height = '500px';

	document.addEventListener('mouseover', addMouseInfo, false);

	function addMouseInfo(event) {
		text += 'X:' + event.x + '; Y:' + event.y + ' Time:' + new Date(event.timeStamp) + '\n';

		textArea.innerText = text;
	}
};