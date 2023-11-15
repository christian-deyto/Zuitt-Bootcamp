using capstone;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;

class Program
{
    static List<User> users = new List<User>();
    static void Main(string[] args)
    {
        int option;
        while (true)
        {
            Console.WriteLine("Welcome to Zuitt Asset Management App!");
            Console.WriteLine("Choose an option: [1] Login, [2] Register, [3] Exit");

            User userA = new User("johndoe", "john1234");
            User userC = new User("admin", "admin1234");
            users.Add(userA);
            users.Add(userC);


            if (int.TryParse(Console.ReadLine(), out option))
            {
                if (option == 1)
                {
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();

                    User validatedUser = ValidateLogin(username, password);

                    if (validatedUser != null)
                    {
                        Console.WriteLine("User found:");
                        Console.WriteLine("Welcome " + validatedUser.Username + "!");

                        if (username == userC.Username && password == userC.Password)
                        {
                            AdminMenu();
                        }
                        else if (username == userA.Username && password == userA.Password)
                        {
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid user credentials, please check your username and password.");
                    }
                }
                else if (option == 2)
                {
                    RegisterUser();
                }
                else if (option == 3)
                {
                    Console.WriteLine("Exiting the application.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    static User ValidateLogin(string username, string password)
    {
        User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
        return user;
    }
    static void RegisterUser()
    {
        string newUsername, email, password, address, contact;

        while (true)
        {
            Console.WriteLine("Enter username:");
            newUsername = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newUsername))
            {
                Console.WriteLine("Please enter a valid username.");
            }
            else
            {
                break;
            }
        }

        while (true)
        {
            Console.WriteLine("Enter email:");
            email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Please enter a valid email.");
            }
            else
            {
                break;
            }
        }

        while (true)
        {
            Console.WriteLine("Enter password:");
            password = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Please enter a valid password.");
            }
            else
            {
                break;
            }
        }

        while (true)
        {
            Console.WriteLine("Enter address:");
            address = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Please enter a valid address.");
            }
            else
            {
                break;
            }
        }

        while (true)
        {
            Console.WriteLine("Enter contact number: (Contact Number should be at least 11 digits)");
            contact = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(contact) || contact.Length < 11)
            {
                Console.WriteLine("Please enter a valid contact number.");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("User successfully registered!");
        User newUser = new User(newUsername, email, password, address, contact, false);
        Console.WriteLine(newUser.ToString());
    }

    public static void AdminMenu()
    {
        ArrayList items = new ArrayList(new string[] { "Computer", "Mouse", "Keyboard" });

        while (true)
        {
            Console.WriteLine("Choose an option: [1] Retrieve All Items, [2] Create Item, [3] Edit Item, [4] Delete Item, [5] Exit");
            int option;

            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("No items to display");
                        break;

                    case 2:
                        CreateItem();
                        break;

                    case 3:
                        EditItem();
                        break;

                    case 4:
                        Console.WriteLine("Enter item name:");
                        string deleteItem = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(deleteItem))
                        {
                            Console.WriteLine("Invalid Option.");
                        }
                        else
                        {
                            items.Remove(deleteItem);
                            Console.WriteLine("Item " + deleteItem + " successfully deleted");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting admin menu.");
                        return; 
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }
        }
    }

    static void CreateItem()
    {
        Item itemD = new Item("Beef", "SM MOA", 0, 100, 15, 85);
        string newItemName;
        while (true)
        {
            Console.WriteLine("Enter item name:");
            newItemName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newItemName))
            {
                Console.WriteLine("Please enter a valid item name.");
            }
            else
            {
                break;
            }
        }

        string branch;
        while (true)
        {
            Console.WriteLine("Enter item branch:");
            branch = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(branch))
            {
                Console.WriteLine("Please enter a valid branch.");
            }
            else
            {
                break;
            }
        }

        int beginningInventory;
        while (true)
        {
            Console.WriteLine("Enter beginning inventory:");
            if (!int.TryParse(Console.ReadLine(), out beginningInventory))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            else
            {
                break;
            }
        }

        int stockIn;
        while (true)
        {
            Console.WriteLine("Enter Stock In:");
            if (!int.TryParse(Console.ReadLine(), out stockIn))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            else
            {
                break;
            }
        }

        int stockOut;
        while (true)
        {
            Console.WriteLine("Enter Stock Out:");
            if (!int.TryParse(Console.ReadLine(), out stockOut))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            else
            {
                break;
            }
        }
        Item newItem = new Item(newItemName, branch, beginningInventory, stockIn, stockOut, 0);
        Console.WriteLine(newItem.ToString());
    }

    static void EditItem()
    {
        Item itemD = new Item("Beef", "SM MOA", 0, 100, 15, 85);
        string newItemName;
        while (true)
        {
            Console.WriteLine("Enter item name:");
            newItemName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newItemName))
            {
                Console.WriteLine("Please enter a valid item name.");
            }
            else
            {
                break;
            }
        }

        string branch;
        while (true)
        {
            Console.WriteLine("Enter item branch:");
            branch = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(branch))
            {
                Console.WriteLine("Please enter a valid branch.");
            }
            else
            {
                break;
            }
        }

        int beginningInventory;
        while (true)
        {
            Console.WriteLine("Enter beginning inventory:");
            if (!int.TryParse(Console.ReadLine(), out beginningInventory))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            else
            {
                break;
            }
        }

        int stockIn;
        while (true)
        {
            Console.WriteLine("Enter Stock In:");
            if (!int.TryParse(Console.ReadLine(), out stockIn))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            else
            {
                break;
            }
        }

        int stockOut;
        while (true)
        {
            Console.WriteLine("Enter Stock Out:");
            if (!int.TryParse(Console.ReadLine(), out stockOut))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            else
            {
                break;
            }
        }
        Item newItem = new Item(newItemName, branch, beginningInventory, stockIn, stockOut, 0);
        Console.WriteLine(newItem.ToString());
    }
}