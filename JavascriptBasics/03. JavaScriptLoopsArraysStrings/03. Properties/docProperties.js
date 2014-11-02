//03. Write a JavaScript function displayProperties(value) that displays
//all the properties of the "document" object in alphabetical order.
//Write a JS program docProperties.js that invokes your function with
//the sample input data below and prints the output at the console.

//NOTE!!! You must run this in the browser coz node.js doesn't have window object.
function displayProperties(collection) {
	'use strict';

	var sortedProperties = [],
		numberOfProperties;

	for (var property in collection) {
		sortedProperties.push(property);
	}

	sortedProperties.sort(function (firstProperty, secondProperty) {
		return firstProperty.localeCompare(secondProperty);
	});
	numberOfProperties = sortedProperties.length;

	for (var i = 0; i < numberOfProperties; i++) {
		console.log(sortedProperties[i]);
	}
}

displayProperties(window.document);