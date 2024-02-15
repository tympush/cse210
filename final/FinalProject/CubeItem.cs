using System.Reflection.Metadata.Ecma335;

public class CubeItem : Item
{
    private float _side;



    public CubeItem(float side)
    {
        _shapeName = "cube";

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
        return "";
    }
}