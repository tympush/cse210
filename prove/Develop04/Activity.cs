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

        int tempDuration;

        if (int.TryParse(durationInput, out tempDuration))
        {
            _duration = tempDuration;
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
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        Console.Write($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        int i = 0;
        List<string> animationStrings = new List<string>(){"|","/","-","\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int second)
    {
        for (int j = second; j > 0; j--)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}