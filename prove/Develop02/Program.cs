using System;

class Program {
    private static Journal journal = new Journal();

    private static string[] prompts = {
        "What have you done today?",
        "What is your routine in this weekday?",
        "What did you like about your day until now?",
        "Are you working in any projects?",
        "What have you eaten today?",
	    "Who have you seen and spoken to today? What did you talk about",
	    "How is your day going?"
    };

    private static void WriteNewEntry() {
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry entry = new Entry(prompt, response, date);
        journal.AddEntry(entry);
    }

    private static void DisplayJournal() {
        journal.DisplayEntries();
    }

    private static void SaveJournal() {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);
    }

    private static void LoadJournal() {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
    }

    private static void ShowMenu() {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }

    static void Main(string[] args) {
        bool running = true;
        while (running) {
            ShowMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}