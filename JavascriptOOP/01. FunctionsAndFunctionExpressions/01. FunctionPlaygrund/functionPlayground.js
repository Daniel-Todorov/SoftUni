//Problem 1. Function Playground
//Create a function with no parameters. Perform the following operations:
//•	The function should print the number of its arguments and each of the arguments' type.
//  o	Call the function with different number and type of arguments.
//•	The function should print the this object. Compare the results when calling the function from:
//  o	Global scope
//  o	Function scope
//  o	Over the object
//  o	Use call and apply to call the function with parameters and without parameters

function testFunction() {
	console.log('Number of arguments: ' + arguments.length);

	for (var i = 1; i <= arguments.length; i++) {
		console.log('Argument ' + i + ' has type "' + (typeof arguments[i - 1]) + '"');
	}

	console.log(this);
}

testFunction(1);

console.log('-----------------------');

testFunction.call({name: 'Pesho'}, true, 1, '5');

console.log('------------------');

testFunction.apply({name: 'Gosho'}, [[], 'Pesho', testFunction]);