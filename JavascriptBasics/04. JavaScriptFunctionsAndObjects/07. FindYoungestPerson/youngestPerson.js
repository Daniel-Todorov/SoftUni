//Write a JavaScript function findYoungestPerson(persons) that accepts as parameter an array of persons,
//finds the youngest person and returns his full name.
//Write a JS program youngestPerson.js to execute your function for the below examples and print the result at the console.

function findYoungestPerson(persons) {
	'use strict';

	var youngestPerson = persons[0],
		numberOfPersons = persons.length;

	for (var i = 1; i < numberOfPersons; i++) {
		if (youngestPerson.age > persons[i].age) {
			youngestPerson = persons[i];
		}
	}

	return youngestPerson.firstname + ' ' + youngestPerson.lastname;
}

var persons = [
	{ firstname : 'George', lastname: 'Kolev', age: 32},
	{ firstname : 'Bay', lastname: 'Ivan', age: 81},
	{ firstname : 'Baba', lastname: 'Ginka', age: 40}];

console.log('The youngest person is ' + findYoungestPerson(persons));
