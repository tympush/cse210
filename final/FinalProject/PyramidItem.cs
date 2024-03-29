public class PyramidItem : Item
{
    private float _baseSide;
    private float _height;



    public PyramidItem(float baseSide, float height)
    {
        _shapeName = "Pyramid";

        _baseSide = baseSide;
        _height = height;
    }



    public override float CalculateVolume()
    {
        return _baseSide * _baseSide * _height / 3;
    }

    public override float CalculateBase()
    {
        return _baseSide * _baseSide;
    }

    public override string GetStringRepresentation()
    {
        string optionsString = "";

        foreach(Option option in GetOptions())
        {
            optionsString += $" {option.GetStringRepresentation()} |";
        }

        return $"{_shapeName} | base side: {_baseSide:F2}cm | height: {_height:F2}cm |{optionsString} price: ${CalculateTotalPrice():F2}";
    }
}