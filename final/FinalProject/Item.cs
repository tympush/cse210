public abstract class Item
{
    protected string _shapeName;
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

    public float CalculateTotalPrice()
    {
        float _totalPrice = 0;

        foreach (Option option in _options)
        {
            _totalPrice += option.GetCost();
        }

        return _totalPrice;
    }

    protected List<Option> GetOptions()
    {
        return _options;
    }

    public abstract string GetStringRepresentation();
}