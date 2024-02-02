public class DayActivity : Activity
{
    private List<string> dayParts;


    public DayActivity()
    {
        _name = "Day Activity";
        _description = "This Activity will help you reflect on your current day by asking you what you have done and felt during different parts of your day.";
        _duration = 5;

        dayParts = new List<string>{"Morning", "Lunch", "Afternoon", "Evening", "Night"};
    }


    public void Run()
    {
        DisplayStartingMessage(true);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        foreach (string part in dayParts)
        {
            Console.Write($"\n\nDuring your {part}:\n> What have you done? ");
            ShowCountDown(_duration);
            Console.Write("\n> What emotion have you felt? ");
            ShowCountDown(_duration);
        }

        Console.WriteLine();
        DisplayEndingMessage(true);
    }
}