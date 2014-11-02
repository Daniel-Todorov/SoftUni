//Write a JavaScript function convertKWtoHP(value) to convert car’s kW into hp (horse power).
//Write a JS program powerfulCars.js that converts a few sample values to hp (see the examples below).
//The result should be printed on the console, rounded up to the second sign after the decimal point.
//Run the program through Node.js.

'use strict';

function convertKWtoHP(value) {
	var carKW = value || 0,
		ratio = 1.3404825737265416,
		carHP = carKW * ratio,
		carRoundedHP = carHP.toFixed(2);

	console.log(carRoundedHP);
}

convertKWtoHP(75);
convertKWtoHP(150);
convertKWtoHP(1000);