// console.log("Hello, sahod. Goodbye.")


// [SECTION] JSON Objects/ JSPN Data Format
/*
	- JSON stands for JavaScript Object Notation
	- JSON is also used in other programming languages, hence the name JavaScript Object Notation.
	- Core JS has a built in JSON object that contains methods for parsing JSON objects and converting strings into JavaScript objects.
	- JSON is used for serializing different data types into bytes.
	- Serialization is the process of converting data into a series of bytes for easier transmission/transfer of information.

	Syntax:
	{
		"propertyA": "valueA",
		"propertyB": "valueB"
	}

*/


// JSON Objects
// {
// 	"city": "Quezon City",
// 	"province": "Metro Manila",
// 	"country": "Philippines"
// }

// // [SECTION] JSON Arrays

// "cities": [
// 	{"city": "Quezon City", "province": "Metro Manila", "country": "Philippines"},
// 	{"city": "Manila City", "province": "Metro Manila", "country": "Philippines"},
// 	{"city": "Makati City", "province": "Metro Manila", "country": "Philippines"},
// ];


// [SECTION] JSON Methods
// - The JSON object contains methods for parsing and converting data into stringified JSON.



// Converting Data into Stringified JSON

/*
	- Stringified JSON is a JavaScript object converted into a string to be used in other functions of JavaScript application.
	- They are commonly used in HTTP requests where information is required to be sent and received in a stringified JSON format.
	- A database normally stores information/data that can be used by most applications.
	- An example of where JSON is also used in on package.json file which an express JS application uses to keep track of the information regarding the project.

*/

let batchesArr = [{batchName: 'Batch X'}, {batchName: 'Batch Y'}];


// The "stringify" method is used to convert to JavaScript Objects into stringify JSON
console.log("Result from stringify method:");
console.log(JSON.stringify(batchesArr));


let data = JSON.stringify({
	name: "John",
	age: 31,
	address: {
		city: "Manila",
		country: "Philippines"
	}
})

console.log(data);


// [SECTION] Using Stringify Method with Variables

/*
	- When information is stored in a variable and is not hard coded into an object that is being stringified, we can supply the value within the variable.
	- The "property" name and "value" name would have the same name which can be confusing for beginners.

	Syntax:
		JSON.stringify({
			propertyA: variableA,
			propertyB: variableB
		})

*/ 


// User details
// Input fields or Form elements to gather user inputs.
// let firstName = prompt("What is your First Name?");
// let lastName = prompt("What is your Last Name?");
// let age = prompt("What is your age?");
// let address = {
// 	city: prompt("Which city do  you live in?"),
// 	country: prompt("Which country does your city belong to?")
// };


// let userData = JSON.stringify({
// 	firstName: firstName,
// 	lastName: lastName,
// 	age: age,
// 	address: address
// });

// console.log(userData);


/* 
	Mini-Activity - 10 min.

	1. Create a game character object using JS Object and convert it into JSON stringify object.
	2. The character object must contain the following properties and data type values:
		a. heroName: string
		b. role: string
		c. level: number
		d. skills: object (minimum of 3 skills with string values or you may explore adding arrays or nested object.)
	3. These information must be provided via user input.
	4. Ouput the stringified object into the console and send a screenshot into our general channel.

*/

let character = {
  heroName: "Batman",
  role: "vigilante",
  level: 200,
  skills: {
    skill1: "Stealth",
    skill2: "Martial Arts",
    skill3: "Detective Work"
  }
};

let characterData = JSON.stringify(character);
console.log(characterData);

// Converting Stringified JSON into JavaScript Object
/*
	- Objects are a common data type used in applications because of the complex data structure that can be created out of them.
	- Information is commonly sent to applications in stringified JSON and then converted back into objects.
	- This happens both for sending information to a backend app and sending information back to a frontendd app.
*/

let bacthesJSON = `[{"batchName": "Batch X"}, {"batchName": "Batch Y"}]`;

console.log("Result from your parse method: ");
console.log(JSON.parse(bacthesJSON));

let stringifiedObject = `{ "name": "John", "age": "31", "address": {"city": "Manila", "country": "Philippines"}}`;

console.log(JSON.parse(stringifiedObject));