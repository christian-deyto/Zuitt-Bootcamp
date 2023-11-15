// console.log("Happy Sahod Day!");


// Non - Mutator Methods

/*
	- Non-Mutator methods are functions that do not modify or change the original array after they're created.
	- These methods do not manipulate the original array but perform various tasks such as returning elements from an array and combining arrays and printing these arrays out.

*/


let countries = ["US", "PH", "CAN", "SG", "TH", "PH", "FR", "DE"];

// indexOf()

/*
	- Returns the index number of the first matching element found in an arrau.
	- If no match was found, the result will be -1.
	- The process will be done from the first element proceeding to the last element.

	Syntax:
		arrayName.indexOf(searchValue);
		arrayName.indexOf(searchValue, fromIndex);
*/

let firstIndex = countries.indexOf("PH");
console.log("Result of indexOf method: " + firstIndex);

let invalidCountry = countries.indexOf("BR");
console.log("Result of indexOf method: " + invalidCountry);


let secondPH = countries.indexOf("PH", 3);
console.log("Result of indexOf method: " + secondPH);

let findPHAgain = countries.indexOf("PH", 6);
console.log("Result of indexOf method: " + findPHAgain);


// lastIndexOf()

/*
	- Returns the index number of the last matching element found in an array.
	- If no match was found, the result will be -1.
	- The process will be done from the last element proceeding to the first element.

	Syntax:
		arrayName.lastIndexOf(searchValue);
		arrayName.lastIandexOf(searchValue, fromIndex);
	
*/


let lastIndex = countries.lastIndexOf("PH");
console.log("Result of lastIndexOf method: " + lastIndex);

secondPH = countries.lastIndexOf("PH", 4);
console.log("Result of lastIndexOf method: " + secondPH);

findPHAgain = countries.lastIndexOf("PH", 0);
console.log("Result of lastIndexOf method: " + findPHAgain);


// slice() 

/*
	- Portions/slices elements from an array AND returns a new array containing the sliced elements.

	Syntax:
		arrayName.slice(startingIndex);
		arrayName.slice(startingIndex, endingIndex);
	
*/


// Slicing off elements from a specified index to the last element:
let slicedArrayA = countries.slice(2);
console.log("Result from slice method:")
console.log(slicedArrayA);


// Slicing off elements from a specified index to another index:
let slicedArrayB = countries.slice(2, 4);
console.log("Result from slice method:")
console.log(slicedArrayB);
console.log(countries);


// Slicing off elements from the last element to a specified number:
let slicedArrayC = countries.slice(-3);
console.log("Result from slice method:")
console.log(slicedArrayC);


// This method also works but this is not recommended.
let slicedArrayD = countries.slice(-5, -3);
console.log("Result from slice method:")
console.log(slicedArrayD);



// toString()

/*
	- Returns an array as a string separated by commas
	Syntax:
		arrayName.toString();

*/


let stringArray = countries.toString();
console.log("Result from toString method: ");
console.log(stringArray);


// concat()

/*
	- Combines two arrays and returns the combined result.
	Syntax:
		arrayA.concat(arrayB);
		arrayA.concat(elementA);
*/


let tasksArrayA = ['drink html', 'eat javascript'];
let tasksArrayB = ['inhale css', 'breathe sass'];
let tasksArrayC = ['get git', 'be node'];


let tasks = tasksArrayA.concat(tasksArrayB);
console.log("Result from concat method:")
console.log(tasks);

// Combining multiple arrays
let allTasks = tasksArrayA.concat(tasksArrayB, tasksArrayC);
console.log("Result from concat method:")
console.log(allTasks);

// Combining arrays with elements
let combinedTasks = tasksArrayA.concat("smell express", "throw react");
console.log("Result from concat method:")
console.log(combinedTasks);

// join()

/*
	- Returns an array as a string separated by specified string symbol/separator string.

	Syntax:
		arrayName.join('separatorString')

*/


let users = ["John", "Jane", "Joe", "Robert"];

console.log(users.join());
console.log(users.join(' '));
console.log(users.join(' - '));


// Iteration Methods

/*
	- Iteration methods are loops designed to perform repititive tasks or arrays.
	- Iteration methods loops over all the items in an array.
	- Useful for manipulating array data resulting in complex tasks.
	- Array iteration methods normally work with a function supplied as an argument.
	- How these function/s work is by performing tasks that are pre-defined within an array's method.

*/


// forEach()

/*
	- Similar to a for loop that iterates on each array element.
	- For each item in the array, the anonymous function passed in the forEach() method will be run.
	- The anonymous function is able to receive the current item being iterated or loooped over by assigning a parameter.
	- Variable names for arrays are normally written in plural form of dat store in an array but it's a common practice to use singular form of the array content for parameter name used in array loops.
	- forEach() does not return anything.

	Syntax:
		arrayName.forEach(function(individualElement) {
			statement/ code block;
		});

*/ 


