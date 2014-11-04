//Problem 1. Shapes
//Define class Shape. Each shape has x, y and _color (in hexadecimal format). Define the following shapes:
//	•	Circle – holds _radius
//  •	Rectangle – holds _width and _height
//  •	Triangle – holds three points (x, y)
//  •	Segment – holds two points (x, y)
//  •	Point – holds points (x, y)
//Each shape should hold a draw() method for drawing itself on Canvas. Add all shapes in a module.
//Design the described shapes using best practices of OOP in JavaScript.
// Use proper inheritance, encapsulate all data and validate the input.
// Override toString() to print information about each object.
// Avoid code repetition.

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
		context.arc(100, 75, 50, 0, 2 * Math.PI);
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

console.log(new shapes.Circle(new shapes.SimplePoint(1, 2), 10, '#000').toString());
console.log(new shapes.Rectangle(new shapes.SimplePoint(2, 3), 5, 20, '#000').toString());
console.log(new shapes.Triangle(new shapes.SimplePoint(1, 2), new shapes.SimplePoint(1, 2), new shapes.SimplePoint(1, 2), '#000').toString());
console.log(new shapes.Segment(new shapes.SimplePoint(1, 2), new shapes.SimplePoint(1, 2), '#000').toString());
console.log(new shapes.Point(new shapes.SimplePoint(1, 2), '#000').toString());