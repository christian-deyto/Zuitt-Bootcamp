console.log("Hello World");


// [SECTION] Functions

	// Parameters and Arguments

	/*
		Functions in JS are lines/blocks of codes that tell our device/application to perform a certain task when called/invoked.

	*/


		// function printInput() {
		// 	let nickname = prompt("Enter your nickname:");
		// 	console.log("Hi, " + nickname);
		// };

		// printInput();


		// However, in some cases, this may not be ideal.
		// For other cases, functions can also process data directly passed into it instead of relying only on Global variables and prompt().


		// Consider this example:

		function printName(name) {
			console.log("My name is " + name)
		};

		printName("Juana");

		// Here we passed the data directly into the function.
		// The "name" is called parameter.
		// Parameter/s act as a named variable/container that exist only inside the function.
		// It is used to store information that is provided to function when it's called/invoked.



		printName("John");

		printName("Bernard");



		// We can pass data using prompt method
		// let promptVar = prompt("Enter your nickname:");

		// printName(promptVar);


		// We can pass data using global variables
		let globalVar = "Blessie";

		printName(globalVar);


		function checkDivisibilityBy8(num) {
			let remainder = num % 8;
			console.log("The remainder of " + num + " divided by 8 is: " + remainder);

			let isDivisibleBy8 = remainder === 0;
			console.log("Is " + num + " divisible by 8?");
			console.log(isDivisibleBy8);
		};


		checkDivisibilityBy8(64);
		checkDivisibilityBy8(126);
		checkDivisibilityBy8(579);
		checkDivisibilityBy8(600);
		checkDivisibilityBy8(880);

		// Function arguments cannot be used by function if there are no parameters provided within the funtion.



		// Functions as Arguments

		// Function parameters can also accept other functions as arguments.
		// Some complex functions use other functions as arguments to perform more complicated results.


		function argumentFunction() {
			console.log("This function was passed as an argument before the message was printed.")
		};


		// 2. The instructions from argumentFunction was passed as a parameter in invokeFunction
		function invokeFunction(argumentFunction) {

			//3. We access the argumentFunction module to invoke the function.
			//4. This will result to executing the console.log insrtuction from the argumentFunction() function.
			argumentFunction();

			console.log("This message was printed after the results of the argumentFunction was processed and passed into the invokeFunction()")

		};


		// Here the argumentFunction serves as a middleware/module that acts like a package containing information about the function.
		console.log(argumentFunction);

		// 1. The process starts here. The receiving is invoked and the reference function was passed as argument/ function middleware.

		invokeFunction(argumentFunction);


		// Using Multiple Parameters
		// Multiple "arguments" will correspond to the number of "parameters" declared in a function in succeeding order.


		function createFullName(firstName, middleName, lastName) {
			console.log(firstName + ' ' + middleName + ' ' + lastName);
		};


		// "Juan" will be stored in the parameter "firstName"
		// "Dela" will be stored in the parameter "middleName"
		// "Cruz" will be stored in the parameter "lastName"
		createFullName("Juan", "Dela", "Cruz");
		createFullName("Sisa", "Dela", "Cruz");
		createFullName("John", "Carter", "Smith");



		// In JS, providing more/less arguments than the expected parameters will not return an error.
		// Providing less arguments than the expected parameters will automatically assign an undefined value to the parameter.
		// In other programming languaes, this will return an error stating that "the expected number of arguments do not macth the number of parameters."


		createFullName("Juan", "Dela");
		createFullName("Juan", "Dela", "Cruz", "Hello");


		// Using variables as arguments
		let firstName = "John";
		let middleName = "Carter";
		let lastName = "Smith";


		createFullName(firstName, middleName, lastName);



		// The order of the argument is the same order of the parameters.

		function printLegalName(middleName, firstName, lastName) {
			console.log(firstName + ' ' + middleName + ' ' + lastName);
		}

		printLegalName('Juan', 'Dela', 'Cruz');




		function printWelcomeMessage(){
			let firstName = prompt("Enter your First Name:");
			let lastName = prompt("Enter your Last Name:");

			console.log("Hello, " + firstName + " " + lastName + "!");
			console.log("Welcome to my page!");
		};

		printWelcomeMessage();