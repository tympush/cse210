using System;
using Newtonsoft.Json;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    string fileName;
    PromptGenerator userGenerator = new PromptGenerator();

    public void AddEntry()
    {
        Entry userEntry = new Entry();

        userEntry._prompt = userGenerator.ChooseRandom();
        Console.Write($"{userEntry._prompt}\n> ");

        userEntry._answer  = Console.ReadLine();

        userEntry._date = DateTime.Now.ToString("yyyy-MM-dd");

        _entries.Add(userEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}\n{entry._answer}\n");
        }
    }

    public void SaveFile()
    {
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine() + ".json";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string json = JsonConvert.SerializeObject(_entries, Formatting.Indented);
            outputFile.Write(json);
        }
    }

    public void LoadFile()
    {
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine() + ".json";

        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        string json = File.ReadAllText(fileName);
        _entries = JsonConvert.DeserializeObject<List<Entry>>(json);
    }
}