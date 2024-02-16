public class ItemCreator
{
    public Item CreateItem()
    {
        Item item = null;

        Console.Clear();
        Console.WriteLine("Create your item.\nFirst, select a shape:");

        do
        {
            float cubeSideInputFloat = 0;

            Console.Write("   1. Cube\n   2. Cuboid\n   3. Pyramidt\n   4. Half Sphere\nShape number: ");
            string shapeInput = Console.ReadLine();

            if (shapeInput == "1")
            {
                while(true)
                {
                    Console.Clear();
                    Console.Write("How long will each side of your cube be? (in cm): ");
                    string cubeSideInput = Console.ReadLine();

                    if (float.TryParse(cubeSideInput, out cubeSideInputFloat))
                    {
                        if(cubeSideInputFloat < 1)
                        {
                            Console.WriteLine("Invalid input. Please choose a minimum of 1cm.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose a valid integer.");
                    }

                }

                item = new CubeItem(cubeSideInputFloat);
            }

            else if (shapeInput == "2")
            {
                item = new CuboidItem(1,1,1);
            }

            else if (shapeInput == "3")
            {
                item = new PyramidItem(1,1);
            }

            else if (shapeInput == "4")
            {
                item = new HalfSphereItem(1);
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input.\nPlease select a shape:");
            }

        } while (item == null);

        item.AddOption(new ResinOption("Resin", item.CalculateVolume(), 1));

        AskColor();
        AskCentreFill();
        AskTextureFill();
        AskBase();
        AskText();

        Console.Clear();
        Console.Write("Item created.\nPress enter to return to the main menu: ");
        Console.ReadLine();
        
        return item;
    }

    private void AskColor()
    {

    }

    private void AskCentreFill()
    {
        
    }

    private void AskTextureFill()
    {
        
    }

    private void AskBase()
    {
        
    }

    private void AskText()
    {
        
    }
}