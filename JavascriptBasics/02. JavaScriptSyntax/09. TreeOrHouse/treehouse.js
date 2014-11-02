//Write a JavaScript function treeHouseCompare(value) that accepts the following parameters: integers a and b. 
//The function compares the area of the house and the area of the tree (Figure 1) 
//and returns the name of the figure with bigger area (house or tree) and the value of the area. 
//Write JS program treehouse.js that compares a few houses and trees. 
//The result should be printed on the console. 
//Run the program through Node.js. 

'use strict';

function treeHouseCompare(a, b) {
	var houseArea = (a * a) + (a * (2 * a / 3) / 2),
		treeArea = (b * (b / 3)) + (Math.PI * (2 * b / 3) * (2 * b / 3));

	if (houseArea > treeArea) {
		console.log('house/' + houseArea.toFixed(2));
	} else if (treeArea > houseArea) {
		console.log('tree/' + treeArea.toFixed(2));
	} else {
		console.log('house/' + houseArea.toFixed(2) + '=' + 'tree/' + treeArea.toFixed(2));
	}
}

treeHouseCompare(3, 2);
treeHouseCompare(3, 3);
treeHouseCompare(4, 5);