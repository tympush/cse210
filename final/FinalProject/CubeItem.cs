using System.Reflection.Metadata.Ecma335;

public class CubeItem : Item
{
    private float _side;



    public CubeItem(float side)
    {
        _shapeName = "cube";

        _side = side;
    }



    public override void CalculateVolume()
    {
        _volume = _side * _side * _side;
    }

    public override void CalculateBase()
    {
        _base = _side * _side;
    }
}