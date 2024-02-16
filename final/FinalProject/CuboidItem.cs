public class CuboidItem : Item
{
    private float _length;
    private float _width;
    private float _height;



    public CuboidItem(float length, float width, float height)
    {
        _shapeName = "Cuboid";

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
        return $"{_shapeName} | length: {_length:F2}cm | width: {_width:F2}cm | height: {_height:F2}cm | price: ${CalculateTotalPrice():F2}";
    }
}