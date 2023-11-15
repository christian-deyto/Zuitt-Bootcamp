namespace activity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                MultipleExceptions();
                int index = 3;
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
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("The element you are trying to access does not exist.");
                Console.WriteLine(e.Message);
            }
        }

        public static void MultipleExceptions()
        {
            int option;
            do
            {
                Console.WriteLine("Which error would you like to receive? [1]DivideByZeroException, [2]UserDefinedException, [3]IndexOutOfRangeException");
                if (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
                {
                    Console.WriteLine("Please input a valid option!!!");
                }
            } while (option < 1 || option > 3);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please input a number!!!");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int divideByZero = number / 0;
                    break;
                case 2:
                    throw (new MyException("This is a user defined exception."));
                case 3:
                    Console.WriteLine();
                    int[] array = new int[3];
                    int index = array[3];
                    break;
                default:
                    Console.WriteLine("Please input a valid option!!!");
                    break;
            }
        }
    }
}