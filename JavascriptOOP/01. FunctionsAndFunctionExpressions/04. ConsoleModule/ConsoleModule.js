// Problem 4. Console Module
// Create a module for working with the console object. The module should support the following functionality:
//	•	Writing a line to the console
//  •	Writing a line to the console using formatting (with placeholders)
//	•	Writing to the console should call toString() to each element
//  •	Writing errors and warnings to the console with and without format
'use strict';

var specialConsole = (function specialConsole() {
	function consoleWrite(args, outputFunction) {
		if (args.length === 0) {
			outputFunction();
			return;
		}

		if (args.length === 1) {
			outputFunction(args[0]);
			return;
		}

		var message = args[0];
		var numberOfPlaceholders = args.length - 1;

		for (var i = 0; i < numberOfPlaceholders; i++) {
			while(message.indexOf('{' + i + '}') >= 0){
				message = message.replace('{' + i + '}', args[i + 1]);
			}
		}

		outputFunction(message);
	}

	function writeLine() {
		consoleWrite(arguments, console.log);
	}

	function writeError() {
		consoleWrite(arguments, console.error);
	}

	function writeWarning() {
		consoleWrite(arguments, console.warn);
	}

	return {
		writeLine: writeLine,
		writeError: writeError,
		writeWarning: writeWarning
	};
})();

specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0}", "hello");
specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");
