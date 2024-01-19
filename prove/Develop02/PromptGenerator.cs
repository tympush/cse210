using System;

public class PromptGenerator
{
    public List<string> _promptsList = new List<string> 
    {
        "What was the most interesting interaction I had with someone today?",
        "What was the most enjoyable part of my day?",
        "What was the strongest emotion I felt today?",
        "What was my most memorable experience for the day?",
        "What blessings have I seen today?",
        "How have I felt the spirit today?",
        "If there was one thing I would change today, what would it be?",
        "What did I dedicate the most time to today?"
    };

    public string ChooseRandom()
    {
        return _promptsList[new Random().Next(0, _promptsList.Count)];
    }
}