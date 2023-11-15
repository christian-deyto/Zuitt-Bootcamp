using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    //Classes
    // Classes act as blueprint for data to be stored in the database as well as methods that define what a class is capable of doing.
    internal class Item
    {

        //4 Components of Classes

        //1. Fields
        private string name;
        // using the readonly keyword ensured that the field cannot be assigned a value at the class scope or in a constructor.
        private string branch;
        private int beginningInventory;
        private int stockIn;
        private int stockOut;
        private int totalBalance;

        //2. Getters and Setters
        public string Name { get => name; set => name = value; }
        // We only applied the getter method since we cannot re assign a new value on readonly properties/fields
        public string Branch { get => branch; set => branch = value; }
        public int BeginningInventory { get => beginningInventory; set => beginningInventory = value; }
        public int StockIn { get => stockIn; set => stockIn = value; }
        public int StockOut { get => stockOut; set => stockOut = value; }
        public int TotalBalance { get => totalBalance; set => totalBalance = value; }


        //3. Constructors
        // Empty/Default Constructor
        // It is best to include empty constructors in instances where instantiating an object without any fields is required.
        public Item ()
        {

        }

        //Parametarized constructor
        public Item(string name, string branch, int beginningInventory, int stockIn, int stockOut, int totalBalance)
        {
            this.name = name;
            this.branch = branch;
            this.beginningInventory = beginningInventory;
            this.stockIn = stockIn;
            this.stockOut = stockOut;
            this.totalBalance = totalBalance;
        }


        //4. Action/Function Methods

        public override string ToString()
        {
            return $"{{Name: {name}, Branch: {branch}, Beginning Inventory: {beginningInventory}, Stock In: {stockIn}, Stock Out: {stockOut}, Total Balance: {totalBalance}}}";
        }
    }
}
