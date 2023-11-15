using System;

namespace discussion
{
    class Discussion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");


            // [SECTION] Variables, Data Types and Constants

            //Referencing Data Types
            String myString = "Zuitt Asset Manager";

            //Value Types
            int myInt = 1;
            float myFloat = 5.7F;
            double myDouble = 2.5D;
            decimal myDecimal = 8.4M;
            long myLong = 57390L;
            bool myBoolean = false;

            const double interest = 5.3D;


            Console.WriteLine("Result of Data Types:");
            Console.WriteLine(myString);
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);
            Console.WriteLine(myLong);
            Console.WriteLine(myBoolean);
            Console.WriteLine(interest);


            //[SECTION] Concatation and String Interpolation

            //Concatinating string and variable values
            Console.WriteLine("Printing values using concatenation");
            Console.WriteLine("double: " + myDouble + ", decimal: " + myDecimal + ", boolean: " + myBoolean);


            //Using double quotes (") in conjunction with curly braces ({}) allows to make it easier to create human readable string outputs.
            Console.WriteLine("Printing values using double quotes and curly braces:");
            Console.WriteLine("double: {0}, decimal: {1}, boolean: {2}", myDouble, myDecimal, myBoolean);

            //String Interpolation using dollar symbol ($) for an even cleaner code.
            Console.WriteLine("Printing values using String Interpolation:");
            Console.WriteLine($"double: {myDouble}, decimal: {myDecimal}, boolean: {myBoolean}");

            //[SECTION] Type Conversion / Typecasting
            //Implicit Type Conversion
            // Conversions are done by C# without having to manually define the conversion from one type to the next type.
            // This works on values converted from smaller to larger integral/number types (e.g. int < float < double);

            float anotherFloat = myInt;
            double anotherDouble = myFloat;

            Console.WriteLine(anotherFloat);
            Console.WriteLine(anotherDouble);

            //Explicit Type Conversion
            // Conversions are done manually/explicitly defining the data type that a value is to be converted to.
            double convertedDouble = (double)myFloat;
            String convertedString = myInt.ToString();

            Console.WriteLine(convertedDouble);
            Console.WriteLine(convertedString);


            //[SECTION] User inputs via the console
            // The "ToInt" method has 3 different bit integer values
            // "ToInt16" converts a number to a short data type
            // "ToInt32" converts a number to a int data type
            // "ToInt64" converts a number to a long data type

            Console.WriteLine("Please enter a number");

            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you provided is {0}", userInput);


            //Checking if userInput is blank
            String stringInput = Console.ReadLine();
            Console.WriteLine("Result of isNullOrWhiteSpace");
            Console.WriteLine(string.IsNullOrWhiteSpace(stringInput));

            //[SECTION] Operators

            int numA = 10;
            int numB = 3;

            //Arithmetic Operators
            Console.WriteLine("Result of Arithmetic Operators:");
            Console.WriteLine(numA + numB);
            Console.WriteLine(numA - numB);
            Console.WriteLine(numA * numB);
            Console.WriteLine(numA / numB);
            Console.WriteLine(numA % numB);

            //Increment
            numA++;
            Console.WriteLine(numA);
            //Decrement
            numA--;
            Console.WriteLine(numA);

            //Relational Operators
            Console.WriteLine("Result of Relation Operators");
            Console.WriteLine(numA == numB);
            Console.WriteLine(numA != numB);
            Console.WriteLine(numA > numB);
            Console.WriteLine(numA < numB);
            Console.WriteLine(numA >= numB);
            Console.WriteLine(numA <= numB);


            //Logical Operators
            Console.WriteLine("Result of Logical Operators:");
            Console.WriteLine(numA == numB || numA > numB);
            Console.WriteLine(numA == numB && numA > numB);
            Console.WriteLine(!myBoolean);

            //Assignment Operators
            Console.WriteLine("Result of Assignment Operators:");
            Console.WriteLine(numA += numB);
            Console.WriteLine(numA -= numB);
            Console.WriteLine(numA *= numB);
            Console.WriteLine(numA /= numB);
            Console.WriteLine(numA %= numB);



            //Function Invocation
            printHelloWorld();

            Console.WriteLine("Result from arguments and parameters:");
            printName("John", "Doe");


        }


        
        //[SECTION] Functions
        // Functions are reusable pieces of code/s that is used to execute a specific task.

        public static String printHelloWorld()
        {
            Console.WriteLine("Hello World!");

            return "Hello World!";

            Console.WriteLine("This statement will never be printed");

        }



        public static String printName(String firstName, String lastName)
        {
            Console.WriteLine($"The name provided is: {firstName} {lastName}");
            return $"The name provided is: {firstName} {lastName}";
        }

    }
}
