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



    public override void CalculateVolume()
    {
        _volume = _baseSide * _baseSide * _height / 3;
    }

    public override void CalculateBase()
    {
        _base = _baseSide * _baseSide;
    }
}