//Write a JavaScript function checkBrackets(value) to check if in a given expression the brackets are put correctly.
//Write JS program bracketsChecker.js that invokes your function
//with the sample input data below and prints the output at the console.

function checkBrackets(stringExpression) {
	var expressionLength = stringExpression.length,
		bracketsRatio = 0;

	for (var i = 0; i < expressionLength; i++) {
		if (stringExpression[i] === '(') {
			bracketsRatio++;
		} else if (stringExpression[i] === ')') {
			bracketsRatio--;
		}

		if (bracketsRatio < 0) {
			console.log('incorrect');
			return;
		}
	}

	if (bracketsRatio > 0) {
		console.log('incorrect');
	} else {
		console.log('correct');
	}
}

checkBrackets('( ( a + b ) / 5 – d )');
checkBrackets(') ( a + b ) )');
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )')