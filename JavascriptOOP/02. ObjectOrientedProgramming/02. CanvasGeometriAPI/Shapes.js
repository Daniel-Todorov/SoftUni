//Problem 2. Canvas Geometry API
//Create a Web Geometry API for drawing geometrical shapes on Canvas. The API should support the following functionality:
//	•	Creating any of the shapes from the previous problem and rendering them on Canvas
//  •	Receiving all input data from a form (the shape chosen from the dropdown should generate a different input field depending on the input parameters)
//  •	Displaying all drawn shapes in a list with detailed information about each one
//  •	Removing shapes from the canvas using the remove button

'use strict';

var shapes = (function () {
	Object.prototype.extends = function (parent) {
		this.prototype = Object.create(parent.prototype);
		this.prototype.constructor = this;
	};

	function validateNumber(number, argumentName) {
		if ((typeof number) !== 'number') {
			throw argumentName + ' must be a number.';
		}
	}

	function validatePositiveNumber(number, argumentName) {
		validateNumber(number, argumentName);

		if (number <= 0) {
			throw argumentName + ' must have a positve value greaten than zero.';
		}
	}

	function validateColor(color) {
		if (!(/(^#[0-9A-F]{6}$)|(^#[0-9A-F]{3}$)/i.test(color))) {
			throw 'Color is not in hexadecimal color representation form.';
		}
	}

	function validateSimplePoint(point) {
		if (!(point instanceof SimplePoint)) {
			throw 'Starting point must be an instance of SimplePoint.';
		}
	}

	function SimplePoint(x, y) {
		validateNumber(x, 'X');
		validateNumber(y, 'Y');

		this._x = x;
		this._y = y;

	}

	function Shape(startingPoint, color) {
		validateSimplePoint(startingPoint);
		validateColor(color);

		this._startingPoint = startingPoint;
		this._color = color;
	}

	function Circle(startingPoint, radius, color) {
		validatePositiveNumber(radius, 'Radius');

		Shape.call(this, startingPoint, color);

		this._radius = radius;
	}

	function Rectangle(startingPoint, width, height, color) {
		validatePositiveNumber(width, 'Width');
		validatePositiveNumber(height, 'Height');

		Shape.call(this, startingPoint, color);

		this._width = width;
		this._height = height;
	}

	function Triangle(startingPoint, secondPoint, thirdPoint, color) {
		validateSimplePoint(secondPoint);
		validateSimplePoint(thirdPoint);

		Shape.call(this, startingPoint, color);

		this._secondPoint = secondPoint;
		this._thirdPoint = thirdPoint;
	}

	function Segment(startingPoint, secondPoint, color) {
		validateSimplePoint(secondPoint);

		Shape.call(this, startingPoint, color);

		this._secondPoint = secondPoint;
	}

	function Point(startingPoint, color) {
		Shape.call(this, startingPoint, color);
	}

	Circle.extends(Shape);
	Rectangle.extends(Shape);
	Triangle.extends(Shape);
	Segment.extends(Shape);
	Point.extends(Shape);

	SimplePoint.prototype.toString = function () {
		return 'X: ' + this._x + ', Y: ' + this._y;
	};

	Shape.prototype.toString = function () {
		return 'Starting Point => ' + this._startingPoint.toString() + '; Color => ' + this._color;
	};

	Circle.prototype.toString = function () {
		return 'Circle - ' + Shape.prototype.toString.call(this) + '; Radius => ' + this._radius;
	};

	Circle.prototype.draw = function (context) {
		context.save();

		context.beginPath();
		context.fillStyle = this._color;
		context.arc(this._startingPoint._x, this._startingPoint._y, this._radius, 0, 2 * Math.PI);
		context.fill();

		context.restore();
	}

	Rectangle.prototype.toString = function () {
		return 'Rectangle - ' + Shape.prototype.toString.call(this) + '; Width => ' + this._width + '; Height => ' + this._height;
	};
	
	Rectangle.prototype.draw = function (context) {
		context.save();

		context.fillStyle = this._color;
		context.fillRect(this._startingPoint._x, this._startingPoint._y, this._width, this._height);

		context.restore();
	};

	Triangle.prototype.toString = function () {
		return 'Triangle - ' + Shape.prototype.toString.call(this) + '; Second Point => ' + this._secondPoint.toString() + '; Third Point => ' + this._thirdPoint.toString();
	};

	Triangle.prototype.draw = function (context) {
		context.save();

		context.beginPath();
		context.lineWidth = '2';
		context.strokeStyle = this._color;
		context.moveTo(this._startingPoint._x, this._startingPoint._y);
		context.lineTo(this._secondPoint._x, this._secondPoint._y);
		context.lineTo(this._thirdPoint._x, this._thirdPoint._y);
		context.closePath();
		context.stroke();

		context.restore();
	};

	Segment.prototype.toString = function () {
		return 'Segment - ' + Shape.prototype.toString.call(this) + '; Second Point => ' + this._secondPoint;
	};

	Segment.prototype.draw = function (context) {
		context.save();

		context.beginPath();
		context.lineWidth = '2';
		context.strokeStyle = this._color;
		context.moveTo(this._startingPoint._x, this._startingPoint._y);
		context.lineTo(this._secondPoint._x, this._secondPoint._y);
		context.stroke();

		context.restore();
	};

	Point.prototype.toString = function () {
		return 'Point - ' + Shape.prototype.toString.call(this);
	};

	Point.prototype.draw = function (context) {
		context.save();

		context.fillStyle = this._color;
		context.fillRect(this._startingPoint._x, this._startingPoint._y, 1, 1);

		context.restore();
	};

	return {
		SimplePoint: SimplePoint,
		Circle: Circle,
		Rectangle: Rectangle,
		Triangle: Triangle,
		Segment: Segment,
		Point: Point
	};
})();

var shapesToDraw = [];
var shapeSelector = document.getElementById('shapeSelector');
var drawedShapesHolder = document.getElementById('drawedShapesHolder');
var removeButton = document.getElementById('removeButton');
var addButton = document.getElementById('addButton');
var context = document.getElementById('canvas').getContext("2d");
var circleInfo = document.getElementById('circleInfo');
var rectangleInfo = document.getElementById('rectangleInfo');
var secondPointInfo = document.getElementById('secondPointInfo');
var thirdPointInfo = document.getElementById('thirdPointInfo');

hideAdditionalInfo();

shapeSelector.addEventListener('change', function (event) {
	hideAdditionalInfo();

	switch (event.target.value.toLowerCase()) {
		case 'circle':
			circleInfo.style.display = 'block';
			break;
		case 'rectangle':
			rectangleInfo.style.display = 'block';
			break;
		case 'triangle':
			secondPointInfo.style.display = 'block';
			thirdPointInfo.style.display = 'block';
			break;
		case 'segment':
			secondPointInfo.style.display = 'block';
			break;
		default:
			break;
	}
});

addButton.addEventListener('click', function (event) {
	event.preventDefault();

	var shape;
	var startingPoint = new shapes.SimplePoint(parseInt(document.getElementById('x1').value), parseInt(document.getElementById('y1').value));
	var color = document.getElementById('color').value;

	switch (shapeSelector.value.toLowerCase()) {
		case 'circle':
			shape = new shapes.Circle(startingPoint, parseInt(document.getElementById('radius').value), color);
			break;
		case 'rectangle':
			shape = new shapes.Rectangle(startingPoint, parseInt(document.getElementById('width').value), parseInt(document.getElementById('height').value), color);
			break;
		case 'triangle':
			var secondPoint = new shapes.SimplePoint(parseInt(document.getElementById('x2').value), parseInt(document.getElementById('y2').value));
			var thirdPoint = new shapes.SimplePoint(parseInt(document.getElementById('x3').value), parseInt(document.getElementById('y3').value));
			shape = new shapes.Triangle(startingPoint, secondPoint, thirdPoint, color);
			break;
		case 'segment':
			var secondPoint = new shapes.SimplePoint(parseInt(document.getElementById('x2').value), parseInt(document.getElementById('y2').value));
			shape = new shapes.Segment(startingPoint, secondPoint, color);
			break;
		case 'point':
			shape = new shapes.Point(startingPoint, color);
			break;
		default:
			break;
	}

	shapesToDraw.push(shape);
	drawShapes(shapesToDraw);

	return;
});

removeButton.addEventListener('click', function (event) {
	event.preventDefault();

	var options = drawedShapesHolder.options;

	for (var i = 0; i < options.length; i++) {
		if (options[i].selected) {
			shapesToDraw.splice(parseInt(options[i].value), 1);
		}
	}

	drawShapes(shapesToDraw);

	return;
});

function hideAdditionalInfo() {
	circleInfo.style.display = 'none';
	rectangleInfo.style.display = 'none';
	secondPointInfo.style.display = 'none';
	thirdPointInfo.style.display = 'none';
}

function drawShapes(shapesToDraw) {
	context.clearRect(0, 0, 400, 600);

	for (var i = 0; i < shapesToDraw.length; i++) {
		shapesToDraw[i].draw(context);
	}

	displayDrawedShapes(shapesToDraw);
}

function displayDrawedShapes(shapesToDraw) {
	while (drawedShapesHolder.firstChild) {
		drawedShapesHolder.removeChild(drawedShapesHolder.firstChild);
	}

	var option = document.createElement('option');

	for (var i = 0; i < shapesToDraw.length; i++) {
		var optionToAdd = option.cloneNode();
		optionToAdd.value = i;
		optionToAdd.innerText = shapesToDraw[i].toString();
		drawedShapesHolder.appendChild(optionToAdd);
	}
}