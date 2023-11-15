namespace discussion
{
    class Discussion
    {
        static void Main(string[] args)
        {
            //[SECTION] Encapsulation
            // Encapsulation is the process of enclosing one or more items within a physical or logical package.
            // It prevents access to implementation details


            // Using the method below to define information to be used in the app is tasky and creates confusion:
            /*
                        string petAName = "Franky";
                        string petAGender = "Female";
                        string petAClassification = "Dog";
                        int petAAge = 10;
                        string petAAddress = "Manila, Philippines";
                        string petASound = "Bark!";


                        describePet(petAName, petAGender, petAClassification, petAAge, petAAddress);
                        makeSound(petAName, petASound);


                        string petBName = "Simba";
                        string petBGender = "Male";
                        string petBClassification = "Lion";
                        int petBAge = 1;
                        string petBAddress = "Pride Lands";
                        string petBSound = "Rawr!";


                        describePet(petBName, petBGender, petBClassification, petBAge, petBAddress);
                        makeSound(petBName, petBSound);
            */


            //Instantiate object from Pet class
            Pet petA = new Pet("Franky", "Female", "Dog", 10, "Manila, Philippines", "Bark!");

            petA.DescribePet();
            petA.MakeSound();


            Pet petB = new Pet("Simba", "Male", "Lion", 1, "Pride Lands", "Rawr!");

            petB.DescribePet();
            petB.MakeSound();



            /* 
             * Pet petC = new Pet();

             petC.name = "Brithney";
             petC.Gender = "Female";

                here we changed the access modifier of the name field of the Pet class, that's why we can directly manipulate the name field while the gender field is private that's why we need its getter/setter method before we can manipulate this property/field.

             */


            //[SECTION] Abstraction
            // Abstraction is the process where all the logic and code complexity is hidden from the user/ other developers which helps reduce confusion and allows them to focus on the "What?" of things rather than the "How?"
            // Objects cannot be instantiated from interfaces


            Casio myCalculator = new Casio("Casio", "500");
            myCalculator.Compute(23, 45, "add");
            myCalculator.TurnOff();


            Sharp myOtherCalculator = new Sharp("Sharp", "1000");
            myOtherCalculator.Compute(23, 45, "add");
            myOtherCalculator.TurnOff();

            /* ICalculator myOtherCalculator = new Sharp("Sharp", "1000");
             myOtherCalculator.Compute(23, 45, "add");
             myOtherCalculator.TurnOff();*/

            useCalculator(myCalculator);
            useCalculator(myOtherCalculator);




        }
        /*
                public static void describePet(string name, string gender, string classification, int age, string address)
                {
                    Console.WriteLine($"{name} is a {gender} {classification} who is {age} years of age and lives in {address}");
                }

                public static void makeSound(string name, string sound)
                {
                    Console.WriteLine($"{name} says {sound}");
                }
        */



        public static void useCalculator(ICalculator calculator)
        {
            calculator.Compute(23, 45, "add");
        }

    }
}