// alert("Check you account!");


// [SECTION] Array Methods


// Javascript has build-in methods and functions for arrays. This allows us to manipulate and access array items.


// Mutator Methods
/*
	- Mutators methods are functions that "mutate" or change an array after they're created.
	- These methods manipulate the original array performing various tasks such us adding and/or removing elements.

*/

let fruits = ["Apple", "Orange", "Kiwi", "Papaya", "Dragon Fruit"];


// push()
/*
	- Adds an element at the end of an array AND returns the array's length.

	Syntax:
		arrayName.push("itemToPush");

*/


console.log("Current Array:");
console.log(fruits);
let fruitsLength = fruits.push("Mango");
console.log(fruitsLength);
console.log("Mutated array from push method:");
console.log(fruits);


// Adding multiple elements to an array
fruits.push("Avocado", "Guava");
console.log("Mutated array from push method:");
console.log(fruits);


// Let's try it in a functions
function addFruit(fruit) {

	fruits.push(fruit);
};


addFruit("Pineapple");
console.log(fruits);


// pop()

/*
	- Removes the last element in an array AND returns the removed element.

	Syntax:
		arrayName.pop();
*/


let removedFruit = fruits.pop();
console.log(removedFruit);
console.log("Mutated array from pop method:")
console.log(fruits);

function removeFruit() {
	fruits.pop();
};


removeFruit();
console.log(fruits);


// unshift()

/*
	-Adds one or more elements at the beginning of an array.

	Syntax:
		arrayName.unshift('elementA');
		arrayName.unshift('elementA', 'elementB');
*/


fruits.unshift("Lime", "Banana");
console.log("Mutated array from unshift method:")
console.log(fruits);


function unshiftFruit(fruit) {
	fruits.unshift(fruit);
};

unshiftFruit("Calamansi");
console.log("Mutated array from unshift method:")
console.log(fruits);



// shift()

/*
	- Removes an element at the beginning of an Array AND returns the removed element.

	Syntax:
		arrayName.shift();
*/

let anotherFruit = fruits.shift();
console.log(anotherFruit);
console.log("Mutated array from shift method:")
console.log(fruits);


function shiftFruit() {
	fruits.shift();
}

shiftFruit();
console.log("Mutated array from shift method:")
console.log(fruits);


// splice()

/*
	- Simultaneously removes elements from a specified index number and adds new elements.

	Syntax:
		arrayName.splice(startingIndex, deleteCount, elementsToBeAdded);

*/

fruits.splice(1, 2, "Lime", "Cherry");
console.log("Mutated array from splice method:")
console.log(fruits);


function spliceFruit(index, deleteCount, fruit) {

	fruits.splice(index, deleteCount, fruit);
};

spliceFruit(1, 1, "Langka");
console.log("Mutated array from splice method:")
console.log(fruits);
spliceFruit(2, 1, "Durian");
console.log("Mutated array from splice method:")
console.log(fruits);


// fruits.splice(3, 3);
// console.log("Mutated array from splice method:")
// console.log(fruits);


// sort()

/*
	- Rearranges the array elements in alphanumeric order.

	Syntax:
		arrayName.sort();
*/

// fruits.sort();
// console.log("Mutated array from sort method:")
// console.log(fruits);


let mixedArr = [10, "angel", 25, 100, 1000, 99, "demon", "architect", "ball"];

mixedArr.sort();
console.log("Mutated array from sort method:")
console.log(mixedArr);


// reverse()

/*
	- Reverse the order of array elements.

	Syntax:
		arrayName.reverse();
*/

// fruits.reverse();
// console.log("Mutated array from reverse method:")
// console.log(fruits);



// Method chaining

/*
	- We combine a series of methods to perform a more complex tasks in an array.
*/


fruits.sort().reverse();
console.log("Mutated array from sort + reverse methods:")
console.log(fruits);


/*
	Mini-Activity:

	1. Create an array names cartoons and initialize it by listing 3 of your favorite cartoons.
	2. Use the array methods to perform various mutations on the original array.
		a. add 2 more elements at the beginning.
		b. replace 1 element at index 3.
		c add 1 more element at the end.

	3. Sort the list in alphabetic order.

*/