let x = 5
let y = 15
let a = 10
let b = 20
let c = 40
let d = 50
let e = 60
let f = 80

/*
    
    1. Create a function called addNum which will be able to add two numbers.
        - Numbers must be provided as arguments.
        - Return the result of the addition.
       
       Create a function called subNum which will be able to subtract two numbers.
        - Numbers must be provided as arguments.
        - Return the result of subtraction.

        Create a new variable called sum.
         - This sum variable should be able to receive and store the result of addNum function.

        Create a new variable called difference.
         - This difference variable should be able to receive and store the result of subNum function.

        Log the value of sum variable in the console.
        Log the value of difference variable in the console.
*/


    function addNum(x, y) {
        return x + y;
    }

    function subNum (b, x) {
        return b - x;
    }

    var sum = x + y;
    console.log ("Displayed sum of " + x + " and " + y);
    console.log (sum);
        
    var difference = b - x;
    console.log ("Displayed difference of " + b + " and " + x);
    console.log (difference);

/*
    2. Create a function called multiplyNum which will be able to multiply two numbers.
        - Numbers must be provided as arguments.
        - Return the result of the multiplication.

        Create a function divideNum which will be able to divide two numbers.
        - Numbers must be provided as arguments.
        - Return the result of the division.

        Create a new variable called product.
         - This product variable should be able to receive and store the result of multiplyNum function.

        Create a new variable called quotient.
         - This quotient variable should be able to receive and store the result of divideNum function.

        Log the value of product variable in the console.
        Log the value of quotient variable in the console.
*/

    function multiplyNum(d, a) {
        return d * a;
    }

    function divideNum(d, a) {
        return d / a;
    }

    var product = d * a;
    console.log ("The product of " + d + " and " + a)
    console.log(product)

    var quotient = d / a;
    console.log ("The quotient of " + d + " and " + a)
    console.log(quotient)

/*
    3. Create a function called getCircleArea which will be able to get total area of a circle from a provided radius.
        - a number should be provided as an argument.
        - look up the formula for calculating the area of a circle with a provided/given radius.
        - look up the use of the exponent operator.
        - return the result of the area calculation.

        Create a new variable called circleArea.
        - This variable should be able to receive and store the result of the circle area calculation.
        - Log the value of the circleArea variable in the console.
*/

    function getCircleArea(y) {
        return (y**2 * Math.PI);
    }

    var circleArea = y**2 * Math.PI;
    console.log("The result of getting the area of a circle within 15 radius:")
    console.log(circleArea)

/*
    4. Create a function called getAverage which will be able to get total average of four numbers.
        - 4 numbers should be provided as an argument.
        - look up the formula for calculating the average of numbers.
        - return the result of the average calculation.
        
        Create a new variable called averageVar.
        - This variable should be able to receive and store the result of the average calculation
        - Log the value of the averageVar variable in the console.
*/

    function getAverage(b, c, e, f) {
        var sum1 = b + c + e + f;
        var averageVar = sum1 / 4;
        return averageVar;
    }

    var result = getAverage(b, c, e, f);
    console.log("The average of 20, 40, 60, and 80:")
    console.log(result);
    
/*  
    5. Create a function called checkIfPassed which will be able to check if you passed by checking the percentage of your score against the passing percentage.
        - this function should take 2 numbers as an argument, your score and the total score.
        - First, get the percentage of your score against the total. You can look up the formula to get percentage.
        - Using a relational operator, check if your score percentage is greater than 75, the passing percentage. Save the value of the comparison in a variable called isPassed.
        - return the value of the variable isPassed.
        - This function should return a boolean.

        Create a global variable called outside of the function called isPassingScore.
            -This variable should be able to receive and store the boolean result of the checker function.
            -Log the value of the isPassingScore variable in the console.
*/

    function checkIfPassed(score, totalScore) {
        let percentage = (score / totalScore) * 100;
        var passingPercentage = 75;
        var isPassed = percentage > passingPercentage;
        return isPassed;
    }

    var isPassingScore = checkIfPassed(38, 50);
    console.log("Is 38/50 a passing score?");
    console.log(isPassingScore);




//Do not modify
//For exporting to test.js
//Note: Do not change any variable and function names. All variables and functions to be checked are listed in the exports.
try{
    module.exports = {

        addNum: typeof addNum !== 'undefined' ? addNum : null,
        subNum: typeof subNum !== 'undefined' ? subNum : null,
        multiplyNum: typeof multiplyNum !== 'undefined' ? multiplyNum : null,
        divideNum: typeof divideNum !== 'undefined' ? divideNum : null,
        getCircleArea: typeof getCircleArea !== 'undefined' ? getCircleArea : null,
        getAverage: typeof getAverage !== 'undefined' ? getAverage : null,
        checkIfPassed: typeof checkIfPassed !== 'undefined' ? checkIfPassed : null,

    }
} catch(err){

}