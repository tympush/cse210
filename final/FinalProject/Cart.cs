public class Cart
{
    private List<Item> _cart = new List<Item>();



    public void DisplayCart()
    {

    }

    public void AddToCart(Item item)
    {
        _cart.Add(item);
    }

    public List<Item> GetCart()
    {
        return _cart;
    }

    public void EmptyCart()
    {
        _cart.Clear();
    }
}