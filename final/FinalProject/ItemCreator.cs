using System.Data;

public class ItemCreator
{
    float costResinPerCM3 = 0.05f;
    float costPerColor = 1.25f;
    List<string> colorOptionsList = new List<string>
    {
        "red", "burgundy", "scarlet", 
        "orange", "yellow-orange", "yellow", 
        "lime", "green", "forest green", 
        "sky blue", "blue", "navy blue",
        "purple", "violet", "magenta",
        "pink", "deep pink", "flamingo",
        "brown", "light grey", "dark grey",
        "black", "white"
    };
    List<Option> centreFillOptionsList = new List<Option>
    {
        new Option("Insect", 4.5f), 
        new Option("Fish", 3.5f), 
        new Option("Rock", 2f), 
        new Option("Flower", 1.75f), 
        new Option("Skull", 5f),
        new Option("Liquid Core", 2.75f)
    };
    List<Option> textureFillOptionsList = new List<Option>
    {
        new Option("Fine Glitter", 0.75f), 
        new Option("Large Glitter", 0.1f), 
        new Option("Stars", 1.25f), 
        new Option("Foil", 0.85f),
        new Option("Glow-In-The-Dark Pigment", 1.55f)
    };
    float costWoodBasePerCM2 = 0.07f;
    float costMetalBasePerCM2 = 0.2f;
    float costWoodTextPerLetter = 0.15f;
    float costMetalTextPerLetter = 0.5f;



    Item item = null;

    public Item CreateItem()
    {
        Console.Clear();
        Console.WriteLine("Create your item.\nFirst, select a shape:");

        do
        {
            Console.Write("   1. Cube\n   2. Cuboid\n   3. Pyramid\n   4. Half Sphere\nShape number: ");
            string shapeInput = Console.ReadLine();

            if (shapeInput == "1")
            {
                AskCube();
            }

            else if (shapeInput == "2")
            {
                AskCuboid();
            }

            else if (shapeInput == "3")
            {
                AskCPyramid();
            }

            else if (shapeInput == "4")
            {
                AskHalfSphere();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input.\nPlease select a shape:");
            }

        } while (item == null);

        item.AddOption(new ResinOption("Resin", item.CalculateVolume(), costResinPerCM3));

        AskColor(colorOptionsList);
        AskFill(centreFillOptionsList, "Pick something to put in the centre of your item:");
        AskFill(textureFillOptionsList, "Pick something to mix into the texture of your item:");
        AskBase();
        AskText();

        Console.Clear();
        Console.Write("Item created.\nPress enter to return to the main menu: ");
        Console.ReadLine();

        return item;
    }



