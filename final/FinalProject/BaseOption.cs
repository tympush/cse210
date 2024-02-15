public class BaseOption : Option
{
    private float _area;



    public BaseOption(string name, float cost, float area) : base(name, cost)
    {
        _area = area;
    }


    public override float GetCost()
    {
        return _cost * _area;
    }

    public void SetArea(float area)
    {
        _area = area;
    }
}