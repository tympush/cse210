using System;

class Journal
{
    public List<Entry> _entries = new List<Entry>();


    string fileName;
    PromptGenerator userGenerator = new PromptGenerator();

    public void AddEntry(){
        Entry userEntry = new Entry();

        userEntry._prompt = userGenerator.ChooseRandom();
        Console.Write($"{userEntry._prompt}\n> ");

        userEntry._answer  = Console.ReadLine();

        userEntry._date = DateTime.Now.ToString("yyyy-MM-dd");

        _entries.Add(userEntry);
    }

    public void DisplayEntries(){

        foreach (Entry entry in _entries){
                
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}\n{entry._answer}\n");
        }
    }

    public void SaveFile(){

        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date} - {entry._prompt} - {entry._answer}");
            }
        }
    }

    public void LoadFile(){

        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}