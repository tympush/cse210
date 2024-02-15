public class ResinOption : Option
{
    private float _volume;



    public ResinOption(string name, float cost) : base(name, cost)
    {

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