using Day13Concepts.CustomTypeDictionary;
using Day13Concepts.GenericQueue;
using Day13Concepts.GenericStack;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Day13Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary();
            //CustomTypeDictionary();
            SortedListAndDictionary();
            //GenericStack();
            //GenericQueue();
        }

        public static void Dictionary()
        {
            List<string> lstWeeks = new List<string>();
            lstWeeks.Add("Sunday");
            lstWeeks.Add("Monday");
            lstWeeks.Add("Tuesday");
            lstWeeks.Add("Wednesday");
            lstWeeks.Add("Thursday");
            lstWeeks.Add("Friday");
            lstWeeks.Add("Saturday");

            var march = lstWeeks[2];
            var april = lstWeeks[3];

            var Weeks = new Dictionary<int, string>
            {
                {1, "Sunday" },
                {2, "Monday" },
                {3, "Tuesday"},
                {4, "Wednesday" }

            };

            Weeks[5] = "Thursday";
            Weeks[6] = "Friday";

            Weeks.Add(7, "Saturday");

            Console.ReadKey();
        }

        public static void CustomTypeDictionary()
        {
            var ambassadors = new Dictionary<CountryCode, Ambassador>();

            Ambassador england = new Ambassador
            {
                CountryCode = new CountryCode("eng"),
                Name = "John",
                Age = 35
            };

            Ambassador australia = new Ambassador
            {
                CountryCode = new CountryCode("aus"),
                Name = "Mark",
                Age = 45
            };

            ambassadors.Add(england.CountryCode, england);
            ambassadors.Add(australia.CountryCode, australia);

            Console.WriteLine("Enter country code: ");
            var code = Console.ReadLine();

            if(ambassadors.TryGetValue(new CountryCode(code), out Ambassador ambassador))
            {
                Console.WriteLine($"The ambassador is {ambassador.Name}");
            }
            else
            {
                Console.WriteLine("The ambassador with in the given code does not exist i");
            }
            Console.ReadKey();
        }
        public static void SortedListAndDictionary()
        {
            var fileInfo = new SortedList<string, string>();
            fileInfo.Add("txt", "notepad.exe");
            fileInfo.Add("doc", "wordpad.exe");

            foreach (var kvp in fileInfo)
            {
                Console.WriteLine($"Key: {kvp.Key}, value: {kvp.Value}");
            }

            Console.WriteLine("Press any key to add another file extention..");
            Console.ReadLine();

            fileInfo.Add("bmp", "paint.exe");

            Console.WriteLine("Updated file info list: ");

            foreach (var kvp in fileInfo)
            {
                Console.WriteLine($"Key: {kvp.Key}, value: {kvp.Value}");
            }

            Console.ReadKey();
        }

        static ShoppingCart Shopping;
        public static void GenericStack()
        {
            int option = 0;

            Shopping = new ShoppingCart();

            while (option != 5)
            {
                Console.WriteLine("\n\t\tMenu - selet an option");
                Console.WriteLine("\t\t----------------------");
                Console.WriteLine("\t\t1. Add an item to shopping cart");
                Console.WriteLine("\t\t2. undo");
                Console.WriteLine("\t\t3. Redo");
                Console.WriteLine("\t\t4. ViewCart");
                Console.WriteLine("\t\t5. Exit");
                Console.Write("Option : ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.Write("Enter item name(type 'n' to stop): ");
                            var itemName = Console.ReadLine();

                            if (itemName != "n")
                                Shopping.Add(itemName);

                            repeat = itemName == "n" ? false : true;
                        }

                        ShowCartItems();
                        break;

                    case 2:
                        Shopping.Undo();
                        ShowCartItems();
                        break;

                    case 3:
                        Shopping.Redo();
                        ShowCartItems();
                        break;

                    case 4:
                        ShowCartItems();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Option !");
                        break;
                }
            }

            Console.ReadKey();
        }
        public static void ShowCartItems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tCart Items");
            Console.WriteLine("\t------");
            Shopping.ViewCart();
            Console.WriteLine("\t-------");

        }

        public static void GenericQueue()
        {
            MovieTicketBookingSystem BookingSystem = new MovieTicketBookingSystem();
            BookingSystem.AddToQueue(new Customer { Name = "Joy", Age = 17 });
            BookingSystem.AddToQueue(new Customer { Name = "Roy", Age = 37 });
            BookingSystem.AddToQueue(new Customer { Name = "som", Age = 27 });

            Console.ReadKey();
            BookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nBooking process started...");
            BookingSystem.ProcessBooking();
            BookingSystem.ProcessBooking();

            Console.ReadKey();
            BookingSystem.ShowQueue();

            Console.ReadKey();
            BookingSystem.AddToQueue(new Customer { Name = "Jully", Age = 67 });
            BookingSystem.AddToQueue(new Customer { Name = "Ramond", Age = 57 });

            Console.ReadKey();
            BookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nBooking process started...");
            BookingSystem.ProcessBooking();
            BookingSystem.ProcessBooking();

            Console.ReadKey();
            BookingSystem.ShowQueue();

            Console.ReadLine();
        }
    }
}
