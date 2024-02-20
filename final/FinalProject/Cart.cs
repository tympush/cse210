public class Cart
{
    private List<Item> _cart = new List<Item>();



    public void DisplayCart()
    {
        float cartTotal = 0;

        Console.Clear();
        Console.WriteLine("Your Cart:");

        int counter = 1;

        foreach (Item item in _cart)
        {
            Console.WriteLine($"   {counter}. {item.GetStringRepresentation()}");
            cartTotal += item.CalculateTotalPrice();
            counter ++;
        }

        Console.WriteLine($"\nTotal: ${cartTotal:F2}");

        Console.Write("\nPress enter to return to the main menu: ");
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