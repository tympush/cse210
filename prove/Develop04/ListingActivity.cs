public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;


    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 30;

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }


    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.Write($"List as many responses as you can to the following prompt:\n --- {GetRandomPrompt()} ---\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> responses = new List<string>(GetListFromUser());
        _count = responses.Count();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(0, _prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        string userInput;
        List<string> userInputs = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userInput = Console.ReadLine();
            userInputs.Add(userInput);
        }
        return userInputs;
    }
}