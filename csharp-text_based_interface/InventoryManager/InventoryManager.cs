using System;
using System.Collections.Generic;
using InventoryLibrary;

    class Program
    {
        private static JSONStorage _storage = new JSONStorage();

        static void Main(string[] args)
        {
            
            LoadObjects();
            ShowInitialPrompt();

            string input;
            do
            {
                Console.Write("> ");
                input = Console.ReadLine()?.ToLower().Trim();
                HandleInput(input);
            } while (input != "exit");
        }

        private static void LoadObjects()
        {
            _storage.Load();
        }

        private static void ShowInitialPrompt()
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> create a new object");
            Console.WriteLine("<Show [ClassName object_id]> show an object");
            Console.WriteLine("<Update [ClassName object_id]> update an object");
            Console.WriteLine("<Delete [ClassName object_id]> delete an object");
            Console.WriteLine("<Exit> exit the application");
        }

        private static void HandleInput(string input)
        {
            var parts = input.Split(' ');
            var command = parts[0];

            switch (command)
            {
                case "classnames":
                    ShowClassNames();
                    break;
                case "all":
                    if (parts.Length == 1)
                    {
                        ShowAllObjects();
                    }
                    else if (parts.Length == 2)
                    {
                        ShowAllObjectsOfClass(parts[1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command syntax.");
                    }
                    break;
                case "create":
                    if (parts.Length == 2)
                    {
                        CreateObject(parts[1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command syntax.");
                    }
                    break;
                case "show":
                    if (parts.Length == 3)
                    {
                        ShowObject(parts[1], parts[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command syntax.");
                    }
                    break;
                case "update":
                    if (parts.Length == 3)
                    {
                        UpdateObject(parts[1], parts[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command syntax.");
                    }
                    break;
                case "delete":
                    if (parts.Length == 3)
                    {
                        DeleteObject(parts[1], parts[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command syntax.");
                    }
                    break;
                case "exit":
                    Console.WriteLine("Exiting...");
                    _storage.Save();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

        private static void ShowClassNames()
        {
            Console.WriteLine("Available Class Names:");
            Console.WriteLine("- User");
            Console.WriteLine("- Item");
            Console.WriteLine("- Inventory");
        }

        private static void ShowAllObjects()
        {
            var objects = _storage.All();
            foreach (var kvp in objects)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        private static void ShowAllObjectsOfClass(string className)
        {
            var objects = _storage.All();
            foreach (var kvp in objects)
            {
                if (kvp.Key.StartsWith(className.ToLower()))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }

        private static void CreateObject(string className)
        {
            switch (className.ToLower())
            {
                case "user":
                    Console.Write("Enter user name: ");
                    var userName = Console.ReadLine();
                    var user = new User(userName);
                    _storage.New(user);
                    break;
                case "item":
                    Console.Write("Enter item name: ");
                    var itemName = Console.ReadLine();
                    Console.Write("Enter item description: ");
                    var itemDescription = Console.ReadLine();
                    Console.Write("Enter item price: ");
                    if (float.TryParse(Console.ReadLine(), out float itemPrice))
                    {
                        var item = new Item(itemName)
                        {
                            description = itemDescription,
                            Price = itemPrice,
                            tags = new List<string>()
                        };
                        _storage.New(item);
                    }
                    else
                    {
                        Console.WriteLine("Invalid price.");
                    }
                    break;
                case "inventory":
                    Console.Write("Enter user id: ");
                    var userId = Console.ReadLine();
                    Console.Write("Enter item id: ");
                    var itemId = Console.ReadLine();
                    Console.Write("Enter quantity: ");
                    if (int.TryParse(Console.ReadLine(), out int quantity))
                    {
                        var inventory = new Inventory(userId, itemId, quantity);
                        _storage.New(inventory);
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity.");
                    }
                    break;
                default:
                    Console.WriteLine($"{className} is not a valid object type.");
                    break;
            }
        }

        private static void ShowObject(string className, string id)
        {
            var key = $"{className.ToLower()}.{id}";
            if (_storage.All().TryGetValue(key, out var obj))
            {
                Console.WriteLine(obj);
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found.");
            }
        }

        private static void UpdateObject(string className, string id)
        {
            var key = $"{className.ToLower()}.{id}";
            if (_storage.All().TryGetValue(key, out var obj))
            {
                foreach (var prop in obj.GetType().GetProperties())
                {
                    Console.Write($"Enter new value for {prop.Name} (current value: {prop.GetValue(obj)}): ");
                    var newValue = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newValue))
                    {
                        prop.SetValue(obj, Convert.ChangeType(newValue, prop.PropertyType));
                    }
                }
                _storage.New(obj); // Re-add the object to save changes
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found.");
            }
        }

        private static void DeleteObject(string className, string id)
        {
            var key = $"{className.ToLower()}.{id}";
            if (_storage.All().Remove(key))
            {
                Console.WriteLine($"Object {id} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found.");
            }
        }
    }



