// console.log("Hello World");


//Objective 1
//Add code here
//Note: function name is numberLooper

function numberLooper(number){
    let message = "No message."
    for (let currentValue = Number(number); currentValue >= 0; currentValue--){
        if (currentValue <= 50){
            message = "The current value is at " + currentValue + ". Terminating the loop.";
            break;
        };
        if (currentValue % 10 == 0){
            console.log("The number is divisible by 10. Skipping the number.");
            continue;
        };
        if (currentValue % 5 == 0){
            console.log(currentValue);
        };
    };
    return message;
};




//Objective 2
let string = 'supercalifragilisticexpialidocious';
console.log(string);
let filteredString = '';

//Add code here

for (let i=0; i<string.length; i++) {
    if (string[i].toLowerCase() == "a" ||
        string[i].toLowerCase() == "e" ||
        string[i].toLowerCase() == "i" ||
        string[i].toLowerCase() == "o" ||
        string[i].toLowerCase() == "u"
        ) {
        continue;
    } else {
        filteredString += string[i];
    };
};
console.log(filteredString);




//Do not modify
//For exporting to test.js
//Note: Do not change any variable and function names. All variables and functions to be checked are listed in the exports.
try{
    module.exports = {

        filteredString: typeof filteredString !== 'undefined' ? filteredString : null,
        numberLooper: typeof numberLooper !== 'undefined' ? numberLooper : null
    }
} catch(err){

}