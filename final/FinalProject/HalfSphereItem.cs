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
        return 1;
    }

    public override float CalculateBase()
    {
        return 1;
    }
}