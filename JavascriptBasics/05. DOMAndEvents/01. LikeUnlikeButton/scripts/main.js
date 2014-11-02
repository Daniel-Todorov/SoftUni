//Create a HTML page holding a "Like" button that changes to "Unlike" when clicked, then again to "Like", etc.

window.onload = function () {
	'use strict';
	
	var likeButton = document.querySelector('button');

	likeButton.addEventListener('click', toggleLikeButton, false);
};

function toggleLikeButton(event) {
	'use strict';

	var button = event.target,
		currentTextOfButton = button.innerText;

	if (currentTextOfButton === 'Like') {
		button.innerText = 'Unlike';
	} else if (currentTextOfButton === 'Unlike') {
		button.innerText = 'Like';
	}

	return false;
}
