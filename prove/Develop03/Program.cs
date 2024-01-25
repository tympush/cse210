using System;
using System.Runtime.Remoting;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbes",3,5,6);
        Scripture scripture = new Scripture(reference,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        string userInput;
        bool completelyHidden;
        int difficulty;

        Console.Write("How many words would you like to hide each time? ");
        string difficultyInput = Console.ReadLine();

        if (int.TryParse(difficultyInput, out difficulty))
        {
            Console.WriteLine($"Difficulty level set to: {difficulty}");
        }
        else
        {
            Console.WriteLine("Invalid input. Difficulty level set to: 3");
            difficulty = 3;
        }

        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();

        do
        {
            Console.Clear();
            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            completelyHidden = scripture.IsCompletelyHidden();

            scripture.HideRandomWords(difficulty);

        }while (userInput != "quit" && !completelyHidden);
    }
}