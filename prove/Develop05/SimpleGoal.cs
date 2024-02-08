public class SimpleGoal : Goal
{
    private bool _isComplete;



    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }



    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string completeSymbol;
        if (IsComplete() == true)
        {
            completeSymbol = "X";
        }
        else
        {
            completeSymbol = " ";
        }

        return $"[{completeSymbol}] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}ƐӜЗ{_description}ƐӜЗ{_points}ƐӜЗ{_isComplete}";
    }
}