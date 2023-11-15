using System.Collections;

namespace activity
{
    class Activity
    {
        static void Main(string[] args)
        {

            ArrayList myArrayList = new ArrayList();
            ArrayList items = new ArrayList(new string[] { "Computer", "Mouse", "Keyboard" });

            Console.WriteLine("Welcome to Zuitt Management App!");

            Console.WriteLine("Choose an option: [1] Retrieve All Items, [2] Create Item, [3] Delete Item, [4] Edit Item");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    String stringifiedArrayList = String.Join(", ", items.ToArray());
                    Console.WriteLine(stringifiedArrayList);
                    break;
                case 2:
                    Console.WriteLine("Enter new product name:");
                    string newItem = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(newItem))
                    {
                        Console.WriteLine("Invalid Option.");
                    }
                    else
                    {
                        items.Add(newItem);
                        Console.WriteLine((newItem) + " has been successfully added");
                        Console.WriteLine(String.Join(", ", items.ToArray()));
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter item name:");
                    string deleteItem = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(deleteItem))
                    {
                        Console.WriteLine("Invalid Option.");
                    }
                    else if (items.Contains(deleteItem))
                    {
                        items.Remove(deleteItem);
                        Console.WriteLine((deleteItem) + " has been successfully removed");
                        Console.WriteLine(String.Join(", ", items.ToArray()));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Sorry po di ko nagawa :(");
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }
    }
}