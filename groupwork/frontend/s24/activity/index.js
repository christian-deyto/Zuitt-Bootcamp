// console.log("Hello World");

//Strictly Follow the property names and spelling given in the google slide instructions.
//Note: Do not change any variable and function names. 
//All variables and functions to be checked are listed in the exports.

// Create an object called trainer using object literals

// Initialize/add the given object properties and methods
let trainer = {};

// Properties
trainer.name = "Ash Ketchum";
trainer.age = 10;
trainer.pokemon = ["Pidgeot", "Butterfree", "Tauros", "Snorlax"];
trainer.friends = {
    hoenn: ["May", "Max"],
    kanto: ["Brock", "Misty"]
};

// Methods
trainer.talk = function() {
    return "Pikachu! I choose you!";
};

// Check if all properties and methods were properly added
console.log(trainer);

// Access object properties using dot notation
console.log("Result of dot notation: ");
console.log(trainer.name);

// Access object properties using square bracket notation
console.log("Result of square bracket notation: ");
console.log(trainer["pokemon"]);

// Access the trainer "talk" method
console.log("Result of talk method: ");
console.log(trainer.talk());

// Create a constructor function called Pokemon for creating a pokemon
function Pokemon(name, level) {
    this.name = name;
    this.level = level;
    this.health = 2 * level;
    this.attack = 1 * level;
    this.tackle = function(target) {
        console.log(this.name + " tackled " + target.name);
        target.health -= this.attack;
        if (target.health <= 0) {
            target.health = 0;
            console.log(target.name + "'s health is now reduced to " + target.health)
            target.faint();
            return target.name + "'s health is now reduced to " + target.health;
        } else {
            console.log(target.name + "'s health is now reduced to " + target.health);
            return target.name + "'s health is now reduced to " + target.health;
        }
    }
    this.faint = function() {
        console.log(this.name + " fainted.")
        return this.name + " fainted."
    } 
}

// Create/instantiate a new pokemon
let pikachu = new Pokemon("Pikachu", 12);
console.log(pikachu);

// Create/instantiate a new pokemon
let geodude = new Pokemon("Geodude", 8);
console.log(geodude)


// Create/instantiate a new pokemon
let mewtwo = new Pokemon("Mewtwo", 100);
console.log(mewtwo);

// Invoke the tackle method and target a different object
geodude.tackle(pikachu);
console.log(pikachu);

// Invoke the tackle method and target a different object
mewtwo.tackle(geodude)
console.log(geodude);



//Do not modify
//For exporting to test.js
//Note: Do not change any variable and function names. All variables and functions to be checked are listed in the exports.
try{
    module.exports = {

        trainer: typeof trainer !== 'undefined' ? trainer : null,
        Pokemon: typeof Pokemon !== 'undefined' ? Pokemon : null

    }
} catch(err){

}