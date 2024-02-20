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
        return 2f / 3f * (float)Math.PI * _radius * _radius * _radius;
    }

    public override float CalculateBase()
    {
        return (float)Math.PI * _radius * _radius;
    }

    public override string GetStringRepresentation()
    {
        string optionsString = "";

        foreach(Option option in GetOptions())
        {
            optionsString += $" {option.GetStringRepresentation()} |";
        }

        return $"{_shapeName} | radius: {_radius:F2}cm |{optionsString} price: ${CalculateTotalPrice():F2}";
    }
}