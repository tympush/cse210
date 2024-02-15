public class HalfSphereItem : Item
{
    private float _radius;



    public HalfSphereItem(float radius)
    {
        _shapeName = "half-sphere";

        _radius = radius;
    }



    public override float CalculateVolume()
    {
        return 4 / 3 * (float)Math.PI * _radius * _radius * _radius;
    }

    public override float CalculateBase()
    {
        return (float)Math.PI * _radius * _radius;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}