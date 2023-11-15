using System.Net;

namespace discussion
{
    internal class Discussion
    {
        public static int totalBalance { get; private set; }

        static void Main(string[] args)
        {
            //[SECTION]] Objects, Instances, and Classes
            // A class is a blueprint for an object.
            // Objects and instances are block of memory that has been located and configured according to the blueprint.

            //Instantiating an object without initialization
            Item itemA = new Item();

            //reassigning values into itemA object.
            itemA.Name = "Pork";
            // Returns an error because branch field can only assigned a value during initialization
            itemA.Branch = "North";
            itemA.BeginningInventory = 100;
            itemA.StockIn = 10;
            itemA.StockOut = 5;
            itemA.TotalBalance = 105;

            Console.WriteLine(itemA.ToString());



            Item itemB = new Item
            {
                Name = "Pork",
                // Returns an error because branch field can only assigned a value during initialization
                Branch = "North",
                BeginningInventory = 100,
                StockIn = 10,
                StockOut = 5,
                TotalBalance = 105
            };

            Console.WriteLine(itemB.ToString());

            // Initializing and instanciating an object from the class.
            Item itemC = new Item("Beef", "South", 50, 10, 5, 55);
            Console.WriteLine(itemC.ToString());


            //Instantiating and Initializing Structures
            //User userA = new User("johndoe", "john@mail.com", "john1234", "123 Washington St. California 17462", "09123456789");
            //User userB = userA;
            //userB.display();


            //reassigning values into itemA object.
            itemA.Name = "Pork";


            //Activity
            int option;
            while (true)
            {
                Console.WriteLine("Choose an option: [1] Create Item, [2] Create User");
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option == 1 || option == 2)
                    {
                        break;
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

            if (option == 1)
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

                Item newItem = new Item(newItemName, branch, beginningInventory, stockIn, stockOut, totalBalance);
                Console.WriteLine(newItem.ToString());
            }

            else if (option == 2)
            {
                User userA = new User("johndoe", "john@mail.com", "john1234", "123 Washington St. California 17462", "09123456789");
                string newUsername;
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

                string email;
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

                string password;
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

                string address;
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

                string contact;
                while (true)
                {
                    Console.WriteLine("Enter contact number:");
                    contact = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(contact))
                    {
                        Console.WriteLine("Please enter a valid contact number.");
                    }
                    else
                    {
                        break;
                    }
                }

                User newUser = new User(newUsername, email, password, address, contact);
                Console.WriteLine(newUser.ToString());
            }


            // NOT SURE IF WRONG ANSWER
            //else if (option == 2)
            //{
            //    User userA = new User("johndoe", "john@mail.com", "john1234", "123 Washington St. California 17462", "09123456789");
            //    string newUsername = userA.Username; 
            //    if (!string.IsNullOrWhiteSpace(newUsername))
            //    {
            //        Console.WriteLine("Enter username:");
            //        string username = Console.ReadLine();
            //        if (username == userA.Username)
            //        {
            //            Console.WriteLine("Enter email:");
            //            string email = Console.ReadLine();
            //            if (email == userA.Email)
            //            {
            //                Console.WriteLine("Enter password:");
            //                string password = Console.ReadLine();
            //                if (password == userA.Password)
            //                {
            //                    Console.WriteLine("Enter address:");
            //                    string address = Console.ReadLine();
            //                    if (address == userA.Address)
            //                    {
            //                        Console.WriteLine("Enter contact:");
            //                        string contact = Console.ReadLine();
            //                        if (contact == userA.Contact)
            //                        {
            //                            Console.WriteLine("User created:");
            //                            Console.WriteLine($"Username: {newUsername}");
            //                            Console.WriteLine($"Email: {email}");
            //                            Console.WriteLine($"Password: {password}");
            //                            Console.WriteLine($"Address: {address}");
            //                            Console.WriteLine($"Contact: {contact}");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Invalid contact.");
            //                        }
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Invalid address.");
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid password.");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid email.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Username.");
            //        }

            //        Console.WriteLine(userA.ToString());
            //    }
        }
    }

    //[SECTION] Structures/Structs
    // Structures help to make a single variable hold related data of various data types.

    //Classes vs Structures
    // Classes are reference types (referencing to the same address in memory) and struct are value type (holds a copy of the entire object)
    // Struct do not support inheritance of fields and methods from other classes.
    // Structures cannot have an empty/default constructor.


    //struct User
    //    {
    //        public string username;
    //        public string email;
    //        public string password;
    //        public string address;
    //        public string contact;


    //        //param constructor
    //        public User(string username, string email, string password, string address, string contact)
    //        {
    //            this.username = username;
    //            this.email = email;
    //            this.password = password;
    //            this.address = address;
    //            this.contact = contact;
    //        }

    //        //action method
    //        public void display ()
    //        {
    //            Console.WriteLine($"username: {username}");
    //            Console.WriteLine($"email: {email}");
    //            Console.WriteLine($"password: {password}");
    //        }

        


        }
