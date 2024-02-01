public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity()
    {
        _name = "Default Activity";
        _description = "Default description.";
        _duration = 0;
    }


    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.Write($"Welcome to the {_name}.\n\n{_description}\n\nHow long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();

        if (int.TryParse(durationInput, out _duration))
        {
            Console.WriteLine($"Session duration set to: {_duration} seconds");
        }
        else
        {
            Console.WriteLine($"Invalid input. Session duration set to: {_duration} seconds");
        }

        Console.WriteLine("Press enter to start.");
        Console.ReadLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int second)
    {

    }
}