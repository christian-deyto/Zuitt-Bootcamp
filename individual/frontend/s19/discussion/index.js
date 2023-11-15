console.log("Hello World!");


// [SECTION] Arithmetic Operators

let x = 1397;
let y = 7831;



// Addition Operator
let sum = x + y;
console.log("Result of addition operator: " + sum);


// Subtraction Operator
let difference = x - y;
console.log("Result of subtraction operator: " + difference);


// Multiplication Operator
let product = x * y;
console.log("Result of multiplication operator: " + product);


// Division Operator
let quotient = x / y;
console.log("Result of division operator: " + quotient);


// Modulo Operator
let remainder = x % y;
console.log("Result of modulo operator: " + remainder);


// [SECTION] Assignment Operators

// Basic Assignment Operator (=)
// The assignment operator assigns the value of the **right** operand to a variable.
let assignmentNumber = 8;
console.log(assignmentNumber);


// Addition Assignment Operator (+=)
// The addition assignment operator add the value of the right operand to a variable and assigns the result to the variable.

assignmentNumber = assignmentNumber + 2;
console.log("Result of addition assignment operator: " + assignmentNumber);


// Shorthand for assignmentNumber = assigmentNumber + 2;
assignmentNumber += 2;
console.log("Result of addition assignment operator: " + assignmentNumber);



// Subtraction/Multiplication/Division Assignment Operator (-=, *=, /=)
assignmentNumber -= 2;
console.log("Result of subtraction assignment operator: " + assignmentNumber);

assignmentNumber *= 2;
console.log("Result of multiplication assignment operator: " + assignmentNumber);

assignmentNumber /= 2;
console.log("Result of division assignment operator: " + assignmentNumber);


// Multiple Operators and Parenthesis

	//  When multiple operators are applied in a single statement, it follows the PEMDAS (parenthesis, exponents, Multiplication, Division, Addition, Subtraction) rule.

	/*
		Sequence of operation
		1. 3 * 4 = 12
		2. 12 / 5 = 2.4
		3. 1 + 2 = 3
		4. 3 - 2.4 = 0.6
	*/


let mdas = 1 + 2 - 3 * 4 / 5;
console.log("Result of mdas operation: " + mdas);


let pemdas = 1 + (2-3) * (4/5);
console.log("Result of pemdas operation: " + pemdas);

	/*
		1. 2 - 3 = -1
		2. 4 / 5 = 0.8
		3. -1 * 0.8 = -0.8
		4. 1 + -0.8 = 0.2
	*/
	

// Increment and Decrement
//  Operators that add or subtract values by 1 and reassigns the value of the variable where the increment/decrement was applied to

	let z = 1;

	// The value of "z" is added by a value of 1 before returning the value and storing it in the variable incremement.
	let increment = ++z;
	console.log("Result of pre-increment: " + increment);

	// The value of "z" was increase even though we didn't implicitly specify any value reassignment
	console.log("Result of pre-increment: " + z);


	// The value of "z" is returned ans stored in the variable "increment" then the value of "z" is increase by 1.
	increment = z++;
	console.log("Result of post-increment: " + increment);

	// The value of "z" was increased again reassigning the value to 3.
	console.log("Result of post-increment: " + z);


	// The value of "z" is decreas by a value of 1 before returning the value and storing it in the variable incremement.
	let decrement = --z;
	console.log("Result of pre-decrement: " + decrement);

	// The value of "z" was decreased even though we didn't implicitly specify any value reassignment
	console.log("Result of pre-decrement: " + z);


	// The value of "z" is returned and stored in the variable "decrement" then the value of "z" is decreased by 1.
	decrement = z--;
	console.log("Result of post-decrement: " + decrement);

	// The value of "z" was decreased again reassigning the value to 1.
	console.log("Result of post-decrement: " + z);


// [SECTION] Type Coercion

	/*
		- Type coercion is the automatic or implicit conversion of values from one data type to another data type.
		- This happens when operations are performed on different data types that would normally not be possible and yield irregular results.
		- Values are automatically converted from one data type to another data type in order to resolve operations.
	*/

let numA = '10';
let numB = 12;

let coercion = numA + numB;
console.log(coercion);
console.log(typeof coercion);


let numC = 16;
let numD = 14;


let nonCoercion = numC + numD;
console.log(nonCoercion);
console.log(typeof nonCoercion);


let numE = true + 1;
console.log(numE);


let numF = false + 1;
console.log(numF);



// [SECTION] Comparison Operators

let juan = 'juan';

// Equality Operator (==)
	/*
	-  Checks wheter the operands are equal/ have the same content.
	- Attempts to CONVERT and COMPARE operands of different data types.
	- Returns a boolean value.
	*/

console.log(1 == 1);
console.log(1 == 2);
console.log(1 == '1');
console.log(0 == false);
console.log('juan' == 'juan');
console.log('juan' == juan);


// Inequality Operator
	
	/*
	-  Checks wheter the operands are not equal/  do not have the same content.
	- Attempts to CONVERT and COMPARE operands of different data types.
	*/

console.log(1 != 1);
console.log(1 != 2);
console.log(1 != '1');
console.log(0 != false);
console.log('juan' != 'juan');
console.log('juan' != juan);



// Strict Equality Operator (===)
	/*
	-  Checks wheter the operands are equal/ have the same content.
	- Also compares the data types of the 2 values.
	- Returns a boolean value.
	*/

console.log(1 === 1);
console.log(1 === 2);
console.log(1 === '1');
console.log(0 === false);
console.log('juan' === 'juan');
console.log('juan' === juan);


// Strict Inequality Operator (!==)
	/*
	-  Checks wheter the operands are equal/ have the same content.
	- Also compares the data types of the 2 values.
	- Returns a boolean value.
	*/

console.log(1 !== 1);
console.log(1 !== 2);
console.log(1 !== '1');
console.log(0 !== false);
console.log('juan' !== 'juan');
console.log('juan' !== juan);


// [SECTION] Relational Operators
// Some comparison operators check whether one value is greater or less than to another value.

let a = 50;
let b = 65;

// GT or greater than operator (>)
let isGreaterThan = a > b;
console.log(isGreaterThan);
// LT or less than operator (<)
let isLessThan = a < b;
console.log(isLessThan);
// GTE or greater than or equal operator (>=)
let isGTE = a >= b;
console.log(isGTE);
// LTE  or less than or equal operator (<=)
let isLTE = a <= b;
console.log(isLTE);


let numStr = "30";
console.log( a > numStr);
console.log(b <= numStr);


let str = "seventy-five";
console.log(b >= str);



// [SECTION Logical Operators]

let isLegalAge = true;
let isRegistered = false;

// Logical AND Operator (&& - Double Ampersand)
// Returns true if all operands are true.
let allRequirementsMet = isLegalAge && isRegistered;
console.log("Result of logical AND operator: " + allRequirementsMet);


// Logical OR Operator (|| - Double Pipe)
// Returns a true if one of the operands is true.
let someRequirementsMet = isLegalAge || isRegistered;
console.log("Result of logical OR operator: " + someRequirementsMet);


// Logical NOT Operator (! - Exclamation Mark)
// Returns the opposite value
let someRequirementsNotMet = !isRegistered;
console.log("Result of logical NOT operator: " +someRequirementsNotMet);