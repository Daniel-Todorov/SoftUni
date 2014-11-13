function processTrainingCenterCommands(commands) {

	'use strict';

	Object.prototype.extends = function (parent) {
		this.prototype = Object.create(parent.prototype);
		this.prototype.constructor = this;
	};

	function isInteger(number) {
		return number % 1 === 0;
	}

	var trainingcenter = (function () {

		var TrainingCenterEngine = (function () {

			var _trainers;
			var _uniqueTrainerUsernames;
			var _trainings;

			function initialize() {
				_trainers = [];
				_uniqueTrainerUsernames = {};
				_trainings = [];
			}

			function executeCommand(command) {
				var cmdParts = command.split(' ');
				var cmdName = cmdParts[0];
				var cmdArgs = cmdParts.splice(1);
				switch (cmdName) {
					case 'create':
						return executeCreateCommand(cmdArgs);
					case 'list':
						return executeListCommand();
					case 'delete':
						return executeDeleteCommand(cmdArgs);
					default:
						throw new Error('Unknown command: ' + cmdName);
				}
			}

			function executeCreateCommand(cmdArgs) {
				var objectType = cmdArgs[0];
				var createArgs = cmdArgs.splice(1).join(' ');
				var objectData = JSON.parse(createArgs);
				var trainer;
				switch (objectType) {
					case 'Trainer':
						trainer = new trainingcenter.Trainer(objectData.username, objectData.firstName,
							objectData.lastName, objectData.email);
						addTrainer(trainer);
						break;
					case 'Course':
						trainer = findTrainerByUsername(objectData.trainer);
						var course = new trainingcenter.Course(objectData.name, objectData.description, trainer,
							parseDate(objectData.startDate), objectData.duration);
						addTraining(course);
						break;
					case 'Seminar':
						trainer = findTrainerByUsername(objectData.trainer);
						var seminar = new trainingcenter.Seminar(objectData.name, objectData.description,
							trainer, parseDate(objectData.date));
						addTraining(seminar);
						break;
					case 'RemoteCourse':
						trainer = findTrainerByUsername(objectData.trainer);
						var remoteCourse = new trainingcenter.RemoteCourse(objectData.name, objectData.description,
							trainer, parseDate(objectData.startDate), objectData.duration, objectData.location);
						addTraining(remoteCourse);
						break;
					default:
						throw new Error('Unknown object to create: ' + objectType);
				}
				return objectType + ' created.';
			}

			function findTrainerByUsername(username) {
				if (!username) {
					return undefined;
				}
				for (var i = 0; i < _trainers.length; i++) {
					if (_trainers[i].getUsername() == username) {
						return _trainers[i];
					}
				}
				throw new Error("Trainer not found: " + username);
			}

			function addTrainer(trainer) {
				if (_uniqueTrainerUsernames[trainer.getUsername()]) {
					throw new Error('Duplicated trainer: ' + trainer.getUsername());
				}
				_uniqueTrainerUsernames[trainer.getUsername()] = true;
				_trainers.push(trainer);
			}

			function addTraining(training) {
				_trainings.push(training);
			}

			function executeListCommand() {
				var result = '', i;
				if (_trainers.length > 0) {
					result += 'Trainers:\n' + ' * ' + _trainers.join('\n * ') + '\n';
				} else {
					result += 'No trainers\n';
				}

				if (_trainings.length > 0) {
					result += 'Trainings:\n' + ' * ' + _trainings.join('\n * ') + '\n';
				} else {
					result += 'No trainings\n';
				}

				return result.trim();
			}

			function executeDeleteCommand(cmdArgs) {
				var objectType = cmdArgs[0];
				var deleteArgs = cmdArgs.splice(1).join(' ');
				switch (objectType) {
					case 'Trainer':
						// TODO: implement "delete Trainer" command
						var trainer = findTrainerByUsername(deleteArgs); //findTrainerByUsername throws an exception in case the trainer can not be found.

						_trainers = _trainers.filter(function (element) {
							return element.getUsername() !== trainer.getUsername();
						});

						_trainings = _trainings.map(function (training) {
							if ((training.getTrainer() instanceof Trainer) && training.getTrainer().getUsername() === trainer.getUsername()) {
								training.setTrainer(undefined);
							}

							return training;
						});

						break;
					default:
						throw new Error('Unknown object to delete: ' + objectType);
				}
				return objectType + ' deleted.';
			}

			var trainingCenterEngine = {
				initialize: initialize,
				executeCommand: executeCommand
			};
			return trainingCenterEngine;
		}());


		// TODO: implement Trainer class
		var Trainer = (function () {
			function Trainer(username, firstName, lastName, email) {
				this.setUsername(username);
				this.setFirstName(firstName);
				this.setLastName(lastName);
				this.setEmail(email);
			}

			Trainer.prototype.getUsername = function () {
				return this._username;
			};

			Trainer.prototype.setUsername = function (username) {
				if ((typeof username).toLowerCase() !== 'string' || username === '') {
					throw new Error("Username should be non-empty string");
				}

				this._username = username;
			};

			Trainer.prototype.getFirstName = function () {
				return this._firstName;
			};

			Trainer.prototype.setFirstName = function (firstName) {
				if ((typeof firstName).toLowerCase() === 'string' && firstName === '') {
					throw new Error("First name should be non-empty string if present.");
				}

				if ((typeof firstName).toLowerCase() === 'string') {
					this._firstName = firstName;
				}
			};

			Trainer.prototype.getLastName = function () {
				return this._lastName;
			};

			Trainer.prototype.setLastName = function (lastName) {
				if ((typeof lastName).toLowerCase() !== 'string' || lastName === '') {
					throw new Error("Last name should be non-empty string");
				}

				this._lastName = lastName;
			};

			Trainer.prototype.getEmail = function () {
				return this._email;
			};

			Trainer.prototype.setEmail = function (email) {
				if ((typeof email).toLowerCase() === 'string' && email.indexOf('@') < 0) {
					throw new Error("Email should contain '@' if present.");
				}

				if ((typeof email).toLowerCase() === 'string') {
					this._email = email;
				}
			};

			Trainer.prototype.toString = function () {
				var result = '';

				result += 'Trainer[username=' + this.getUsername();
				result += (this.getFirstName() ? ';first-name=' + this.getFirstName() : '');
				result += ';last-name=' + this.getLastName();
				result += (this.getEmail() ? ';email=' + this.getEmail() : '');
				result += ']';

				return result;
			};

			return Trainer;
		}());


		// TODO: implement Training class
		var Training = (function () {
			var MIN_START_YEAR = 2000;
			var MAX_START_YEAR = 2020;

			var MIN_DURATION = 1;
			var MAX_DURATION = 99;

			function Training(name, description, trainer, startDate, duration) {
				if (this.constructor === Training) {
					throw new Error('Cannot instantiate abstract class Training.');
				}

				this.setName(name);
				this.setDescription(description);
				this.setTrainer(trainer);
				this.setStartDate(startDate);
				this.setDuration(duration);
			}

			Training.prototype.getName = function () {
				return this._name;
			};

			Training.prototype.setName = function (name) {
				if ((typeof name).toLowerCase() !== 'string' || name === '') {
					throw  new Error('Name of trainign should be non-empty string.');
				}

				this._name = name;
			};

			Training.prototype.getDescription = function () {
				return this._description;
			};

			Training.prototype.setDescription = function (description) {
				if ((typeof description).toLowerCase() === 'string' && description === '') {
					throw new Error("Description should be non-empty string if present.");
				}

				if ((typeof description).toLowerCase() === 'string') {
					this._description = description;
				}
			};

			Training.prototype.getTrainer = function () {
				return this._trainer;
			};

			Training.prototype.setTrainer = function (trainer) {
				if ((typeof trainer).toLowerCase() !== 'undefined' && !(trainer instanceof Trainer)) {
					throw  new Error('Trainer should be of type Trainer');
				}

				this._trainer = trainer;
			};

			Training.prototype.getStartDate = function () {
				return this._startDate;
			};

			Training.prototype.setStartDate = function (startDate) {
				if (isNaN(startDate)) {
					throw new Error('Start date should be not empty.');
				}

				if (!(startDate instanceof Date)) {
					throw  new Error('Start date of a course should be of type Date.');
				}

				var startDateYear = parseInt(startDate.getFullYear());
				if (MIN_START_YEAR > startDateYear || startDateYear > MAX_START_YEAR) {
					throw  new Error('Start date year should be in range [' + MIN_START_YEAR + '...' + MAX_START_YEAR + '].');
				}

				this._startDate = startDate;
			};

			Training.prototype.getDuration = function () {
				return this._duration;
			};

			Training.prototype.setDuration = function (duration) {
				if (!duration) {
					return;
				}

				if ((typeof duration).toLowerCase() !== 'number') {
					throw new Error('Duration of a course should be of type number.');
				}

				if (!isInteger(duration)) {
					throw  new Error('Duration of a course should be an integer.');
				}

				if (MIN_DURATION > duration || duration > MAX_DURATION) {
					throw  new Error('Duration of a course should be in range [' + MIN_DURATION + '...' + MAX_DURATION + '].');
				}

				this._duration = duration;
			};

			Training.prototype.toString = function () {
				var result = '';

				result += this._type;
				result += '[name=' + this.getName();
				result += (this.getDescription() ? ';description=' + this.getDescription() : '');
				result += (this.getTrainer() ? ';trainer=' + this.getTrainer().toString() : '');
				result += ';start-date=' + formatDate(this.getStartDate());
				result += (this.getDuration() ? ';duration=' + this.getDuration() : '');
				result += ']';

				return result;
			};

			return Training;
		}())


		// TODO: implement Course class
		var Course = (function () {
			function Course(name, description, trainer, startDate, duration) {
				Training.apply(this, arguments);
			}

			Course.extends(Training);

			Course.prototype._type = 'Course';

			return Course;
		}())


		// TODO: implement Seminar class
		var Seminar = (function () {
			var DURATION = 1;

			function Seminar(name, description, trainer, startDate) {
				Training.call(this, name, description, trainer, startDate);
			}

			Seminar.extends(Training);

			Seminar.prototype.toString = function () {
				var result = '';

				result += Training.prototype.toString.call(this);
				result = result.replace('start-date', 'date');

				return result;
			}

			Seminar.prototype._type = 'Seminar';

			return Seminar;
		}())


		// TODO: implement RemoteCourse class
		var RemoteCourse = (function () {
			function RemoteCourse(name, description, trainer, startDate, duration, location) {
				Course.call(this, name, description, trainer, startDate, duration);

				this.setLocation(location);
			}

			RemoteCourse.extends(Course);

			RemoteCourse.prototype.getLocation = function () {
				return this._location;
			};

			RemoteCourse.prototype.setLocation = function (location) {
				if ((typeof location).toLowerCase() !== 'string' || location === '') {
					throw new Error('Location of a remote course should be non-empty string.');
				}

				this._location = location;
			};

			RemoteCourse.prototype.toString = function () {
				var result = '';

				result += Course.prototype.toString.call(this);
				result = result.substring(0, result.length - 1);
				result += ';location=' + this.getLocation();
				result += ']';

				return result;
			};

			RemoteCourse.prototype._type = 'RemoteCourse';

			return RemoteCourse;
		}())


		var trainingcenter = {
			Trainer: Trainer,
			Course: Course,
			Seminar: Seminar,
			RemoteCourse: RemoteCourse,
			engine: {
				TrainingCenterEngine: TrainingCenterEngine
			}
		};

		return trainingcenter;
	})();


	var parseDate = function (dateStr) {
		if (!dateStr) {
			return undefined;
		}
		var date = new Date(Date.parse(dateStr.replace(/-/g, ' ')));
		var dateFormatted = formatDate(date);
		if (dateStr != dateFormatted) {
			throw new Error("Invalid date: " + dateStr);
		}
		return date;
	};


	var formatDate = function (date) {
		var day = date.getDate();
		var monthName = date.toString().split(' ')[1];
		var year = date.getFullYear();
		return day + '-' + monthName + '-' + year;
	};


	// Process the input commands and return the results
	var results = '';
	trainingcenter.engine.TrainingCenterEngine.initialize();
	commands.forEach(function (cmd) {
		if (cmd != '') {
			try {
				var cmdResult = trainingcenter.engine.TrainingCenterEngine.executeCommand(cmd);
				results += cmdResult + '\n';
			} catch (err) {
//				console.log(err.stack);
				results += 'Invalid command.\n';
			}
		}
	});
	return results.trim();
}


// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function () {
	var arr = [];
	if (typeof (require) == 'function') {
		// We are in node.js --> read the console input and process it
		require('readline').createInterface({
			input: process.stdin,
			output: process.stdout
		}).on('line', function (line) {
			arr.push(line);
		}).on('close', function () {
			console.log(processTrainingCenterCommands(arr));
		});
	}
})();
