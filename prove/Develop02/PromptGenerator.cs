using System;

public class PromptGenerator{

    public List<string> _promptsList = new List<string> 
    {
        "ein",
        "twai",
        "drai"
    };


    public string ChooseRandom(){
        return _promptsList[new Random().Next(0, _promptsList.Count)];
    }
}