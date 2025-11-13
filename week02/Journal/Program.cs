using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\n=== Journal Program ===");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("MM/dd/yyyy");
                    Entry newEntry = new Entry(prompt, response, date);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry saved!\n");
                    break;

                case "2":
                    Console.WriteLine("\n--- Your Journal Entries ---");
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename to save (e.g., myjournal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.Save(saveFile);
                    Console.WriteLine($"Journal saved to {saveFile}!\n");
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.Load(loadFile);
                    Console.WriteLine($"Journal loaded from {loadFile}!\n");
                    break;

                case "5":
                    Console.WriteLine("Goodbye! See you tomorrow.\n");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    break;
            }
        }
    }
}