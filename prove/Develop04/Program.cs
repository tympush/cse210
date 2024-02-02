/*
Showing Creativity and Exceeding Requirements:

> added a 4th activity that helps you to reflect on your current day
(it asks for time per question, the start and end message methods now take a boolean that adjusts the text)

> other minor adjustments
    - added a confirmation message about the time set for each activity that also defaults to a certain time on incorrect input
    - changed some of the pause times
    - changed spinner to timer in reflection activity
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
        DayActivity day = new DayActivity();

        string menuInput;

        do
        {
            Console.Clear();
            Console.Write("Menu Options:\n   1. Start Breathing Activity\n   2. Start Reflecting Activity\n   3. Start Listening Activity\n   4. Start Day Activity\n   5. Quit\nSelect a choice from the menu: ");
            menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                breathing.Run();
            }

            if (menuInput == "2")
            {
                reflecting.Run();
            }

            if (menuInput == "3")
            {
                listing.Run();
            }

            if (menuInput == "4")
            {
                day.Run();
            }

        }while (menuInput != "5");
    }
}