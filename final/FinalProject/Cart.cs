public class Cart
{
    private List<Item> _cart = new List<Item>();



    public void DisplayCart()
    {
        Console.Clear();
        Console.WriteLine("Your Cart:");

        int counter = 1;

        foreach (Item item in _cart)
        {
            Console.WriteLine($"   {counter}. {item.GetStringRepresentation()}");
            counter ++;
        }

        Console.Write("Press enter to return to the main menu: ");
        Console.ReadLine();
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