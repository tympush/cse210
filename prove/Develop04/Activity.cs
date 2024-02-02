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


    protected void DisplayStartingMessage(bool timerPerQuestion)
    {
        Console.Clear();

        if (timerPerQuestion)
        {
            Console.Write($"Welcome to the {_name}.\n\n{_description}\n\nHow long, in seconds, would you like for each question? ");
        }
        else
        {
            Console.Write($"Welcome to the {_name}.\n\n{_description}\n\nHow long, in seconds, would you like for your session? ");
        }

        string durationInput = Console.ReadLine();

        int tempDuration;

        if (int.TryParse(durationInput, out tempDuration))
        {
            _duration = tempDuration;

            if (timerPerQuestion)
            {
                Console.WriteLine($"Question duration set to: {_duration} seconds");
            }
            else
            {
                Console.WriteLine($"Session duration set to: {_duration} seconds");
            }
        }
        else
        {
            if (timerPerQuestion)
            {
                Console.WriteLine($"Invalid input. Question duration set to: {_duration} seconds");
            }
            else
            {
                Console.WriteLine($"Invalid input. Session duration set to: {_duration} seconds");
            }
        }

        Console.WriteLine("Press enter to start.");
        Console.ReadLine();
    }

    protected void DisplayEndingMessage(bool timerPerQuestion)
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        if (timerPerQuestion)
        {
            Console.WriteLine($"\nYou have completed another {_duration * 10} seconds of the {_name}.");
        }
        else
        {
            Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        }
        ShowSpinner(5);
    }

    protected void ShowSpinner(int seconds)
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

    protected void ShowCountDown(int second)
    {
        for (int j = second; j > 0; j--)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}