public class ResinOption : Option
{
    private float _volume;



    public ResinOption(string name, float cost, float volume) : base(name, cost)
    {
        _volume = volume;
    }


    public override float GetCost()
    {
        return _cost * _volume;
    }

    public void SetVolume(float volume)
    {
        _volume = volume;
    }
}