public class DodecahedronItem : Item
{
    private float _side;



    public DodecahedronItem(float side)
    {
        _shapeName = "dodecahedron";

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