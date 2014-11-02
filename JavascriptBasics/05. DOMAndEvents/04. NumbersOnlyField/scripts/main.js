//Write a HTML page holding a form and a text field. Using JavaScript make the text field to accept numbers only.
//When a non-number character is entered through the keyboard (or by any other way),
//make the field red for a while and do not accept the change
//(preserve the previous value of the field).

window.onload = function () {
	'use strict';

	var input = document.querySelector('input'),
		inputValue = '';

	input.addEventListener('keypress', filterInput, false);

	function filterInput(event) {
		event.preventDefault();

		var target = event.target,
			pressedKey = String.fromCharCode(event.keyCode);

		switch (pressedKey) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': inputValue += pressedKey.toString(); break;
			default:
				target.value = inputValue;
				input.style.backgroundColor = 'red';

				setTimeout(function () {
					input.style.backgroundColor = 'transparent';
				}, 1000);

				break;
		}

		target.value = '';
		target.value = inputValue;
	}
}