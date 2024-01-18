using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;

        Journal userJournal = new Journal();


        do{

            Console.Write("Please select one of the following actions:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            response = Console.ReadLine();

            if (response == "1"){
                userJournal.AddEntry();
            }

            if (response == "2"){
                userJournal.DisplayEntries();
            }

            if (response == "3"){
                userJournal.LoadFile();
            }

            if (response == "4"){
                userJournal.SaveFile();
            }


        }while (response != "5");
    }
}