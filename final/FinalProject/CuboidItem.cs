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



    public override void CalculateVolume()
    {
        _volume = _lenght * _width * _height;
    }

    public override void CalculateBase()
    {
        _base = _lenght * _width;
    }
}