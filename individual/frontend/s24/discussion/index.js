// console.log("Happy Wednesday!");


// [SECTION] Objects

/*
	- An object is a data type that is used to represent real world or abstract objects.
	- It is a collection of related data and/or functionalities.
	- In JS, most core JS features like strings and arrays are objects (Strings are collection of characters and arrays are collection of data)
	- Information stored in objects are represented in a "key:value" pair.
	-Different data types may be stored in an object's property creating more complex data structures.

*/


// Creating objects using object initialer/literal notation.
	
	/*
		Syntax:
			let/const objectName = {
				keyA: valueA,
				keyB: valueB
			};

	*/



let cellphone = {
	name: "Nokia 3210",
	manufactureDate: 1999
};


console.log("result of object literal notation:");
console.log(cellphone);
console.log(typeof cellphone);



// Creating objects using a constructor function

/*
	- Creates a resuable function to create several objects that have the same data structure.
	- This is useful for creating multiple instance/copies of an object.
	- An instance is a concrete occurence of any object which emphasizes on the distinct/unique identity of the object.

	Syntax:
		function ObjectName(keyA, keyB) {
			this.keyA = keyA;
			this.keyB = keyB;
		};

*/


function Laptop(name, manufactureDate) {
	this.name = name;
	this.manufactureDate = manufactureDate;
};



// This is a unique instance of the Laptop object.
// The "new" keyword/operator allows us to create a new instance of an object.
let laptop = new Laptop("Lenovo", 2012);
console.log("result from creating an object using constructor function:");
console.log(laptop);



let myLaptop = new Laptop('MacBook Air', 2022);
console.log("result from creating an object using constructor function:");
console.log(myLaptop);


let oldLaptop = new Laptop("Portal R2E CCMC", 1980);
console.log("result from creating an object using constructor function:");
console.log(oldLaptop);


// Creating empty objects
let computer = {};
let myComputer = new Object();



console.log(computer);
console.log(myComputer);

computer.brand = "Toshiba";
computer.price = 18000;
console.log(computer);


myComputer.brand = "HP";
myComputer.price = 32000;
console.log(myComputer);


// [SECTION] Accessing Object Properties

// Using the dot notation
console.log("Result from dot notation: " + myLaptop.name);

// Using the square bracket notation
console.log("Result from square bracker notation: " + myLaptop['name']);




// Accessing Array Objects

/*
	- Accessing array elements can also be done using square bracket notation.
	- Accessing object properties using square brackter notation and array indixes can be confusing.

*/


let array = [laptop, myLaptop];

// This may cause confusion due to the similar square bracket.
console.log(array[0]['name']);

// This one is better in term of code readability.
console.log(array[0].name);


// [SECTION] Initialing/Adding/Deleting/Reassigning Object properties


let car = {};


// Initializing/adding object properties using dot notation. 
car.name = "Honda Civic";
console.log("Result from adding prop using dot notation:")
console.log(car);

// Initializing/adding object prop using square bracket notation.


car['manufacture date'] = 2019;
console.log(car['manufacture date']);
console.log(car['Manufacture Date']);
console.log(car.manufactureDate);
console.log("Result from adding prop using dot notation:")
console.log(car);



// Deleting object properties
delete car['manufacture date'];
console.log("Result from deleting prop:");
console.log(car);


// Reassigning object properties
car.name = 'Dodge Charger R/T';
console.log("Result from reassigning prop:");
console.log(car);



// [SECTION] Object Methods


let person = {
	name: "John",
	talk: function() {
		console.log("Hello my name is " + this.name);
	}
};


console.log(person);
console.log("Result from object methods:");
person.talk();

// Assigning methods to objects
person.walk = function() {
	console.log(this.name + " walked 25 steps forward.");
}

person.walk();


// Methods are useful for creating reusable functions that perform tasks related to objects.
let friend = {

	firstName: "Joe",
	lastName: "Smith",
	address: {
		city: "Austin",
		state: "Texas",
		country: "USA"
	},
	emails: ['joejoebizzare@gmail.com', 
	"joe.smith@gmail.com"],
	introduce: function() {
		console.log("Hello my name is " + this.firstName + " " + this.lastName);
		console.log("I am from " + this.address.city + ", " + this.address.state + ", " + this.address.country + ".");
	}
};


friend.introduce();


// [SECTION] Real World Application of JS Ojects


/*
	Scenario:
		1. We would like to create a game that would have several pokemon interact with each other.
		2. Every pokemon would have the same set of stats, properties and functions.
*/

// Using object literals

let myPokemon = {
	name: "Pikachu",
	level: 3,
	health: 100,
	attack: 50,
	tackle: function() {
		console.log("This Pokemon tackled targetPokemon.");
		console.log("targetPokemon's health is now reduced to _targetPokemonHealth_");
	},

	faint: function() {
		console.log("Pokemon fainted");
	}
};

console.log(myPokemon);
myPokemon.tackle();


// Using Object Constructor/ Constructor Function
function Pokemon(name, level) {
	// Properties
	this.name = name;
	this.level = level;
	this.health = 2 * level
	this.attack = level;


	// Object Methods
	this.tackle = function(target) {
		console.log(this.name + " tackled " + target.name);
		console.log("targetPokemon's health is now reduced to _targetPokemonHealth_");
	};
	this.faint = function() {
		console.log(this.name + " fainted");
	}
};


// Create new instances of pokemon
let togepi = new Pokemon("Togepi", 16);
let onix = new Pokemon("Onix", 8);

togepi.tackle(onix);