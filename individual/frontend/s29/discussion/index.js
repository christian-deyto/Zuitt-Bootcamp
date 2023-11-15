// console.log("Pasko na!");


// [SECTION] Exponent Operator

const firstNum = Math.pow(8,2);
console.log(firstNum);



// After ES6 update
const secondNum = 8 ** 2;
console.log(secondNum);


// [SECTION] Template Literals

/*
	- Allows to write strings without using the concatenation operator (+)
	- Greatly helps with code readability
*/

let name = "John";


// Pre-template literal string
// Uses single quotes ('')
let message = 'Hello ' + name + '! Welcome to Pointwest!';
console.log("Message without template literals: " + message);

// Strings using template literal
// Uses backticks (``)
message = `Hello ${name}! Welcome to Pointwest!`;
console.log("Message with template literals: " + message);


// Multi-line String using template literal:
const anotherMessage = `
${name} attended a math competition.
He won it by solving the problem 8 ** 2 with the solution of ${secondNum};
`;

console.log(anotherMessage);

const interestRate = .1;
const principal = 1000;

console.log(`The interest in your savings account is: ${principal * interestRate}`);


// [SECTION] Array Destructuring
/*
	- Allows to unpack elements in arrays into distinct variables.
	- Allows us to name array elements with variables instead of using index numbers
	- Helps with code readability

	Syntax:
		let/const [variableNameA, variableNameB, variableNameC] = arrayName;
*/



const fullName = ["John", "Doe", "Smith"];

// Pre-Array destructuring
// let firstName = fullName[0];
// let middleName = fullName[1];
// let lastName = fullName[2];

// console.log(firstName);
// console.log(middleName);
// console.log(lastName);


// Array Destructuring
const [firstName, middleName, lastName] = fullName;

console.log(`Hello ${firstName} ${middleName} ${lastName}! It's nice to meet you!`);




// [SECTION] Object Destructuring
/*
	- Allows us to unpack properties of objects into distinct variables.
	- Shortens the syntax for accessing properties from object (e.g. dont notation);
*/


// Object literals
const person = {
	givenName: "Jane",
	maidenName: "Dela",
	familyName: "Cruz",
	address: {
		streetNo: 80,
		streetName: "Ilang-Ilang Street",
		city: "Quezon City",
		country: "Philippines"
	}
};

// Pre-Object destructuring
console.log(person.givenName);
console.log(person.maidenName);
console.log(person.familyName);
console.log(person.address.city);

console.log(`Hello ${person.givenName} ${person.maidenName} ${person.familyName}! It's good to see you again!`)

// Object Destructuring
const {givenName, maidenName, familyName, address} = person;

console.log(givenName);
console.log(maidenName);
console.log(familyName);
console.log(address);
console.log(address.city);

const {streetNo, streetName, city, country} = address;

console.log(city);

console.log(`Hello ${givenName} ${maidenName} ${familyName}! It's good to see you again!`);


// [SECTION] Arrow Functions
/*
	- Compact alternative syntax to the traditional functions.
	- Useful for code snippets where creating functions will not be reused in any other portion of the code.
	- Adheres to the "DRY" (Don't Repeat Yourself) principle where there is no longer a need to create a function and think of a name for functions that will only be used in certain code snippets.

	Syntax:
		let/const variableName = () => {
				statement/ code block;
		};

*/

const hello = () => {
	console.log("Hello World!")
}

hello();


// Pre-Arrow Function and Template Literals
function printFullName (firstName, middleName, lastName) {
	console.log(firstName + ' ' + middleName + ' ' + lastName);
};

printFullName("John", "Doe", "Smith");

// Arrow Function
const printFullName2 = (firstName, middleName, lastName) => {
	console.log(`${firstName} ${middleName} ${lastName}`);
};

printFullName("John", "Doe", "Smith")

// Arrow function with loops

const students = ["John", "Ada", "Jane"];

// Pre-arrow function
students.forEach(function(student) {
	console.log(`${student} is a trainee in Pointwest.`);
})

// Arrow function
students.forEach((student) => {
	console.log(`${student} is a trainee in Pointwest.`);
})


// [SECTION] Implicit Return
/*
	- There are instances when you can omit the "return" statement/keyword.
	- This works because even without the "return" statement Javascript implicitly add it for the result of the function.
*/

// Pre-Implicit Return
// const add = (x, y) => {
// 	return x + y;
// };

// let total = add(1, 2);
// console.log(total)

// Arrow Function with implicit return
let add = (x, y) => x + y;

let total = add(1, 2);
console.log(total)


// [SECTION] Default Function Argument Value
// Provides a default argument value if none is provided when the function is invoked.

const greet = (name = 'User') => {
	return `Good morning, ${name}`;
};

// console.log(greet("John"));

// function was invoked without passing an argument
console.log(greet());


// [SECTION] Class-Based Object Blueprints

/*
	- Allows creation/instantiation of objects using classes as blueprints
*/


// Creating a class
/*
	- The constructor is a special method of a class for creating/initializing an object for that class.
	- The "this" keyword refers to the properties of an object created/initialized from that class.
	- By using the "this" keyword and accessing an object's property, this allows us to reassign it's values.

	Syntax:
	class className {
		contructor(objectPropertyA, objectPropertyB) {
			this.objectPropertyA = objectPropertyA;
			this.objectPropertyB = objectPropertyB;
		}
	}
*/



class Car{
	constuctor(brand, name, year) {
		this.brand = brand;
		this.name = name;
		this.year = year;
	}
};

const myCar = new Car();

console.log(myCar);

// Values of properties may be assigned after the creation/instantiation of an object.
myCar.brand = "Ford";
myCar.name = "Ranger Raptor";
myCar.year = "2021";

console.log(myCar);



// Creating/Instantiating a new object from a car class with initialized
const myNewCar = new Car("Toyota", "Vios", 2021);
console.log(myNewCar);