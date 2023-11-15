namespace discussion
{
    class Discussion
    {
        static void Main(string[] args)
        {
            // [SECTION] Exceptions
            // An exception is a problem that arises during the execution of the program.
            // A C# exception is a response to an exceptional circumstance that arises while a program is running, such as an attempt to divide a number by 0.

            // The Console.Readline() method returns a string. When converting the value to a different data type and the user inputs a value that cannot be converted, the application will result in an exception.
            // When an exception occurs, the applicaiton will terminate abnormally, making it unresponsive and users will not be able to interact with it.
            //Console.WriteLine("Please input a number");
            //int numA = Convert.ToInt32(Console.ReadLine());

            // [SECTION] Try-Catch Finally Statement and Exception Handling
            // To ensure that the application will not terminate when an exeception is encountered, try-catch-finally statements may be used to handle these exceptions and tell the applications/user what to do.
            /*
                        int numA;

                        // What will be the code that the application will try to execute.
                        try
                        {
                            Console.WriteLine("Please input a number");
                            numA = Convert.ToInt32(Console.ReadLine());
                        }
                        //Multiple catch statements can be used to capture different exceptions and perform a different tasks.
                        catch (FormatException e)
                        {
                            Console.WriteLine("The input you provided is not a number");
                        }
                        // What will be the app do once it catches an exception
                        // There are several exceptions that can be encountered
                        // All exceptions inherit from the "Exception" base class allowing us to use the "Exception" class in a catch statement to capture possible exceptions.
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                            Console.WriteLine(e.Message);
                            //Console.WriteLine(e);

                        }
                        finally
                        {
                            Console.WriteLine("Please input a valid number");
                            numA = Convert.ToInt32(Console.ReadLine());
                        }


            */

            try
            {
                MultipleExceptions();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide a number by zero.");
                Console.WriteLine(e.Message);
            }
            catch (MyException e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void MultipleExceptions()
        {
            Console.WriteLine("Which error would you like to receive?");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please input a number:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int divideByZero = number / 0;
                    break;
                case 2:
                    // The "throw" leyword can be used to force an exception when needed.
                    throw (new MyException("This is a user defined exception."));
                    // The break statement will now be unreachable because of the throwing of an exception.
                    break;
                default:
                    Console.WriteLine("Please input a valid option.");
                    break;
            }
        }
    }
}