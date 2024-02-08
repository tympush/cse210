public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }



    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[E] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}ƐӜЗ{_description}ƐӜЗ{_points}";
    }
}