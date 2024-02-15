public class TextOption : Option
{
    private string _text;



    public TextOption(string name, float cost) : base(name, cost)
    {

    }


    public override float GetCost()
    {
        return _cost * _text.Length;
    }

    public void SetText(string text)
    {
        _text = text;
    }
}