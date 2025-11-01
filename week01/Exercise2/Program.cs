using System;

class Program
{
    static void Main()
    {
        // Ask user for grade
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        // Determine letter grade
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine + or -
        string sign = "";
        if (letter != "F")
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // No A+
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // Pass/fail message
        string message;
        if (grade >= 70)
        {
            message = "Congratulations! You passed the course!";
        }
        else
        {
            message = "Keep trying! You'll get it next time.";
        }

        // Final output
        Console.WriteLine($"Your grade is: {letter}{sign}");
        Console.WriteLine(message);
    }
}