    private void AskCube()
    {
        float cubeSideInputFloat = 0;

        Console.Clear();

        while(true)
        {
            Console.Write("How long will each side of your cube be? (in cm): ");
            string cubeSideInput = Console.ReadLine();

            if (float.TryParse(cubeSideInput, out cubeSideInputFloat))
            {
                if(cubeSideInputFloat < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please choose a minimum of 1cm.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid integer.");
            }

        }

        item = new CubeItem(cubeSideInputFloat);
    }

    private void AskCuboid()
    {
        float cuboidLengthInputFloat = 0;
        float cuboidWidthInputFloat = 0;
        float cuboidHeightInputFloat = 0;

        Console.Clear();

        while(true)
        {
            Console.Write("What will be the length of your cuboid? (in cm): ");
            string cuboidLengthInput = Console.ReadLine();

            if (float.TryParse(cuboidLengthInput, out cuboidLengthInputFloat))
            {
                if(cuboidLengthInputFloat < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please choose a minimum of 1cm.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid integer.");
            }

        }

        while(true)
        {
            Console.Write("What will be the width of your cuboid?? (in cm): ");
            string cuboidWidthInput = Console.ReadLine();

            if (float.TryParse(cuboidWidthInput, out cuboidWidthInputFloat))
            {
                if(cuboidWidthInputFloat < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please choose a minimum of 1cm.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid integer.");
            }

        }

        while(true)
        {
            Console.Write("What will be the height of your cuboid? (in cm): ");
            string cuboidHeightInput = Console.ReadLine();

            if (float.TryParse(cuboidHeightInput, out cuboidHeightInputFloat))
            {
                if(cuboidHeightInputFloat < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please choose a minimum of 1cm.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid integer.");
            }

        }

        item = new CuboidItem(cuboidLengthInputFloat, cuboidWidthInputFloat, cuboidHeightInputFloat);
    }

    private void AskCPyramid()
    {
        float pyramidBaseSizeInputFloat = 0;
        float pyramidHeighteInputFloat = 0;

        Console.Clear();

        while(true)
        {
            Console.Write("How long will the base sides of your pyramid be? (in cm): ");
            string pyramidBaseSizeInput = Console.ReadLine();

            if (float.TryParse(pyramidBaseSizeInput, out pyramidBaseSizeInputFloat))
            {
                if(pyramidBaseSizeInputFloat < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please choose a minimum of 1cm.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid integer.");
            }
        }

        while(true)
        {
            Console.Write("How tall will your pyramid be? (in cm): ");
            string pyramidHeighteInput = Console.ReadLine();

            if (float.TryParse(pyramidHeighteInput, out pyramidHeighteInputFloat))
            {
                if(pyramidHeighteInputFloat < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please choose a minimum of 1cm.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid integer.");
            }
        }

        item = new PyramidItem(pyramidBaseSizeInputFloat, pyramidHeighteInputFloat);
    }

    private void AskHalfSphere()
    {
        float halfSphereSideInputFloat = 0;

        Console.Clear();

        while(true)
        {
            Console.Write("How large will be the radius of your half-sphere? (in cm): ");
            string halfSphereSideInput = Console.ReadLine();

            if (float.TryParse(halfSphereSideInput, out halfSphereSideInputFloat))
            {
                if(halfSphereSideInputFloat < 0.5)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please choose a minimum of 0.5cm.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid integer.");
            }

        }

        item = new HalfSphereItem(halfSphereSideInputFloat);
    }



    private void AskColor(List<string> colorList)
    {
        int colorPickCountdown = 0;

        Console.Clear();

        while (true)
        {
            Console.Write($"How many colors would you like to use for your item? ${costPerColor} per color.\nSelect 0/1/2/3: ");
            string colorAmountInput = Console.ReadLine();

            if (colorAmountInput == "0")
            {
                break;
            }

            else if (colorAmountInput == "1")
            {
                colorPickCountdown = 1;
                break;
            }

            else if (colorAmountInput == "2")
            {
                colorPickCountdown = 2;
                break;
            }

            else if (colorAmountInput == "3")
            {
                colorPickCountdown = 3;
                break;
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please pick 0, 1, 2 or 3.");
            }
        }



        int colorNameCounter = 1;
        Console.Clear();

        while (colorPickCountdown > 0)
        {
            Console.WriteLine($"Pick Color {colorNameCounter}:");

            int colorListCounter = 1;

            foreach (string color in colorList)
            {
                Console.WriteLine($"   {colorListCounter}. {color}");
                colorListCounter++;
            }



            Console.Write("Select one of the options above: ");
            string colorChoiceInput = Console.ReadLine();

            if (int.TryParse(colorChoiceInput, out int colorChoiceInputInt))
            {
                if(colorChoiceInputInt > 0 && colorChoiceInputInt <= colorList.Count)
                {
                    item.AddOption(new ColorOption($"Color{colorNameCounter}", colorList[colorChoiceInputInt - 1], costPerColor));
                    colorNameCounter++;
                    colorPickCountdown--;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please pick a valid number from the list.");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid integer.");
            }
        }
    }

    private void AskFill(List<Option> fillList, string message)
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine(message);

            int fillListCounter = 1;

            foreach (Option fill in fillList)
            {
                Console.WriteLine($"   {fillListCounter}. {fill.GetName()} - ${fill.GetCost()}");
                fillListCounter++;
            }

            Console.WriteLine($"   {fillListCounter}. None");



            Console.Write("Select one of the options above: ");
            string fillChoiceInput = Console.ReadLine();

            if (int.TryParse(fillChoiceInput, out int fillChoiceInputInt))
            {
                if (fillChoiceInputInt == fillList.Count + 1)
                {
                    Console.Clear();
                    break;
                }
                else if(fillChoiceInputInt > 0 && fillChoiceInputInt <= fillList.Count)
                {
                    item.AddOption(fillList[fillChoiceInputInt - 1]);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please pick a valid number from the list.");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid integer.");
            }
        }
    }

    private void AskBase()
    {
        string baseInput;

        Console.Clear();

        while (true)
        {
            Console.Write("Do you want a base for your item? y/n: ");
            baseInput = Console.ReadLine();

            if (baseInput.ToLower() == "n" || baseInput.ToLower() == "y")
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please type y or n.");
            }
        }

        Console.Clear();

        while (baseInput.ToLower() == "y")
        {
            Console.Write($"What material do you want the base to be made of?\n   1. Wood - ${costWoodBasePerCM2}/cm²\n   2. Metal - ${costMetalBasePerCM2}/cm²\nSelect one of the options above: ");
            string baseChoiceInput = Console.ReadLine();

            if (baseChoiceInput == "1")
            {
                item.AddOption(new BaseOption("Wooden Base", item.CalculateBase(), costWoodBasePerCM2));
                break;
            }
            else if (baseChoiceInput == "2")
            {
                item.AddOption(new BaseOption("Metal Base", item.CalculateBase(), costMetalBasePerCM2));
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please pick a valid number from the list.");
            }
        }
    }

    private void AskText()
    {
        string textInput;
        string customTextInput = "void";

        Console.Clear();

        while (true)
        {
            Console.Write("Do you want a custom text for your item? y/n: ");
            textInput = Console.ReadLine();

            if (textInput.ToLower() == "n" || textInput.ToLower() == "y")
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please type y or n.");
            }
        }

        Console.Clear();

        while (textInput.ToLower() == "y")
        {
            Console.Write("Input your custom text (max 16 characters): ");
            customTextInput = Console.ReadLine();

            if (customTextInput.Count() < 1)
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please type at least 1 character.");
            }
            else if (customTextInput.Count() > 16)
            {
                Console.Clear();
                Console.WriteLine("Invalid input. The max number of characters is 16.");
            }
            else
            {
                break;
            }
        }

        Console.Clear();

        while (textInput.ToLower() == "y")
        {
            Console.Write($"What material do you want the text tag to be made of?\n   1. Wood - ${costWoodTextPerLetter}/letter\n   2. Metal - ${costMetalTextPerLetter}/letter\nSelect one of the options above: ");
            string textChoiceInput = Console.ReadLine();

            if (textChoiceInput == "1")
            {
                item.AddOption(new TextOption("Wooden Text", customTextInput.ToUpper(), costWoodTextPerLetter));
                break;
            }
            else if (textChoiceInput == "2")
            {
                item.AddOption(new TextOption("Metal Text", customTextInput.ToUpper(), costMetalTextPerLetter));
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please pick a valid number from the list.");
            }
        }
    }
}