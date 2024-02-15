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
        return 1;
    }

    public override float CalculateBase()
    {
        return 1;
    }
}