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

            Console.Write("Menu Options:\n   1. Create New Item\n   2. View Cart\n   3. Empty Cart\n   4. Complete Order\n   5. Quit\nSelect a choice from the menu: ");
            menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                cart.AddToCart(itemCreator.CreateItem());
            }

            else if (menuInput == "2")
            {
                cart.DisplayCart();
            }

            else if (menuInput == "3")
            {
                cart.EmptyCart();
            }

            else if (menuInput == "4")
            {
                orderSaver.CompleteOrder(cart.GetCart());
            }

        }while (menuInput != "5");
    }
}