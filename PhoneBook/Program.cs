using System;

namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("CONSOLE PHONEBOOK");
            Console.WriteLine();
            Console.WriteLine("Select operation:");
            Console.WriteLine("Press 1 to Add contact");
            Console.WriteLine("Press 2 to Display contact by number");
            Console.WriteLine("Press 3 to Search contact by name");
            Console.WriteLine("Press 4 to View all contact");
            Console.WriteLine("Press x to Close application");
            Console.WriteLine();

            var userInput = Console.ReadLine();
            var phoneBook = new Phonebook();

            while (true) //the app will run forever until user wants to exit
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Write contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Write contact number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Enter a number to search:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContactByNumber(searchNumber);
                        break;

                    case "3":
                        Console.WriteLine("Enter a name to search:");
                        var searchName = Console.ReadLine();
                        phoneBook.DisplayContactByName(searchName);
                        break;

                    case "4":
                        phoneBook.DisplayAllContacts();
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Please choose a valid operation");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Select operation:");
                userInput = Console.ReadLine();
                //will prevent user to stuck on the first selected case forever
            }
        }
    }
}