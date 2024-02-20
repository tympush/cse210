public class CubeItem : Item
{
    private float _side;



    public CubeItem(float side)
    {
        _shapeName = "Cube";

        _side = side;
    }



    public override float CalculateVolume()
    {
        return _side * _side * _side;
    }

    public override float CalculateBase()
    {
        return _side * _side;
    }

    public override string GetStringRepresentation()
    {
        string optionsString = "";

        foreach(Option option in GetOptions())
        {
            optionsString += $" {option.GetStringRepresentation()} |";
        }

        return $"{_shapeName} | side: {_side:F2}cm |{optionsString} price: ${CalculateTotalPrice():F2}";
    }
}