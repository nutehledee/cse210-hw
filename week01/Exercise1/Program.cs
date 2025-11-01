using System;

class Program
{
    static void Main()
    {
        // 1. Ask for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // 2. Ask for last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // 3. Print the required sentence
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}