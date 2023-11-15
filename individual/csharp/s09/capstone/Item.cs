using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstone
{
    internal class Item
    {
        private string name;
        private string branch;
        private int beginningInventory;
        private int stockIn;
        private int stockOut;
        private int totalBalance;


        public string Name { get => name; set => name = value; }
        public string Branch { get => branch; set => branch = value; }
        public int BeginningInventory { get => beginningInventory; set => beginningInventory = value; }
        public int StockIn { get => stockIn; set => stockIn = value; }
        public int StockOut { get => stockOut; set => stockOut = value; }
        public int TotalBalance { get => totalBalance; set => totalBalance = value; }

        public Item() {}

        public Item(string name, string branch, int beginningInventory, int stockIn, int stockOut, int totalBalance)
        {
            this.name = name;
            this.branch = branch;
            this.beginningInventory = beginningInventory;
            this.stockIn = stockIn;
            this.stockOut = stockOut;
            this.totalBalance = totalBalance;
        }

        public override string ToString()
        {
            return $"{{Name: {name}, Branch: {branch}, Beginning Inventory: {beginningInventory}, Stock In: {stockIn}, Stock Out: {stockOut}, Total Balance: {totalBalance}}}";
        }
    }
}
