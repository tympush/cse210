using System.Drawing;

public abstract class Item
{
    protected string _shapeName;
    protected float _totalPrice;
    List<Option> _options;



    public Item()
    {
        _options = new List<Option>();
    }



    public abstract float CalculateVolume();

    public abstract float CalculateBase();

    public void AddOption(Option option)
    {
        _options.Add(option);
    }

    public void CalculateTotalPrice()
    {

    }

    public abstract string GetStringRepresentation();
}