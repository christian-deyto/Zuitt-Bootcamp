// console.log("Hello Pointwest!");


// [SECTION] While Loop

/*
	- A while loop takes in an expression/condition.
	- The expressions are any unit of code that can be evaluated to a value.
	- If the condition evaluates true, the statement/s inside the code block will be executed.
	- "Iteration" is term given to the repition of statements.

	Syntax:
		while(expression/condition) {
			statement/code block
		};

*/


let count = 5;

while(count !== 0) {
	console.log("While: " + count);
	count--;
};



// This will result to an infinite loop.
// warning: be careful in running your loops. Make sure to evaluate the condition and the how your iteration will proceed before executing your code/program.
// while(count < 6) {
// 	console.log(count);
// 	count--;
// };



/*

	Mini Activity:
		1. Declare a global variable named numA and initialize with value of -36.
		2. Create a while loop statement which will evaluate the value of the numA variable if it less than or equal to 36.
		3. Inside the while loop code block, print the message in the console if the condition remains true:
			a. the number is <value>.

		4. Perform post increment in every iteration.
*/



// let numA = -36;

// while(numA <= 36) {
// 	console.log("the number is " + numA);
// 	numA += 1
// };



// [SECTION] Do While Loop
/*
	- A do-while loops works a lot like the while loop. But unlike while loops, do-while loops guarantee that the code/statement will be executed at least once.

	Syntax:

		do {
			statement
		} while(expression/condition)

*/


console.log("");


// let number = Number(prompt("Please give a number:"));

// do{
// 	console.log("Do While: " + number);

// 	number++;
// } while(number < 10);


// do{
// 	console.log("Do While by 2: " + number);
// 	number+=2;
// } while(number < 50);






/*
	Mini-Activity
		1. Declare a function named doWhileAgeLoop. This function will contain a variable which will receive a number from the user input. Input your age.
		2. Use the number provided by the user to evaluate its value if it is less than or equal to 100.
		3. If the condition is true, print a message in the console:
			a. I will live until <value> years old.
	
*/



// function doWhileAgeLoop() {

// 	let age = Number(prompt("Please provide your age:"));

// 	do {
// 		console.log("I will live until " + age + " years old.");

// 		age++;

// 	} while(age <= 100);

// }

// doWhileAgeLoop();


// [SECTION] For Loop

/*
	- A for loop is more flexible than while and do-while loops. It consists of three parts:
		1. Initial value - tracks the progression of the loop.
		2. Expression/Condiction  - which will be evaluated to determine whether the loop will run one more time.
		3. Iteration/finalExpression - indicates how to advance the loop.

	Syntax:
		for(initialValue; condition; finalExpression) {
			statement/code block;
		};

*/


for(let count = 0; count <= 20; count++) {
	console.log(count);
};


let myString = "alex";
// Characters in strings may be counter using the .length property.

console.log(myString.length);


// Accessing elements in a string
// Individual characters of a string may be accessed using its index number.
// The index always starts at 0.
console.log(myString[0]);
console.log(myString[1]);
console.log(myString[2]);
console.log(myString[3]);


// This a loop which will print each letter of a word.
for(let x = 0; x < myString.length; x++) {

	console.log(myString[x]);

}


let myName = "Jonathan";

for(let i = 0; i < myName.length; i++) {

	// console.log(myName[i].toLowerCase());

	if (
			myName[i].toLowerCase() == "a" ||
			myName[i].toLowerCase() == "e" ||
			myName[i].toLowerCase() == "i" ||
			myName[i].toLowerCase() == "o" ||
			myName[i].toLowerCase() == "u"
		){
		console.log("This letter is a vowel.");
	} else {
		console.log(myName[i]);
	};
};




// [SECTION] Continue and Break Statements

/*
	- The "continue" statement allows the code to go to the next iteration of the loop without finishing the execution of all the statements in a code block.
	- The "break" statement is used to terminate the current loop once a match has been found.

*/


for(let count = 0; count <= 20; count++) {
	if (count % 2 === 0) {
		continue;
	}

	console.log("Continue and Break: " + count);

	if (count > 10) {
		break;
	}
};



let name = "martin";




for(let a = 0; a < name.length; a++) {

	console.log(name[a]);

	if (name[a].toLowerCase() === "a") {
		console.log("Continue to the next iteration");
		continue;
	}


	if (name[a] === "t") {
		break;
	};
};