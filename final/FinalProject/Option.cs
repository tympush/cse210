public class Option
{
    protected string _name;
    protected float _cost;



    public Option(string name, float cost)
    {
        _name = name;
        _cost = cost;
    }



    public string GetName()
    {
        return _name;
    }

    public virtual float GetCost()
    {
        return _cost;
    }
}