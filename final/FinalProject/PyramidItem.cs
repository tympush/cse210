public class PyramidItem : Item
{
    private float _baseSide;
    private float _height;



    public PyramidItem(float baseSide, float height)
    {
        _shapeName = "pyramid";

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
        return "";
    }
}