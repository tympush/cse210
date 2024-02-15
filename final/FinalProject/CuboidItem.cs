public class CuboidItem : Item
{
    private float _length;
    private float _width;
    private float _height;



    public CuboidItem(float length, float width, float height)
    {
        _shapeName = "cuboid";

        _length = length;
        _width = width;
        _height = height;
    }



    public override float CalculateVolume()
    {
        return _length * _width * _height;
    }

    public override float CalculateBase()
    {
        return _length * _width;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}