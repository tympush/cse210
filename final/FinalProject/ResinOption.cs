public class ResinOption : Option
{
    private float _volume;



    public ResinOption(string name, float volume, float cost) : base(name, cost)
    {
        _volume = volume;
    }


    public override float GetCost()
    {
        return _cost * _volume;
    }
}