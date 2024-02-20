public class ItemCreator
{
    float costResinPerCM3 = 0.05f;
    float costPerColor = 1.25f;
    List<Option> centreFillOptionsList = new List<Option>{new Option("Insect", 4.5f), new Option("Fish", 3.5f), new Option("Rock", 2f), new Option("Flower", 1.75f)};
    List<Option> textureFillOptionsList = new List<Option>{new Option("Glitter", 0.75f), new Option("Stars", 1.25f), new Option("Foil", 1f)};



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

        item.AddOption(new ResinOption("resin", item.CalculateVolume(), costResinPerCM3));

        AskColor(new List<string>{"red", "orange", "yellow", "green", "blue", "purple"});
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
        
    }

    private void AskText()
    {
        
    }
}