public class ItemCreator
{
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

        item.AddOption(new ResinOption("resin", item.CalculateVolume(), 0.05f));

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