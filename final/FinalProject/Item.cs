using System.Drawing;

public abstract class Item
{
    protected string _shapeName;
    protected float _volume;
    protected float _base;
    protected float _totalPrice;
    List<Option> _options;



    public Item()
    {
        _options = new List<Option>();
    }



    public abstract void CalculateVolume();

    public abstract void CalculateBase();

    public void CalculateTotalPrice()
    {

    }
}