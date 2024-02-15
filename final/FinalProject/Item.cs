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
        _options = new List<Option>()
        {
            new ResinOption("Resin", 0.08f),
            
            new ColorOption("Color1", 1.25f),
            new ColorOption("Color2", 1.25f),
            new ColorOption("Color3", 1.25f),

            new Option("Insect", 4.5f),
            new Option("Fish", 3.5f),
            new Option("Rock", 2f),
            new Option("Flower", 1.75f),

            new Option("Glitter", 0.75f),
            new Option("Stars", 1.25f),
            new Option("Foil", 1f),

            new BaseOption("WoodBase", 0.07f),
            new BaseOption("MetalBase", 0.2f),

            new TextOption("WoodText", 0.2f),
            new TextOption("MetalText", 0.5f)
        };
    }



    public abstract void CalculateVolume();

    public abstract void CalculateBase();

    public void CalculateTotalPrice()
    {

    }
}