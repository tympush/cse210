public class CuboidItem : Item
{
    private float _lenght;
    private float _width;
    private float _height;



    public CuboidItem(float lenght, float width, float height)
    {
        _shapeName = "cuboid";

        _lenght = lenght;
        _width = width;
        _height = height;
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