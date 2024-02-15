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
        return 1;
    }

    public override float CalculateBase()
    {
        return 1;
    }
}