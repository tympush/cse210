public class ItemCreator
{
    public Item CreateItem()
    {
        Item item = null;

        Console.Clear();
        Console.Write("");
        string shapeInput = Console.ReadLine();

        if (shapeInput == "1")
        {
            item = new CubeItem(1);
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

        item.AddOption(new ResinOption("Resin", item.CalculateVolume(), 1));

        AskColor();
        AskCentreFill();
        AskTextureFill();
        AskBase();
        AskText();

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