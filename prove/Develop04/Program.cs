using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        string menuInput;

        do
        {
            Console.Clear();
            Console.Write("Menu Options:\n   1. Start Breathing Activity\n   2. Start Reflecting Activity\n   3. Start Listening Activity\n   4. Quit\nSelect a choice from the menu: ");
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

        }while (menuInput != "4");
    }
}