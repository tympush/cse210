public class HalfSphereItem : Item
{
    private float _radius;



    public HalfSphereItem(float radius)
    {
        _shapeName = "half-sphere";

        _radius = radius;
    }



    public override void CalculateVolume()
    {
        _volume = 4 / 3 * (float)Math.PI * _radius * _radius * _radius;
    }

    public override void CalculateBase()
    {
        _base = (float)Math.PI * _radius * _radius;
    }
}