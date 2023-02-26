using System;

namespace PhonebookConsole
{
    class Program
    {
    static void Main (string[]args)
     {
        Console.WriteLine("Hello world!");
        Console.WriteLine("Select Operation");
        Console.WriteLine("1 : Add Contact");
        Console.WriteLine("2 : Display Contact by number");
        Console.WriteLine("2 : View all Contacts");
        Console.WriteLine("2 : Search for contacts by given name");

        var userInput = Console.ReadLine();
        var Phonebook= new Phonebook();

        switch (userInput)
        {
            case "1":
            Console.WriteLine("contact name :");
            var name= Console.ReadLine();
            Console.WriteLine("contact number:");
            var number= Console.ReadLine();

            var newContact = new contact (name,number);
            Phonebook.AddContact(newContact);

                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            default:
            Console.WriteLine("Select Valid Operation");
                break;
        }




    }

    }
}