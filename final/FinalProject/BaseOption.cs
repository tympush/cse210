public class BaseOption : Option
{
    private float _area;



    public BaseOption(string name, float area, float cost) : base(name, cost)
    {
        _area = area;
    }


    public override float GetCost()
    {
        return _cost * _area;
    }
}