public class Option
{
    protected bool _selected;
    protected string _name;
    protected float _cost;



    public Option(string name, float cost)
    {
        _selected = false;
        _name = name;
        _cost = cost;
    }



    public void Select()
    {
        _selected = true;
    }

    public virtual float GetCost()
    {
        return _cost;
    }
}