public class HalfSphereItem : Item
{
    private float _radius;



    public HalfSphereItem(float radius)
    {
        _shapeName = "Half-Sphere";

        _radius = radius;
    }



    public override float CalculateVolume()
    {
        return 2 / 3 * (float)Math.PI * _radius * _radius * _radius;
    }

    public override float CalculateBase()
    {
        return (float)Math.PI * _radius * _radius;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shapeName} | radius: {_radius:F2}cm | price: ${CalculateTotalPrice():F2}";
    }
}