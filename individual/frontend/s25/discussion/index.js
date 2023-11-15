console.log("Malapit na ang sahod!");



// An array in programming is smiply a list of data. Let's write here the example earlier:

let studetnNumberA = "2023-1923";
let studetnNumberB = "2023-1924";
let studetnNumberC = "2023-1925";
let studetnNumberD = "2023-1926";
let studetnNumberE = "2023-1927";


console.log(studetnNumberA);
console.log(studetnNumberB);
console.log(studetnNumberC);
console.log(studetnNumberD);
console.log(studetnNumberE);

// Now, with an array, we simply write the code above like this:
let studentNumbers = ['2023-1923', '2023-1924', '2023-1925', '2023-1926', '2023-1927'];


console.log(studentNumbers);

// [SECTION] Arrays

/*
	- Arrays are used to store multiple related value in a single variable.
	- They are declared using square bracket ([]) also known as "Array Literals".
	- Arrays also provide access to a number of functions/methods that help in manipulating data to perform a number of task.
	Syntax:
		let/const arrayName = [ elementA, elementB, elementC...];

*/


// Common examples of arrays
let grades = [98.5, 94.3, 89.2, 90.1];
let computerBrands = ["Acer", "Asus", "Lenovo", "Neo", "Redfox", "Gateway", "Toshiba", "Fujitsu"];


//Possible use of an array but this is not recommended
let mixedArr = [12, "Asus", null, true, undefined, {}];


console.log(grades);
console.log(computerBrands);
console.log(mixedArr);


// Alternative way to write arrays:
let myTasks = [
	"drink html",
	"eat javascript",
	"inhale css",
	"bake sass"
];


console.log(myTasks);


// Creating an array with values from variables:
let city1 = "Tokyo";
let city2 = "Manila";
let city3 = "Jakarta";

let cities = [city1, city2, city3];

console.log(cities);

// [SECTION] length property

//  The .lenght property allows us to get and set the total number of item in an array.

console.log(myTasks.length);
console.log(cities.length);


let blandArr = [];
console.log(blandArr.length);


// length property can also be used with strings. Some array methods and properties can also be used with strings.

let fullName = "Jaime Noble";
console.log(fullName.length);


// lenght property can also set the total number of items in an array, meaning we can actually delete the last item in the array or shorten the array by simply updating its lenght property.

myTasks.length = myTasks.length - 1;
console.log(myTasks.length);
console.log(myTasks);


// Another example using decrementation
cities.length--;
console.log(cities);


// We can't do the same on strings.
fullName.length = fullName.length-1;
console.log(fullName.length);
fullName.length--;
console.log(fullName);


// If you can shorten the array by setting the lenght property, you can also lenghten it by adding a number into the lenght property.
let theBeatles = ["John", "Paul", "Ringo", "George"];
console.log("Length of theBeatles array before incrementation:")
console.log(theBeatles.length);
// Here we added post increment to the length of theBeatles array.
theBeatles.length++
console.log("Length of theBeatles array after incrementation:")
console.log(theBeatles.length);



// [SECTION] Reading from Arrays
/*
	- Accessing arrays elements is one of the more common tasks that we do with an array.
	- This can be done through the use of array indixes.
	- Each element in an array is associated with its own index number.
	- In JS, the first element is associated with the number 0 and increasing this number by 1 for every additional element.
	- Array indixes actually refer to an address/location in the device's memory and how the information is stored.

		Array address : 0x7ffe9472bad0
		Array[0] = 0x7ffe9472bad0
		Array[1] = 0x7ffe9472bad4
		Array[2] = 0x7ffe9472bad8

	Syntax:
		arrayName[indexNum];

*/

console.log(grades[0]);
console.log(computerBrands[3]);
// Trying to access an array element that does not exist will return "undefined".
console.log(grades[20]);


// Although this works, this is not a good practice of assigning indexes to our values/elements.
grades[20] = 75;
console.log(grades);


				//  these are the indixes assigned to each element:
				//    0         1       2         3         4
let lakersLegends = ["Kobe", "Shaq", "LeBron", "Magic", "Kareem", "West"];

console.log(lakersLegends[1]);
console.log(lakersLegends[3]);

// You can also save/store arrays items in another variable:
let currentLaker = lakersLegends[5];
console.log(currentLaker);

// You can also reassign array values using the item's indixes:
console.log("Array before reassignment:");
console.log(lakersLegends);
lakersLegends[2] = "Pau Gasol";
console.log("Array after reassignment:");
console.log(lakersLegends);


// Accessing the last element of an array
//  Since the first element of an array starts with 0, subtracting 1 to the lenght of an araal will offset the value allowing us to access the last element in the array.

let bullsLegend = ["Jordan", "Pippen", "Rodman", "Rose", "Kukoc"];

console.log(bullsLegend);

let lastElementIndex = bullsLegend.length - 1;
console.log(bullsLegend[lastElementIndex]);


console.log(bullsLegend[bullsLegend.length-1]);


// Adding items into the Array

let newArr = [];
console.log(newArr[0]);

newArr[0] = "Cloud Strife";
console.log(newArr);

newArr[1] = "Tifa Lockhart";
console.log(newArr);


newArr[newArr.length] = "Barrett Wallace";
console.log(newArr);


// Looping over an array

for(let index = 0; index < newArr.length; index++) {
	console.log(newArr[index]);
};


let numArr = [5, 12, 30, 46, 40];

for(let index = 0; index < numArr.length; index++) {
	if (numArr[index] % 5 === 0) {
		console.log(numArr[index] + " is divisible by 5.");
	} else {
		console.log(numArr[index] + " is not divisible by 5.");
	}
};

// [SECTION] Multi-dimensional Arrays

/*
	- Multi-dimensional arrays are useful for storing complex structures.
	- a practical application of this is to help visualize/create real world objects.
	- Though useful in a number cases, creating complex array structures is not always recommended.

*/

let chessBoard = [
	['a1', 'b1', 'c1', 'd1', 'e1', 'f1', 'g1', 'h1'],	
	['a2', 'b2', 'c2', 'd2', 'e2', 'f2', 'g2', 'h2'],	
	['a3', 'b3', 'c3', 'd3', 'e3', 'f3', 'g3', 'h3'],	
	['a4', 'b4', 'c4', 'd4', 'e4', 'f4', 'g4', 'h4'],	
	['a5', 'b5', 'c5', 'd5', 'e5', 'f5', 'g5', 'h5'],	
	['a6', 'b6', 'c6', 'd6', 'e6', 'f6', 'g6', 'h6'],	
	['a7', 'b7', 'c7', 'd7', 'e7', 'f7', 'g7', 'h7'],	
	['a8', 'b8', 'c8', 'd8', 'e8', 'f8', 'g8', 'h8']	
];

console.log(chessBoard);


// Accessing elements of a multi-dimensional array
console.log(chessBoard[1][4]);

console.log("Pawn moves to: " + chessBoard[1][5]);