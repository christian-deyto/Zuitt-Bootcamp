// This is a statement:
console.log("Hello World!")

// This code will do the exact same thing:
console. log("Hello World!") ;


console.
log
(
	"Hello World!"
);



// Comments:
	
	/*
		There are 2 types of comments in JS:
			1. Singe-line comment denoted by two slashes. 
			Windows: ctrl + /
			MacOS: cmd + /
			2. Multi-line comment denoted by a 2 slashes and 2 asterisk.
				Windows: ctrl + shift + /
				MacOS: cmd + shift + /

	*/


// [SECTION] Variables

// Variables are used to contain data.


// Declaring Variables:

/*
	Syntax:
		let/const variableName;
*/


let myVariable;
console.log(myVariable);

// This will result in uncaught ref error since the variable was not declared.
// console.log(hello);

// let hello;

//  Declaring and Initializing Varuiables
let productName = "desktop computer";
console.log(productName);

let productPrice = 18999
console.log(productPrice)

const interest = 3.539

 












supplier = "John Smith tradings";
console.log(supplier)





supplier = "Zuitt Store";
console.log(supplier) 


/*let let = "let it be",;
console.log = let it be*/


// [SECTION] Data Types

// Strings

let country = 'Philippines';
let province = "Metro Manila";

let fullAddress = province + ', ' + country;
console.log(fullAddress);

let greeting = 'I live in the ' + country;
console.log(greeting);

let mailAddress = 'Metro Manila \nPhilippines';
console.log(mailAddress);

let message = "John's employees went home early";
console.log(message);

message = 'John\'s employees went home early';
console.log(message);

// numbers
let headcount = 19;
console.log(headcount);


let grade = 98.7;
console.log(grade);


let planetDistance = 2e10;
console.log(planetDistance)

console.log("John's grade last quarter is " + grade);



let isMarried = false;
let inGoodConduct = true;
console.log("isMarried: " + isMarried);
console.log("inGoodConduct: " + inGoodConduct)



let grades = [98.7, 92.1, 90.2, 94.6];
console.log(grades);


let details = ["John", "Smith", 32, true];
console.log(details);

let person = {
	fullname: 'Juan Dela Cruz',
	age: 35,
	isMarried: false,
	contact: ["+63917 123 4567", "8123 4567"],
	address: {
		houseNumber: '345',
		city: 'Manila'
	}
};
console.log(person);	

let myGrades = {
	firstGrading: 98.7,
	secondGrading: 92.1,
	thirdGrading: 90.2,
	fourthGrading: 94.6
};
console.log(myGrades);


console.log(typeof myGrades);
console.log(typeof grades);


let money = null;
let myMoney = 0;
let myString = '';

console.log(money);
console.log(myMoney);
console.log(myString);


let fullname;
console.log(fullname);