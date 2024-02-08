using System.Data;
using System.IO; 

public class GoalManager
{
    private List<Goal> _goalList;
    private int _score;



    public GoalManager()
    {
        _goalList = new List<Goal>();
        _score = 0;
    }



    public void Start()
    {
        string menuInput;

        do
        {
            Console.Write("Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect a choice from the menu: ");
            menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                CreateGoal();
            }

            if (menuInput == "2")
            {
                ListGoalDetails();
            }

            if (menuInput == "3")
            {
                SaveGoals();
            }

            if (menuInput == "4")
            {
                LoadGoals();
            }

            if (menuInput == "5")
            {
                RecordEvent();
            }

            DisplayPlayerInfo();

        }while (menuInput != "6");
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    private void ListGoalNames() 
    {
        int index = 1;
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine($"   {index}. {goal.GetName()}");
            index++;
        }
    }

    private void ListGoalDetails() 
    {
        Console.WriteLine();

        foreach (Goal goal in _goalList)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal() 
    {
        Console.Write("The types of Goals are:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\nWhich type of goal would you like to create? ");
        string cgInput = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string cgName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string cgDescription = Console.ReadLine();

        int cgPoints = AskStringToIntQuestion("What is the ammount of points associated with this goal? ");

        if (cgInput == "1")
        {
            _goalList.Add(new SimpleGoal(cgName, cgDescription, cgPoints));
        }

        if (cgInput == "2")
        {
            _goalList.Add(new EternalGoal(cgName, cgDescription, cgPoints));
        }

        if (cgInput == "3")
        {
            int cgTarget = AskStringToIntQuestion("How many times does this goal need to be acomplished for a bonus? ");
            int cgBonus = AskStringToIntQuestion("What is the bonus for accomplishing it that many times? ");

            _goalList.Add(new ChecklistGoal(cgName, cgDescription, cgPoints, cgTarget, cgBonus));
        }
    }

    private void RecordEvent() 
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();

        int recordInput = AskStringToIntQuestion("Which goal did you accomplish? ");

        _score += _goalList[recordInput - 1].RecordEvent();
    }

    private void SaveGoals() 
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals() 
    {
        _goalList.Clear();

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("ƐӜЗ");

            if (parts.Length == 1)
            {
                _score = Convert.ToInt32(parts[0]);
            }
            else if (parts.Length == 4)
            {
                _goalList.Add(new SimpleGoal(parts[0], parts[1], Convert.ToInt32(parts[2]), Convert.ToBoolean(parts[3])));
            }
            else if (parts.Length == 3)
            {
                _goalList.Add(new EternalGoal(parts[0], parts[1], Convert.ToInt32(parts[2])));
            }
            else if (parts.Length == 6)
            {
                _goalList.Add(new ChecklistGoal(parts[0], parts[1], Convert.ToInt32(parts[2]), Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5])));
            }
        }
    }

    private int AskStringToIntQuestion(string question)
    {
        int inputInt = 0;

        do
        {
            Console.Write(question);
            string inputString = Console.ReadLine();

            if (int.TryParse(inputString, out inputInt))
            {
                if (inputInt <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        }while (inputInt <= 0);

        return inputInt;
    }
}