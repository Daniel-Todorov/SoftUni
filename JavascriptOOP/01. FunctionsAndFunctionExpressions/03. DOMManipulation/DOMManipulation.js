// Problem 3. DOM Manipulation
// Create an IIFE module for working with the DOM tree. The module should support the following operations:
//	•	Adding а DOM element to a parent element specified by selector
//  •	Removing a child element from a parent specified by selector
//  •	Attaching an event to a given selector by given event type and event handler
//  •	Retrieving elements by a given CSS selector
// The module should reveal only its methods (i.e. everything else should be encapsulated).

var domModule = (function () {
	function appendChild(elementToAppend, parentSelector) {
		var parentElement = document.querySelector(parentSelector);
		parentElement.appendChild(elementToAppend);
	}

	function removeChild (parentSelector, childSelector) {
		var parentElement = document.querySelector(parentSelector);
		var childElement = document.querySelector(childSelector);

		parentElement.removeChild(childElement);
	}

	function addHandler(elementSelector, eventType, eventHandler) {
		var elements = document.querySelectorAll(elementSelector);

		for (var i = 0; i < elements.length; i++) {
			elements[i].addEventListener(eventType, eventHandler);
		}
	}

	function retrieveElements(elementsSelector) {
		var selectedElements = document.querySelectorAll(elementsSelector);

		return selectedElements;
	}

	return {
		appendChild: appendChild,
		removeChild: removeChild,
		addHandler: addHandler,
		retrieveElements: retrieveElements
	};
})();

var liElement = document.createElement("li");
// Appends a list item to ul.birds-list
domModule.appendChild(liElement,".birds-list");
// Removes the first li child from the bird list
domModule.removeChild("ul.birds-list","li:first-child");
// Adds a click event to all bird list items
domModule.addHandler("li.bird", 'click', function(){ alert("I'm a bird!"); });
// Retrives all elements of class "bird"
var elements = domModule.retrieveElements(".bird");
console.log(elements);