console.log("")

allTasks.forEach(function(task) {
	console.log(task);
});


// Using forEach with conditional statements
let filteredTask = [];


allTasks.forEach(function(task) {

	if(task.length > 10) {
		filteredTask.push(task);
	};

});

console.log("Result of filtered task using forEach method:");
console.log(filteredTask);


// map()

/*
	- Iterates on each element AND returns new array with different values depending on the result of the function's operation.
	- This is useful for performing tasks where mutating/changing the elements are required.
	- Unlike forEach metods, the map method requires the use of a "return" statement in order to create another array with the performed operation.

	Syntax
		let/const resultArray = arrayName.map(function(individualElement) {
			statement/code block;
		});


*/



let numbers = [1, 2, 3, 4, 5];

let numberMap = numbers.map(function(number) {
	return number * number;
});

console.log("Original Array:");
console.log(numbers);
console.log("Result of the map method:");
console.log(numberMap);


// map() vs forEach()


// This will result to undefined.
// In order to pass the data, we need to save/push it to another array variable/ a variable.
let numberForEach = numbers.forEach(function(number) {
	return number * number;
});

console.log(numberForEach);


// every() 

/*
	- Checks if all elements in an array meet the given condition.
	- This is useful for validating data stored in arrays especially when dealing with large amounts of data.
	- Returns a "true" value if all elements meet the condition and "false" if otherwise

	Syntax:
		let/const resultArray = arrayName.every(function(indivElem) {
			return expression/condition
		});
	

*/ 


let allValid = numbers.every(function(number) {
	return(number < 3);
});

console.log("Result of every method:");
console.log(allValid);

// some()

/*
	- Checks if at least one element in an array meets the given condition.
	- This is useful for validating data stored in arrays especially when dealing with large amounts of data.
	- Returns a "true" value if at least one element meets the condition and "false" if otherwise

	Syntax:
		let/const resultArray = arrayName.some(function(indivElem) {
			return expression/condition
		});
	
*/


let someValid = numbers.some(function(number) {
	return(number < 2);
});

console.log("Result of some method:");
console.log(someValid);


// Combining the returned result from every/some method may be used in other statements to perform consecutive results.

if(someValid) {
	console.log("Some of the numbers from the array are greater than 2.");
};


// filter()

/*
	- Returns a new array that contains elements which meets the given condition.
	- Returns an empty array if no elements were found.
	- Useful for filtering array elements with a given condition and shortens the syntax compared to using other array iteration methods.
	
	Synatx:
		let/const resultArray = arrayName.filter(function(indivElem) {
			return expression/condition;
		});


*/


let filterValid = numbers.filter(function(number) {
	return (number < 3);
});

console.log("Result of filter method:")
console.log(filterValid);

let nothingFound = numbers.filter(function(number) {
	return (number == 0);
});

console.log("Result of filter method:")
console.log(nothingFound);

let filteredNumbers = [];

numbers.forEach(function(number) {
	if(number < 3) {
		filteredNumbers.push(number);
	}
});

console.log("Result of filtering numbers using forEach method:")
console.log(filteredNumbers);



// includes()

/*
	- Checks if the argument passed can be found in the array.
	- Returns a boolean which can be saved in a variable.specified.
		- returns true if the argument is found in the array.
		- returns false if not.

	Syntax:
		let/const resultArray = arrayName.includes(<argumentToFind>);
*/


let products = ["Mouse", "Keyboard", "LAPTOP", "Monitor"];

let productFound1 = products.includes("Mouse");
console.log("Result from indcludes method:");
console.log(productFound1);

let productFound2 = products.includes("Headset");
console.log("Result from indcludes method:");
console.log(productFound2);


let filteredProducts = products.filter(function(product) {
	return product.toLowerCase().includes("a");
});

console.log(filteredProducts);


// reduce()

/*
	- Evaluates elements from left to right and returns/ reduces the array into a single value.
	
	Syntax:
		let/const resultArray = arrayName.reduce(function(accumulator, currentvalue) {
				return expression/operation
		});


	accumulator - accumulator parameter in the function stores the result of every iteration of the loop.
	currentValue - is the current / next element in the array that is evaluated in each iteration of the loop.

*/

// let numbers = [1, 2, 3, 4, 5];

let iteration = 0;

let reducedArray = numbers.reduce(function(x, y) {
	console.warn("current iteration: " + ++iteration);
	console.log("accumulator: " + x);
	console.log("currentValue: " + y);

	// The operation to reduce the array into a single value.
	return x+y;
});

console.log("Result of the reduce method: " + reducedArray);


let list = ['Hello', "World", "Again"];

let reducedJoin = list.reduce(function(x, y) {
	return  x + ' ' + y;
});

console.log("Result of reduce method: " + reducedJoin);