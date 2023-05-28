using System;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the scripture reference:");
        string reference = Console.ReadLine();

        Console.WriteLine("Enter the scripture text:");
        string text = Console.ReadLine();

        Scripture scripture = new Scripture(reference, text);

        while (scripture.HasHiddenWords())
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
        }

        Console.WriteLine("Program ended. Press any key to exit.");
        Console.ReadKey();
    }
}




