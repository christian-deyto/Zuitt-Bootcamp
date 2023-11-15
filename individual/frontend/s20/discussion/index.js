// alert("Hello Pointwest!");


// [SECTION] Functions

	// Functions in JS are lines/blocks of codes that tell our device/application to perform a certain task when called or invoked.
	// Functions are mostly created to perform complicated tasks to run several lines of codes in succession.
	// They are also used to prevent repeating lines/blocks of codes that perform the same task/function.


// Function Declarations
	// Define a function with specified parameters.

	/*
		Syntax:
			function functionName() {
				code block (statement)
			};

		function keyword - used to define a JS function.
		functionName - the function's name. Functions are named to be able to call them later in our code.
		function block ({} - the statement/s which comprise the body of the function. This is where the code to be executed is written.
	
	*/


	function printName() {
		console.log("My name is John.");
	};

	printName();


// Function Invocation

	// The code block and statements inside the function is not immediately executed when the function is defined/declared. The code block and statements inside a function is executed when the function is invoked or called.
	// It is common to use the term "call a function" instead of "invoke a function".

	printName();

	// declaredFunction(); - this will result to a reference error.


// Function Declarations vs Function Expressions

	// Function Declaration

		// A function can be created through function declaration by using the function keyword and adding a function name.


		declaredFunction(); // declared functions can be hoisted as long as the function has been defined in our file/program.

		function declaredFunction() {
			console.log("Hello world from declaredFunction()");
		};


		declaredFunction();


	//Function Expression
		// A function can also be stored in a variable.

		// A function expression is an anonymous function assigned to the variableFunction.

		// Anonymous function - a function without a name.


		// variableFunction(); this will result to a reference error because function expression/s cannot be hoisted.


		let variableFunction = function() {
			console.log("Hello Again!");
		};

		variableFunction();


		// We can also create a function expression of a named function.
		// However, to invoke a function expression, we call it by its variableName.


		let funcExpression = function funcName() {
			console.log("Hello from the other side.");
		};

		funcExpression();
		// funcName(); this will result to a reference error.

	// Re-assigning Functions
		//  We can reassign declared functions and function expressions with new anonymous functions.

		declaredFunction = function() {
			console.log("updated declaredFunction")
		};

		declaredFunction();


		funcExpression = function() {
			console.log("updated funcExpression")
		};

		funcExpression();


		const constantFunc = function() {
			console.log("Initialized with const!")
		};

		constantFunc();

		// However, we cannot re-assign a function expression initialized with const.

		/*constantFunc = function() {
			console.log("Cannot be re-assigned!")
		};

		constantFunc();
			- this will result to a type error.
		
		*/


// Function Scope

/*
	Scope is accessibility (visibility) of variables within our program.

	JavaScript Variables has 3 types of scopes:
		1. local/block scope - accessible only within the block of code.
		2. global scope - accessible anywhere within the document/program.
		3. function scope - accessible only within the function.

*/


	{
		let localVar = "John Doe";
		console.log(localVar);
	}

	let globalVar = "Mr. Worldwide";

	console.log(globalVar);
	// console.log(localVar); - this will result to a reference error.


	// Funtion Scope

	/*
		JS has a function scope: Each function creates a new scope.
		Variables defined inside a function are not accessible from outside the function.
		Variables declared with a var, let and const are quite similar when declared inside a function.
	*/


	function showNames() {
		// function scoped variables:
		var functionVar = "Joe";
		const functionConst = "John";
		let functionLet = "Jane";

		console.log(functionVar);
		console.log(functionConst);
		console.log(functionLet);
	};


	showNames();

	// console.log(functionVar); - this will result to a ref error.
	// console.log(functionConst); - this will result to a ref error.
	// console.log(functionLet); - this will result to a ref error.


// Nested Function
	// We can create another function inside a function. This nested function. being inside the parent function will have access to the variables, names and other code/statements within the same scope.



	function myNewFunction() {
		let name = "Jane";

		function nestedFunction() {
			let nestedName = "John";
			console.log(name);
		}

		nestedFunction();
		// console.log(nestedName); result to error

	};


	myNewFunction();
	// nestedFunction(); result to error.



// Function and Global Scope Variables

	// Global scoped variable
	let globalName = "Alan";

	function myNewFunction2() {
		// Fuction scoped variable.
		let nameInside = "Rich";

		console.log(globalName);

	};

	myNewFunction2();

	// console.log(nameInside); result to a ref error.


// [SECTION] Using Alert
	// alert() allow us to show a small window at the top of our browser page to show information to our users. 
	// Show a short dialog or instruction.
	// The page will wait until the user dismissed the dialog box before proceeding.

	// alert("Hello World"); // this will run immediately when the page loads.

	// function showSampleAlert() {
	// 	alert("Hello User!");
	// };

	// showSampleAlert();



	// This will not print in the console until we close the alert dialog box.
	console.log("Hello Again!");


//[SECTION] Using Prompt
	// prompt() allows us to show a small window at the top of the browser to gather user input.
	// The input from the prompt() will be returned as a String once the user dismisses the window.

	let samplePrompt = prompt("Enter your name:");

	console.log("Hello, my name is " + samplePrompt + ".");

	function printWelcomeMessage() {
		let firstName = prompt("Enter your First Name:");
		let lastName = prompt("Enter your Last Name:");

		console.log("Hello, " + firstName + " " + lastName + "!");
		console.log("Welcome to my page!");
	};

	printWelcomeMessage();


// Function Naming Conventions
	// Function names should be definitive of the task it will perform. It usually contains a verb.


	function getCourses() {

		let courses = ["Science 101", "Math 101", "English 101"];

		// Return statments - returns the value.
		return courses
	}


	let courses = getCourses();
	console.log(courses);

	// Avoid generic names to avoid confusion within your code.

	function get() {
		let name = "Jamie";
		return name;
	}


	let name = get();
	console.log(name);


	// Avoid pointless and inappropriate function names.

	function foo() {
		return 25%5;
	}

	console.log(foo());


	// Name your functions in small caps. Follow camelCase when naming variables and functions.
	// In JS, function names should be unique in a document.

	function displayCarInfo() {
		console.log("Brand: Toyota");
		console.log("Type: Sedan");
		console.log("Price: 1, 500, 000");
	};


	displayCarInfo();