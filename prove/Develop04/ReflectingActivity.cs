public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;


    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 30;

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }


    public void Run()
    {
        DisplayStartingMessage(false);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.Clear();
        DisplayPrompt(GetRandomPrompt());

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions(GetRandomQuestion());
            ShowCountDown(7);
            Console.WriteLine();
        }

        DisplayEndingMessage(false);
    }

    private string GetRandomPrompt()
    {
        return _prompts[new Random().Next(0, _prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[new Random().Next(0, _questions.Count)];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Consider the following prompt:\n\n --- {prompt} ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayQuestions(string question)
    {
        Console.Write($"> {question} ");
    }
}