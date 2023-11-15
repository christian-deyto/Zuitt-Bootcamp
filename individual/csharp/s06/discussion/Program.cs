namespace discussion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [SECTION] Inheritance
            // Inheritance allows us to inherit or pass fields and method from one class to another.
            // This allows reusability of code functionality adhering to the DRY principle
            // The "Crocodile" class has inherited all the properties and methods from the Animal and Reptile classes.
            // Inheritance is an "is type" of relationship between classes.

            Crocodile myPet = new Crocodile();
            myPet.Classification = "Reptile";
            myPet.DietType = "Carnivore";
            myPet.Habitat = "Fresh Water";
            myPet.HasScales = true;
            myPet.Name = "Dragon";
            myPet.Age = 7;

            Console.WriteLine("Result of Inheritance");
            myPet.DescribePet();
            myPet.Swim();
            myPet.Sleep();
            myPet.Eat();

            Crocodile myOtherPet = new Crocodile("Godzilla", 1000, "Reptile", "Carnivore", "Underground", true);
            myOtherPet.DescribePet();
            myOtherPet.Swim();
            myOtherPet.Sleep();
            myOtherPet.Eat();

            //[SECTION] Inheritance vs Composition
            // Inheritance creates an is-a relationship (e.g. crocodile is a reptile and reptile is an animal)
            //Composition create a has-a relationship (e.g a driver has a car.)
            // Inheritance creates a tight coupling of classes, meaning when an implementation of the parent/base class changes, so will the child classes inheriting from them.
            // Composition create a loose coupling such that when one of the classes, change it may or may not directly affect the other classes.

            Driver myDriver = new Driver("Michael Schumacher", 52);
            Car myCar = new Car("Ferrari", "F430", myDriver);

            //The Name field is not available because the "Car" class did not inherit the "Driver" class but is composed of.
            //myCar.Name = "Ralph";

            Console.WriteLine(myCar.Driver.Name);

            Console.WriteLine("Result of Polymorphism:");
            Turtle myFavoritePet = new Turtle("Rhaegal", 7, "Reptile", "Herbivore", "Salt Water", false);
            myFavoritePet.Swim();
            myFavoritePet.Swim("Pasig");
            myFavoritePet.Swim(5);
            myFavoritePet.Swim("Pasig", "Swimming");

            myPet.Swim();


        }
    }
}