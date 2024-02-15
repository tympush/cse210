public class Menu
{
    public void Start()
    {
        string menuInput;

        do
        {
            ItemCreator itemCreator = new ItemCreator();
            Cart cart = new Cart();
            OrderSaver orderSaver = new OrderSaver();

            Console.Write("Menu Options:\n   1. Create New Item\n   2. View Cart\n   3. Complete Order\n   4. Quit\nSelect a choice from the menu: ");
            menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                cart.AddToCart(itemCreator.Start());
            }

            if (menuInput == "2")
            {
                cart.DisplayCart();
            }

            if (menuInput == "3")
            {
                orderSaver.CompleteOrder();
            }

        }while (menuInput != "4");
    }
}