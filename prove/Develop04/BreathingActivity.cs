public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 30;
    }


    public void Run()
    {
        DisplayStartingMessage(false);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(3);
            Console.Write("\nNow breathe out...");
            ShowCountDown(5);
        }

        Console.WriteLine();
        DisplayEndingMessage(false);
    }
}