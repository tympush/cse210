public class ColorOption : Option
{
    private string _color;



    public ColorOption(string name, string color, float cost) : base(name, cost)
    {
        _color = color;
    }



    public override string GetStringRepresentation()
    {
        return $"{_name}: {_color}";
    }
}