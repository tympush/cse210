using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //makes sure decimal numbers use . and not ,
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Menu menu = new Menu();
        menu.Start();
    }
}