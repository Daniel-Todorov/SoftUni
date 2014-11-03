// Problem 2. DOM Traversal
// You are given an HTML file.
// Write a function that traverses all child elements of an element by a given CSS selector and prints all found elements in the format:
//  <Element name>: id="<id>", class="<class>"
//  Print each element on a new line. Indent child elements.
'use strict';

function traverseChildren(selector) {
	if ((typeof selector).toLowerCase() !== 'string' && selector.length <= 0) {
		throw 'Invalid selector argument!';
	}

	var elementToTraverse = document.querySelector(selector);

	traverseElement(elementToTraverse, '');
}

function traverseElement(element, intendation) {
	for (var i = 0; i < element.children.length; i++) {
		console.log(intendation + element.children[i].localName + ': ' +
			(element.children[i].id !== '' ? 'id="' + element.children[i].id + '", ' : '') +
			(element.children[i].className !== '' ? 'class="' + element.children[i].className + '"' : ''));
		traverseElement(element.children[i], intendation + '\t');
	}
}

window.onload = traverseChildren('.birds');