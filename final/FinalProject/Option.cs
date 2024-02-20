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

    //same as GetName() in many cases. But overwritten in some classes, which need GetName() to stay the same.
    public virtual string GetStringRepresentation()
    {
        return _name;
    }

    public virtual float GetCost()
    {
        return _cost;
    }
}