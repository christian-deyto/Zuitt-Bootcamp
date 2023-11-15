using System.Collections;

namespace discussion
{
    class Discussion
    {
        static void Main(string[] args)
        {

            //[SECTION] Selection Control

            //Variables to use with if, else if, and else
            int numA = 10;
            int numB = 3;

            Console.WriteLine("Result of if, else if, and else statement:");

            if (numA > numB)
            {
                Console.WriteLine("numA is greater than numB");
            }
            else if (numA == numB)
            {
                Console.WriteLine("numA is greater than numB");
            }
            else
            {
                Console.WriteLine("numA is less than numB");
            }



            // [SECTION] Switch Statements

            //Console.WriteLine("What day of the week is today?");

            //string day = Console.ReadLine().ToLower();

            //switch (day)
            //{
            //    case "monday":
            //        Console.WriteLine("Red");
            //        break;
            //    case "tuesday":
            //        Console.WriteLine("Orange");
            //        break;
            //    case "wednesday":
            //        Console.WriteLine("Yellow");
            //        break;
            //    default:
            //        Console.WriteLine("Black");
            //        break;
            //}


            //Conditional Operator
            Console.WriteLine("Result of Conditional Operator");
            Console.WriteLine(numA > numB ? printHelloWorld() : printName("John", "Doe"));



            //[SECTION] Repetion Control Structure

            String word = "hello";

            //Code to printout all the values of an array without loops.
            Console.WriteLine(word[0]);
            Console.WriteLine(word[1]);
            Console.WriteLine(word[2]);
            Console.WriteLine(word[3]);
            Console.WriteLine(word[4]);


            //For Loops

            Console.WriteLine("Result of using loops with array elements:");
            for (int x = 0; x < word.Length; x++)
            {
                Console.WriteLine(word[x]);
            }

            //ForEach Loops
            // ForEach loops are used to execute a block of code for each element in a collection.
            Console.WriteLine("Result of using array forEach Loop:");
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            //While Loops
            Console.WriteLine("Result from while loops:");
            int numC = 5;

            while (numC > 0)
            {
                Console.WriteLine($"value of a: {numC}");
                numC--;
            }

            //Continue Statement

            Console.WriteLine("Result of Continue Statements:");
            int numD = 0;

            while(numD < 20)
            {
                if(numD % 5 == 0)
                {
                    Console.WriteLine("calue of numD: {0}", numD);
                }

                numD++;

                continue;
            }

            //Break Statements
            Console.WriteLine("Result from Break Statement:");
            int numE = 0;

            while (numE < 20)
            {
                if (numE == 10)
                {
                    break;
                }

                if (numE % 5 == 0)
                {
                    Console.WriteLine("value of numE: {0}", numE);
                }

                numE++;
            }

            //[SECTION] Arrays
            //An array stores a fixed-size sequential collection of elements of the same type.
            //An array is used to store a collection of data.

            //Declaring Arrays
                // an array is a reference type, so the "new" keyword is used to create an instance of an array.
                // As a reference type, it references an array class which allows access to different methods/function to make the manipulation of array much easier.
            int[] sales = new int[3];

            //Assigning values to array
            // C# arrays start with the 0 index value as the first element.
            sales[0] = 10;
            sales[1] = 5;
            sales[2] = 27;

            Console.WriteLine("Result from arrays:");
            Console.WriteLine(sales[0]);
            Console.WriteLine(sales[1]);
            Console.WriteLine(sales[2]);
            //Console.WriteLine(sales);
            Console.WriteLine($"First Element: {sales[0]}, Second Element: {sales[1]}, Third Element: {sales[2]}");

            // Array Declaration and Initialization
            string[] managers = new string[3]
            {
                "john", "jane", "joe"
            };

            //Printing the length of an array
            Console.WriteLine(sales.Length);

            //Printing arrays as a string
            Console.WriteLine("Result of using String.Join with arrays:");
            String stringifiedArray = String.Join(", ", managers);
            Console.WriteLine(stringifiedArray);

            //For Loops with Arrays
            Console.WriteLine("Result of using for loops with array elements:");
            for (int x = 0; x < managers.Length; x++)
            {
                Console.WriteLine(managers[x]);
            }

            //ForEach Loops with Arrays
            Console.WriteLine("Result of using foreach loops with array elements:");
            foreach(string manager in managers)
            {
                Console.WriteLine(manager);
            }

            //[SECTION]] Collections
            //Arraylist
            // A seriazible list that represent an ordered collection of an object that can be indexed individually

            //Declaring an array list
            ArrayList myArrayList = new ArrayList();

            //Declaring and Initializing an arrray list
            ArrayList customers = new ArrayList(new string[] { "Donald", "Mickey", "Goofy" });

            //Getting the index of an array list element
            customers.IndexOf("Mickey");

            //forEach loop with array lists
            Console.WriteLine("Result from array list:");
            foreach(string customer in customers)
            {
                Console.WriteLine(customer);
            }

            //Getting the length of an array list
            Console.WriteLine("Result from Count Property:");
            Console.WriteLine(customers.Count);

            //Printing array list as a string
            Console.WriteLine("Result of using String.Join with array list:");
            String stringifiedArrayList = String.Join(", ", customers.ToArray()); //convert to check the list
            Console.WriteLine(stringifiedArrayList);

            //Adding elements to an array lists
            myArrayList.Add("Harry");
            myArrayList.Add("Ron");
            myArrayList.Add("Hermione");

            Console.WriteLine("Result from adding Array List elements:");
            Console.WriteLine(String.Join(", ", myArrayList.ToArray()));

            //Adding elements in between an array list
            myArrayList.Insert(1, "Tom");

            Console.WriteLine("Result from adding in between elements and an Array List");
            Console.WriteLine(String.Join(", ", myArrayList.ToArray()));

            //Removing elements to an array list
            //Removing single element
            customers.Remove("Mickey");
            customers.RemoveAt(0);
            Console.WriteLine("Result from removing single element from an Array List");
            Console.WriteLine(String.Join(", ", customers.ToArray()));

            //Removing multiple elements
            //Removed 2 elements from index 1
            myArrayList.RemoveRange(1, 2);
            Console.WriteLine("Result from removing multiple elements from an Array List");
            Console.WriteLine(String.Join(", ", myArrayList.ToArray()));

            //Updating array list elements
            myArrayList[0] = "Luna";
            myArrayList[1] = "Draco";
            Console.WriteLine("Result from updating elements in an Array List");
            Console.WriteLine(String.Join(", ", myArrayList.ToArray()));

            //Sorting
            myArrayList.Sort();
            Console.WriteLine("Result from sorting elements in an Array List");
            Console.WriteLine(String.Join(", ", myArrayList.ToArray()));

            //Checking if elements exists in an array list
            //For strings, comparison using the "Contains()" method is case sensitive.
            Console.WriteLine("Result from array list Contains method:");
            Console.WriteLine(myArrayList.Contains("Luna"));
            Console.WriteLine(myArrayList.Contains("luna"));

            //Comparing ArrayList String Values
            Console.WriteLine("Input a name to check:");
            String stringComparison = Console.ReadLine();

            for(int x = 0; x < myArrayList.Count; x++)
            {
                if(string.Equals((string?)myArrayList[x], stringComparison, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{stringComparison} found.");
                    break;
                }

                if(x == myArrayList.Count - 1)
                {
                    Console.WriteLine("Name not found.");
                }
            }

            //Hashtables
            //Hashtables represent a collection of key-value pairs.
            // It is used when you need to access elements by using keys instead of index.

            //Declaring hashtables
            Hashtable myHashTable = new Hashtable();

            //Initializing Hashtables
            Hashtable address = new Hashtable();

            address.Add("houseNumber", "15");
            address.Add("street", "Apple");
            address.Add("city", "California");
            address.Add("zip", "19463");

            //Getting keys of hashtable
            //ICollection => Interface of collection data type
            ICollection addressKeys = address.Keys;
            ICollection addressValues = address.Values;

            Console.WriteLine("Result from accessing Hashtable keys:");
            Console.WriteLine(address["street"]);

            Console.WriteLine("Result from Hashtables:");
            foreach(string key in addressKeys) 
            {
                Console.WriteLine(address[key]);
            }

            foreach (string value in addressValues)
            {
                Console.WriteLine(address[value]);
            }

        }

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