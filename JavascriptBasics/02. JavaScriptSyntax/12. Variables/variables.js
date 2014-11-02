//Write a JavaScript function variablesTypes(value) that accepts the following parameters:
//name, age, isMale (true or false), array of your favorite foods.
//The function must return the values of the variables and their types.

'use strict';

function variablesTypes(value)  {
	var name = value[0],
		age = value[1],
		isMale = value[2],
		favouriteFood = value[3],
		result = '';

	result += '"My name: ' + name + ' //type is ' + typeof name + '\n';
	result += 'My age: ' + age + ' //type is ' + typeof age + '\n';
	result += 'I am male: ' + isMale + ' //type is ' + typeof isMale + '\n';
	result += 'My favorite foods are: ' + favouriteFood.join(',') + ' //type is ' + typeof  favouriteFood + '"';

	console.log(result);
}

variablesTypes(['Pesho', 22, true, ['fries', 'banana', 'cake']]);