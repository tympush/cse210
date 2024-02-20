public class OrderSaver
{
    public void CompleteOrder(List<Item> cart)
    {
        Console.Clear();
        Console.Write("Email: ");
        string emailInput = Console.ReadLine();

        Console.Write("Shipping Addresss: ");
        string addressInput = Console.ReadLine();

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string orderCode ="";

        for (int i = 0; i < 10; i++)
        {
            int index = new Random().Next(0, chars.Length);
            orderCode += chars[index];
        }

        using (StreamWriter outputFile = new StreamWriter($"{orderCode}.txt"))
        {
            outputFile.WriteLine($"Order Number: {orderCode}\nEmail: {emailInput}\nShipping Addresss: {addressInput}\n\nOrder:");

            int counter = 1;

            foreach (Item item in cart)
            {
                outputFile.WriteLine($"   {counter}. {item.GetStringRepresentation()}");
                counter ++;
            }
        }

        Console.Clear();
        Console.Write("Thank you for your Order!\nPress enter to return to the main menu: ");
        Console.ReadLine();
    }
}