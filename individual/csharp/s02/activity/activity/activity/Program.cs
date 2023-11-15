using System;

namespace activity
{
    class Activity
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter product name:");
            string Name = Console.ReadLine();
            
            Console.WriteLine("Enter beginning inventory amount:");
            int beginningInventory = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter stock in amount:");
            int stockIn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter stock out amount:");
            int stockOut = Convert.ToInt32(Console.ReadLine());

            int totalBalance = beginningInventory + stockIn + stockOut;
            Console.WriteLine("The EOD total balance of computer is:");
            Console.WriteLine(totalBalance);

            Console.WriteLine("Enter price per unit:");
            int pricePerUnit = Convert.ToInt32(Console.ReadLine());

            double markupValue = 0.15D;
            double incomePerUnit = pricePerUnit * markupValue;
            double totalSales = incomePerUnit * totalBalance;

            Console.WriteLine($"The total sales for today is {totalSales}");

        }
    }
}