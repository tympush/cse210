public class TextOption : Option
{
    private string _text;



    public TextOption(string name, string text, float cost) : base(name, cost)
    {
        _text = text;
    }


    public override float GetCost()
    {
        return _cost * _text.Length;
    }
}