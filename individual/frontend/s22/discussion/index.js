// console.log("Hello World!");


// What are conditional statements?

	// Conditional Statements allow us to control the flow of our program. It allows us to run a statement/instruction if a condition is met or run another seperate instruction if otherwise.


// [SECTION] if, else is and else statement (if-else)

let numA = -1;

// if statement
// Executes a statement if the specified condition is true.

if(numA < 0) {
	console.log("Hello");
};


// We can also check the condition using console.log(). The epxression results to a boolean true because of the use of the less than operator.
console.log(numA < 0);

numA = 0;

if(numA < 0) {
	console.log("Hello again if numA is less than 0!");
};

console.log(numA < 0);



// Let try using string data type:
let city = "New York";

if(city === "New York") {
	console.log("Welcome to New York City!");
};



// else if
/*
	- Executes a statement if the previouse conditions are false and if the specified condition is true.
	- The "else if" clause is optional and can be added to capture additional conditions to change the flow of the program.
	
*/

console.log("");


// Here the word "World" is printed in the console because the condition in the if statement is false, hence, we proceed in evaluating the condition in the else if code block.

let numB = 1;

if(numA < 0) {
	console.log("Hello");
} else if(numB > 0) {
	console.log("World");
};


console.log("");


// Here the execution of the code already stopped at the if code block since the condition was met.

numA = 1;

if(numA > 0) {
	console.log("Hello");
} else if(numB > 0) {
	console.log("World");
};

city = "Tokyo";

if(city === "New York") {
	console.log("Welcome to New York City!");
} else if(city === "Tokyo") {
	console.log("Welcome to Tokyo, Japan!");
};


// else statement
/*
	- Executes a statement if all the other conditions are false.
	- The "else" statement is also optional and can be added to capture any other result to change the flow of program.
*/


console.log("")

if(numA === 0) {
	console.log("Hello");
} else if(numB === 0) {
	console.log("World");
} else {
	console.log("Again");
};



/*
- This will result to a syntax error. We cannot start our if-else statement with an else if statement.

else if(numB === 0) {
	console.log("World");
} else {
	console.log("Again");
};*/



/*
- This will result to a syntax error. We cannot start our if-else statement with an else statement.

else {
	console.log("Again");
};*/



// if-else inside a function/s
/*
	- Most of the times we would like to use if-else statements with functions to control thr flow of our application.
	- By including them inside a function, we can decide when a certain conditions will be checked instead of executing statement when the Javascript load.

*/

let message = "No message";
console.log(message);


function determineTyphoonIntensity(windSpeed) {
	if(windSpeed < 30) {
		return 'Not a typhoon yet.';
	} else if (windSpeed <= 61) {
		return 'Tropical depression detected.';
	} else if (windSpeed >= 62 && windSpeed <= 88) {
		return 'Tropical storm detected.';
	} else if (windSpeed >= 89 && windSpeed <= 177) {
		return 'Severe tropical storm detected.';
	} else {
		return 'Typhoon detected.';
	}
};


message = determineTyphoonIntensity(72);
console.log(message);


if(message == 'Tropical storm detected.') {
	console.warn(message);
}

// [SECTION] Truthy and Falsy

/*
	- In JS a "truthy" value is a value that is considered true when encounted in a Boolean context.
	- Values are considered true unless defined otherwise.
	- Falsy values/exceptions for truthy:
		1. false
		2. 0
		3. -0
		4. ""
		5. undefined
		6. NaN
		7. null
*/


//Truthy examples:

if(true) {
	console.log("Truthy");
};

if(1) {
	console.log("Truthy");
};

if([]) {
	console.log("Truthy");
};

if({}) {
	console.log("Truthy");
};

if("message") {
	console.log("Truthy");
};


// Falsy examples
if(false) {
	console.log("Falsy");
};

if(0) {
	console.log("Falsy");
};


if(-0) {
	console.log("Falsy");
};

if("") {
	console.log("Falsy");
};

if(undefined) {
	console.log("Falsy");
};

if(NaN) {
	console.log("Falsy");
};

if(null) {
	console.log("Falsy");
};


// [SECTION] Conditional Ternary Operator
/*
	The condiction ternary operator takes three operand:
		1. condition/expression
		2. expression/statement to execute if the condition is truthy.
		3. expression/statement to execute if the condition is falsy.

	Syntax:
		(expression) ? ifTrue : ifFalse;

*/

// Single statement execution
let ternaryResult = (1 < 18) ? true : false;
console.log("Result of Ternary Operator: " + ternaryResult);

// Multiple statement execution
let name;

function isOfLegalAge() {
	name = 'John';
	return 'You are of the legal age limit';
}

function isUnderAge() {
	name = 'Jane';
	return "You are under the age limit";
}

// let age = parseInt(prompt("What is your age?"));
// console.log(age);
// let legalAge = ( age > 18) ? isOfLegalAge() : isUnderAge();
// console.log("Result of Ternary Operator in functions: " + legalAge + ', ' + name);


// [SECTION] Switch Statement


// let day = prompt("What day of the week is it today?").toLowerCase();
// console.log(day);


// switch(day) {
// 	case 'monday':
// 		console.log("The color of the day is red");
// 		break;
// 	case 'tuesday':
// 		console.log("The color of the day is orange");
// 		break;
// 	case 'wednesday':
// 		console.log("The color of the day is yellow");
// 	case 'thursday':
// 		console.log("The color of the day is green");
// 		break;
// 	case 'friday':
// 		console.log("The color of the day is blue");
// 		break;
// 	case 'saturday':
// 		console.log("The color of the day is indigo");
// 		break;
// 	case 'sunday':
// 		console.log("The color of the day is violet");
// 		break;
// 	default:
// 		console.log("Please input a valid day");
// 		break;
// };



// Try-Catch-Finally



function showIntensityAlert(windSpeed) {

	try {
		alerat(determineTyphoonIntensity(windSpeed));
	} catch (error) {
		console.log(typeof error);

		console.log(error)

		console.warn(error.message)
	} finally {
		alert('Intensity updates will show new alert.')
	}

};


showIntensityAlert(56);