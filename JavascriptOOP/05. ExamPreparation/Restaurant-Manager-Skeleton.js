function processRestaurantManagerCommands(commands) {
	'use strict';

	Object.prototype.extends = function (parent) {
		this.prototype = Object.create(parent.prototype);
		this.prototype.constructor = this;
	};

	function checkForNullOrEmptyString(string, parameterName) {
		if ((typeof string).toLowerCase() !== 'string' || string === '') {
			throw parameterName + ' should be non-empty string';
		}
	}

	function checkForPositiveNumber(number, parameterName) {
		if ((typeof number).toLowerCase() !== 'number' || number <= 0) {
			throw parameterName + ' should be a positive number.';
		}
	}

	var RestaurantEngine = (function () {
		var _restaurants, _recipes;

		function initialize() {
			_restaurants = [];
			_recipes = [];
		}

		var Restaurant = (function () {
			function Restaurant(name, location) {
				this.setName(name);
				this.setLocation(location);
				this._recipes = [];
			}

			Restaurant.prototype.getName = function () {
				return this._name;
			};

			Restaurant.prototype.setName = function (name) {
				checkForNullOrEmptyString(name, 'Name of restaurant');

				this._name = name;
			};

			Restaurant.prototype.getLocation = function () {
				return this._location;
			};

			Restaurant.prototype.setLocation = function (location) {
				checkForNullOrEmptyString(location, 'Location of restaurant');

				this._location = location;
			};

			Restaurant.prototype.getRecipes = function () {
				return this._recipes;
			}

			Restaurant.prototype.addRecipe = function (recipe) {
				if ((recipe instanceof Recipe)) {
					throw 'The recipe to add must be instance of Recipe.';
				}

				this._recipes.push(recipe);
			};

			Restaurant.prototype.removeRecipe = function (recipe) {
				if ((recipe instanceof Recipe)) {
					throw 'The recipe to remove must be instance of Recipe.';
				}

				this._recipes = this._recipes.filter(function (element) {
					return element.getName() !== recipe.getName();
				});
			};

			Restaurant.prototype.printRestaurantMenu = function () {
				var result = '';

				result += '***** ' + this.getName() + ' - ' + this.getLocation() + ' *****';
				if (this.getRecipes().length <= 0) {
					result += '\nNo recipes... yet';

					console.log(result);
					return;
				}

				console.log(result);
			};

			return Restaurant;
		}())

		var Recipe = (function () {
			function Recipe(name, price, calories, quantityPerServing, measureUnit, timeToPrepare) {
				if (this.constructor === Recipe) {
					throw new Error('Cannot instantiate abstract class Recipe.');
				}

				this.setName(name);
				this.setPrice(price);
				this.setCalories(calories);
				this.setQuantityPerServing(quantityPerServing);
				this.setMeasureUnit(measureUnit);
				this.setTimeToPrepare(timeToPrepare);
			}

			Recipe.prototype.getName = function () {
				return this._name;
			};

			Recipe.prototype.setName = function (name) {
				checkForNullOrEmptyString(name);

				this._name = name;
			};

			Recipe.prototype.getPrice = function () {
				return this._price;
			};

			Recipe.prototype.setPrice = function (price) {
				checkForPositiveNumber(price, 'Price of recipe');

				this._price = price;
			};

			Recipe.prototype.getCalories = function () {
				return this._calories;
			};

			Recipe.prototype.setCalories = function (calories) {
				checkForPositiveNumber(calories, 'Calories of recipe');

				this._calories = calories;
			};

			Recipe.prototype.getQuantityPerServing = function () {
				return this._quantityPerServing;
			};

			Recipe.prototype.setQuantityPerServing = function (quantityPerServing) {
				checkForPositiveNumber(quantityPerServing, 'Quantity per serving of recipe');

				this._quantityPerServing = quantityPerServing;
			};

			Recipe.prototype.getMeasureUnit = function () {
				return this._measureUnit;
			};

			Recipe.prototype.setMeasureUnit = function (measureUnit) {
				this._measureUnit = measureUnit;
			};

			Recipe.prototype.getTimeToPrepare = function () {
				return this._timeToPrepare;
			};

			Recipe.prototype.setTimeToPrepare = function (timeToPrepare) {
				checkForPositiveNumber(timeToPrepare);

				this._timeToPrepare = timeToPrepare;
			};

			return Recipe;
		}());

		var Drink = (function () {
			var MAX_CALORIES_IN_DRINK = 100;
			var MAX_TIME_TO_PREPARE_DRINK = 20;

			function Drink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
				Recipe.call(this, name, price, calories, quantity, 'ml', timeToPrepare);

				this.setCalories(calories);
				this.setTimeToPrepare(timeToPrepare);
				this.setIsCarbonated(isCarbonated);
			}

			Drink.extends(Recipe);

			Drink.prototype.setCalories = function (calories) {
				checkForPositiveNumber(calories, 'Calories of drink');

				if (calories > MAX_CALORIES_IN_DRINK) {
					throw 'calories of drink should not be greater than ' + MAX_CALORIES_IN_DRINK;
				}

				this._calories = calories;
			};

			Drink.prototype.setTimeToPrepare = function (timeToPrepare) {
				checkForPositiveNumber(timeToPrepare, 'Time to prepare drink');

				if (timeToPrepare > MAX_TIME_TO_PREPARE_DRINK) {
					throw 'Time to prepare drink should not be greater than ' + MAX_TIME_TO_PREPARE_DRINK;
				}

				this._timeToPrepare = timeToPrepare;
			};

			Drink.prototype.getIsCarbonated = function () {
				return this._isCarbonated;
			};

			Drink.prototype.setIsCarbonated = function (isCarbonated) {
				this._isCarbonated = isCarbonated;
			};

			return Drink;
		}());

		var Meal = (function () {
			function Meal(name, price, calories, quantity, timeToPrepare, isVegan) {
				if (this.constructor === Meal) {
					throw new Error('Cannot instantiate abstract class Meal.');
				}

				Recipe.call(this, name, price, calories, quantity, 'gr', timeToPrepare);

				this.setIsVegan(isVegan);
			}

			Meal.extends(Recipe);

			Meal.prototype.getIsVegan = function () {
				return this._isVegan;
			};

			Meal.prototype.setIsVegan = function (isVegan) {
				this._isVegan = isVegan;
			};

			Meal.prototype.toggleVegan = function () {
				if (this.getIsVegan() === 'yes') {
					this.setIsVegan('no');
				} else {
					this.setIsVegan('yes');
				}
			};

			return Meal;
		}());

		var Dessert = (function () {
			function Dessert(name, price, calories, quantity, timeToPrepare, isVegan) {
				Meal.call(this, name, price, calories, quantity, timeToPrepare, isVegan);

				this.setHasSugar('yes');
			}

			Dessert.extends(Meal);

			Dessert.prototype.getHasSugar = function () {
				return this._hasSugar;
			};

			Dessert.prototype.setHasSugar = function (hasSugar) {
				this._hasSugar = hasSugar;
			};

			Dessert.prototype.toggleSugar = function () {
				if (this.getHasSugar() === 'yes') {
					this.setHasSugar('no');
				} else {
					this.setHasSugar('yes');
				}
			};

			return Dessert;
		}());

		var MainCourse = (function () {
			function MainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type) {
				Meal.call(this, name, price, calories, quantity, timeToPrepare, isVegan);

				this.setType(type);
			}

			MainCourse.extends(Meal);

			MainCourse.prototype.getType = function () {
				return this._type;
			};

			MainCourse.prototype.setType = function (type) {
				this._type = type;
			};

			return MainCourse;
		}());

		var Salad = (function () {
			function Salad(name, price, calories, quantity, timeToPrepare, containsPasta) {
				Meal.call(this, name, price, calories, quantity, timeToPrepare, 'yes');

				this.setContainsPasta(containsPasta);
			}

			Salad.extends(Meal);

			Salad.prototype.getContainsPasta = function () {
				return this._containsPasta;
			};

			Salad.prototype.setContainsPasta = function (containsPasta) {
				this._containsPasta = containsPasta;
			};

			return Salad;
		}());

		var Command = (function () {

			function Command(commandLine) {
				this._params = [];
				this.translateCommand(commandLine);
			}

			Command.prototype.translateCommand = function (commandLine) {
				var self, paramsBeginning, name, parametersKeysAndValues;
				self = this;
				paramsBeginning = commandLine.indexOf("(");

				this._name = commandLine.substring(0, paramsBeginning);
				name = commandLine.substring(0, paramsBeginning);
				parametersKeysAndValues = commandLine
					.substring(paramsBeginning + 1, commandLine.length - 1)
					.split(";")
					.filter(function (e) {
						return true;
					});

				parametersKeysAndValues.forEach(function (p) {
					var split = p
						.split("=")
						.filter(function (e) {
							return true;
						});
					self._params[split[0]] = split[1];
				});
			};

			return Command;
		}());

		function createRestaurant(name, location) {
			_restaurants[name] = new Restaurant(name, location);
			return "Restaurant " + name + " created\n";
		}

		function createDrink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
			_recipes[name] = new Drink(name, price, calories, quantity, timeToPrepare, isCarbonated);
			return "Recipe " + name + " created\n";
		}

		function createSalad(name, price, calories, quantity, timeToPrepare, containsPasta) {
			_recipes[name] = new Salad(name, price, calories, quantity, timeToPrepare, containsPasta);
			return "Recipe " + name + " created\n";
		}

		function createMainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type) {
			_recipes[name] = new MainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type);
			return "Recipe " + name + " created\n";
		}

		function createDessert(name, price, calories, quantity, timeToPrepare, isVegan) {
			_recipes[name] = new Dessert(name, price, calories, quantity, timeToPrepare, isVegan);
			return "Recipe " + name + " created\n";
		}

		function toggleSugar(name) {
			var recipe;

			if (!_recipes.hasOwnProperty(name)) {
				throw new Error("The recipe " + name + " does not exist");
			}
			recipe = _recipes[name];

			if (recipe instanceof Dessert) {
				recipe.toggleSugar();
				return "Command ToggleSugar executed successfully. New value: " + recipe._withSugar.toString().toLowerCase() + "\n";
			} else {
				return "The command ToggleSugar is not applicable to recipe " + name + "\n";
			}
		}

		function toggleVegan(name) {
			var recipe;

			if (!_recipes.hasOwnProperty(name)) {
				throw new Error("The recipe " + name + " does not exist");
			}

			recipe = _recipes[name];
			if (recipe instanceof Meal) {
				recipe.toggleVegan();
				return "Command ToggleVegan executed successfully. New value: " +
					recipe._isVegan.toString().toLowerCase() + "\n";
			} else {
				return "The command ToggleVegan is not applicable to recipe " + name + "\n";
			}
		}

		function printRestaurantMenu(name) {
			var restaurant;

			if (!_restaurants.hasOwnProperty(name)) {
				throw new Error("The restaurant " + name + " does not exist");
			}

			restaurant = _restaurants[name];
			return restaurant.printRestaurantMenu();
		}

		function addRecipeToRestaurant(restaurantName, recipeName) {
			var restaurant, recipe;

			if (!_restaurants.hasOwnProperty(restaurantName)) {
				throw new Error("The restaurant " + restaurantName + " does not exist");
			}
			if (!_recipes.hasOwnProperty(recipeName)) {
				throw new Error("The recipe " + recipeName + " does not exist");
			}

			restaurant = _restaurants[restaurantName];
			recipe = _recipes[recipeName];
			restaurant.addRecipe(recipe);
			return "Recipe " + recipeName + " successfully added to restaurant " + restaurantName + "\n";
		}

		function removeRecipeFromRestaurant(restaurantName, recipeName) {
			var restaurant, recipe;

			if (!_recipes.hasOwnProperty(recipeName)) {
				throw new Error("The recipe " + recipeName + " does not exist");
			}
			if (!_restaurants.hasOwnProperty(restaurantName)) {
				throw new Error("The restaurant " + restaurantName + " does not exist");
			}

			restaurant = _restaurants[restaurantName];
			recipe = _recipes[recipeName];
			restaurant.removeRecipe(recipe);
			return "Recipe " + recipeName + " successfully removed from restaurant " + restaurantName + "\n";
		}

		function executeCommand(commandLine) {
			var cmd, params, result;
			cmd = new Command(commandLine);
			params = cmd._params;

			switch (cmd._name) {
				case 'CreateRestaurant':
					result = createRestaurant(params["name"], params["location"]);
					break;
				case 'CreateDrink':
					result = createDrink(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
						parseInt(params["quantity"]), params["time"], parseBoolean(params["carbonated"]));
					break;
				case 'CreateSalad':
					result = createSalad(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
						parseInt(params["quantity"]), params["time"], parseBoolean(params["pasta"]));
					break;
				case "CreateMainCourse":
					result = createMainCourse(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
						parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]), params["type"]);
					break;
				case "CreateDessert":
					result = createDessert(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
						parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]));
					break;
				case "ToggleSugar":
					result = toggleSugar(params["name"]);
					break;
				case "ToggleVegan":
					result = toggleVegan(params["name"]);
					break;
				case "AddRecipeToRestaurant":
					result = addRecipeToRestaurant(params["restaurant"], params["recipe"]);
					break;
				case "RemoveRecipeFromRestaurant":
					result = removeRecipeFromRestaurant(params["restaurant"], params["recipe"]);
					break;
				case "PrintRestaurantMenu":
					result = printRestaurantMenu(params["name"]);
					break;
				default:
					throw new Error('Invalid command name: ' + cmdName);
			}

			return result;
		}

		function parseBoolean(value) {
			switch (value) {
				case "yes":
					return true;
				case "no":
					return false;
				default:
					throw new Error("Invalid boolean value: " + value);
			}
		}

		return {
			initialize: initialize,
			executeCommand: executeCommand
		};
	}());


	// Process the input commands and return the results
	var results = '';
	RestaurantEngine.initialize();
	commands.forEach(function (cmd) {
		if (cmd != "") {
			try {
				var cmdResult = RestaurantEngine.executeCommand(cmd);
				results += cmdResult;
			} catch (err) {
				results += err.message + "\n";
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
			console.log(processRestaurantManagerCommands(arr));
		});
	}
})();
