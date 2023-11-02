using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using ASM2.Factory;
using ASM2.NewFolder;
using ASM2.NewFolder1;

namespace ASM2
{
    public class RunSystem
    {
        static void Main(string[] args)
        {
            //logic
            IKitchenFactory factory = null;
            AbstractPan panProduct = null;
            AbstractPot potProduct = null;
            List<AbstractPan> panList = new List<AbstractPan>();
            List<AbstractPot> potList = new List<AbstractPot>();
            bool exit = false;
            int editing = 0;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|                    MENU                    |");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("| 1. Start creating product                  |");
                Console.WriteLine("| 2. Show product                            |");
                Console.WriteLine("| 3. Edit product                            |");
                Console.WriteLine("| 4. Delete product                          |");
                Console.WriteLine("| 5. Test product                            |");
                Console.WriteLine("| 6. Exit                                    |");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("");
                Console.WriteLine("Please choose one");
                int choiceMenu1;
                try
                {
                    choiceMenu1 = int.Parse(Console.ReadLine());

                    switch (choiceMenu1)
                    {
                        case 1:
                            bool backToLevel1 = false;

                            while (!backToLevel1)
                            {
                                Console.Clear();
                                Console.WriteLine("+--------------------------------------------+");
                                Console.WriteLine("|            CHOOSE YOUR MATERIAL            |");
                                Console.WriteLine("+--------------------------------------------+");
                                Console.WriteLine("| 1. Iron                                    |");
                                Console.WriteLine("| 2. Inox                                    |");
                                Console.WriteLine("| 3. Back                                    |");
                                Console.WriteLine("+--------------------------------------------+");
                                Console.WriteLine("");
                                Console.WriteLine("Please choose one");
                                int choiceMenu2;
                                try
                                {
                                    choiceMenu2 = int.Parse(Console.ReadLine());

                                    switch (choiceMenu2)
                                    {
                                        case 1:
                                            //logic
                                            factory = new IronKitchenFactory();
                                            //
                                            bool backToLevel2 = false;
                                            while (!backToLevel2)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("|         CHOOSE YOUR KITCHEN TOOL           |");
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("| 1. Pan                                     |");
                                                Console.WriteLine("| 2. Pot                                     |");
                                                Console.WriteLine("| 3. Back                                    |");
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("");
                                                Console.WriteLine("Please choose one");
                                                int choiceMenu3;
                                                try
                                                {
                                                    choiceMenu3 = int.Parse(Console.ReadLine());

                                                    switch (choiceMenu3)
                                                    {
                                                        case 1:
                                                            //logic
                                                            panProduct = factory.CreatePan();
                                                            panProduct.Name = "Pan";
                                                            panProduct.Material = "Iron";
                                                            panList.Add(panProduct);
                                                            createNotification();
                                                            backToLevel2 = true;
                                                            backToLevel1 = true;
                                                            //
                                                            break;
                                                        case 2:
                                                            //logic
                                                            potProduct = factory.CreatePot();
                                                            potProduct.Name = "Pot";
                                                            potProduct.Material = "Iron";
                                                            potList.Add(potProduct);
                                                            createNotification();
                                                            backToLevel2 = true;
                                                            backToLevel1 = true;
                                                            //
                                                            break;
                                                        case 3:
                                                            backToLevel2 = true;
                                                            break;
                                                        default:
                                                            invalidNotification();
                                                            break;
                                                    }
                                                }
                                                catch (System.Exception e)
                                                {
                                                    invalidNotification();
                                                }
                                            }
                                            break;
                                        case 2:
                                            //logic
                                            factory = new InoxKitchenFactory();
                                            //
                                            bool backToLevel2_1 = false;
                                            while (!backToLevel2_1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("|         CHOOSE YOUR KITCHEN TOOL           |");
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("| 1. Pan                                     |");
                                                Console.WriteLine("| 2. Pot                                     |");
                                                Console.WriteLine("| 3. Back to menu                            |");
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("");
                                                Console.WriteLine("Please choose one");
                                                int choiceMenu3;
                                                try
                                                {
                                                    choiceMenu3 = int.Parse(Console.ReadLine());

                                                    switch (choiceMenu3)
                                                    {
                                                        case 1:
                                                            //logic
                                                            panProduct = factory.CreatePan();
                                                            panProduct.Name = "Pan";
                                                            panProduct.Material = "Inox";
                                                            panList.Add(panProduct);
                                                            createNotification();
                                                            backToLevel2_1 = true;
                                                            backToLevel1 = true;
                                                            //
                                                            break;
                                                        case 2:
                                                            //logic
                                                            potProduct = factory.CreatePot();
                                                            potProduct.Name = "Pot";
                                                            potProduct.Material = "Inox";
                                                            potList.Add(potProduct);
                                                            createNotification();
                                                            backToLevel2_1 = true;
                                                            backToLevel1 = true;
                                                            //
                                                            break;
                                                        case 3:
                                                            backToLevel2_1 = true;
                                                            break;
                                                        default:
                                                            invalidNotification();
                                                            break;
                                                    }
                                                }
                                                catch (System.Exception e)
                                                {
                                                    invalidNotification();
                                                }
                                            }
                                            break;
                                        case 3:
                                            backToLevel1 = true;
                                            break;
                                        default:
                                            invalidNotification();
                                            break;
                                    }
                                }
                                catch (System.Exception e)
                                {
                                    invalidNotification();
                                }
                            }
                            break;
                        case 2:
                            productList();
                            Console.ReadLine();
                            break;
                        case 3:
                            productList();
                            Console.WriteLine("Choose the product you want to edit:");
                            int choiceEdit;
                            try
                            {
                                choiceEdit = int.Parse(Console.ReadLine());

                                //logic choose the product list
                                bool PanChoice = false;
                                bool PotChoice = false;
                                // chose and choice
                                int choseEdit = (choiceEdit - 1);
                                if (choseEdit < panList.Count)
                                {
                                    for (int i = 0; i < panList.Count; i++)
                                    {
                                        if (choseEdit == i)
                                        {
                                            PanChoice = true;
                                            editing = i;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    choseEdit = choseEdit - panList.Count;
                                    for (int i = 0; i < potList.Count; i++)
                                    {
                                        if (choseEdit == i)
                                        {
                                            PotChoice = true;
                                            editing = i;
                                            break;
                                        }
                                    }
                                }

                                if (PanChoice)
                                {
                                    bool edit_while = false;
                                    while (!edit_while)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("|                    Edit - Pan              |");
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("| 1. Edit size                               |");
                                        Console.WriteLine("| 2. Edit mass                               |");
                                        Console.WriteLine("| 3. Back                                    |");
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("");
                                        Console.WriteLine("Please choose one");
                                        int choiceEditItem;
                                        try
                                        {
                                            choiceEditItem = int.Parse(Console.ReadLine());
                                            switch (choiceEditItem)
                                            {
                                                case 1:
                                                    bool edit_size = false;
                                                    while (!edit_size)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|            EDIT-CHOOSE YOUR SIZE           |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("| 1. 20cm                                    |");
                                                        Console.WriteLine("| 2. 24cm                                    |");
                                                        Console.WriteLine("| 3. 28cm                                    |");
                                                        Console.WriteLine("| 4. Back                                    |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Please choose one");
                                                        int kitchenToolEdit = 0;
                                                        try
                                                        {
                                                            kitchenToolEdit = int.Parse(Console.ReadLine());

                                                            switch (kitchenToolEdit)
                                                            {
                                                                case 1:
                                                                    panList[editing].Size = "20cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 2:
                                                                    panList[editing].Size = "24cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 3:
                                                                    panList[editing].Size = "28cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 4:
                                                                    edit_size = true;
                                                                    break;
                                                                default:
                                                                    invalidNotification();
                                                                    break;
                                                            }
                                                        }
                                                        catch (System.Exception e)
                                                        {
                                                            invalidNotification();
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    bool edit_status = false;
                                                    while (!edit_status)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|                  EDIT MASS                 |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("| 1. 1Kg                                     |");
                                                        Console.WriteLine("| 2. 1.5Kg                                   |");
                                                        Console.WriteLine("| 3. 2.5Kg                                   |");
                                                        Console.WriteLine("| 4. Back                                    |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Please choose one");
                                                        int EditStatus;
                                                        try
                                                        {
                                                            EditStatus = int.Parse(Console.ReadLine());

                                                            switch (EditStatus)
                                                            {
                                                                case 1:
                                                                    panList[editing].Mass = "1Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 2:
                                                                    panList[editing].Mass = "1.5Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 3:
                                                                    panList[editing].Mass = "2.5Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 4:
                                                                    edit_status = true;
                                                                    break;
                                                                default:
                                                                    invalidNotification();
                                                                    break;
                                                            }
                                                        }
                                                        catch (System.Exception e)
                                                        {
                                                            invalidNotification();
                                                        }
                                                    }
                                                    break;
                                                case 3:
                                                    edit_while = true;
                                                    break;
                                                default:
                                                    invalidNotification();
                                                    break;
                                            }
                                        }
                                        catch (System.Exception e)
                                        {
                                            invalidNotification();
                                        }
                                    }

                                }

                                else if (PotChoice)
                                {
                                    bool edit_while = false;
                                    while (!edit_while)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("|                    Edit - Pot              |");
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("| 1. Edit size                               |");
                                        Console.WriteLine("| 2. Edit mass                               |");
                                        Console.WriteLine("| 3. Back                                    |");
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("");
                                        Console.WriteLine("Please choose one");
                                        int choiceEditItem;
                                        try
                                        {
                                            choiceEditItem = int.Parse(Console.ReadLine());

                                            switch (choiceEditItem)
                                            {
                                                case 1:
                                                    bool edit_size = false;
                                                    while (!edit_size)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|            EDIT-CHOOSE YOUR SIZE           |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("| 1. 20cm                                    |");
                                                        Console.WriteLine("| 2. 24cm                                    |");
                                                        Console.WriteLine("| 3. 28cm                                    |");
                                                        Console.WriteLine("| 4. Back                                    |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Please choose one");
                                                        int kitchenToolEdit;
                                                        try
                                                        {
                                                            kitchenToolEdit = int.Parse(Console.ReadLine());

                                                            switch (kitchenToolEdit)
                                                            {
                                                                case 1:
                                                                    potList[editing].Size = "20cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 2:
                                                                    potList[editing].Size = "24cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 3:
                                                                    potList[editing].Size = "28cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 4:
                                                                    edit_size = true;
                                                                    break;
                                                                default:
                                                                    invalidNotification();
                                                                    break;
                                                            }
                                                        }
                                                        catch (System.Exception e)
                                                        {
                                                            invalidNotification();
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    bool edit_status = false;
                                                    while (!edit_status)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|                  EDIT MASS                 |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("| 1. 1Kg                                     |");
                                                        Console.WriteLine("| 2. 1.5Kg                                   |");
                                                        Console.WriteLine("| 3. 2.5Kg                                   |");
                                                        Console.WriteLine("| 4. Back                                    |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Please choose one");
                                                        int EditStatus;
                                                        try
                                                        {
                                                            EditStatus = int.Parse(Console.ReadLine());

                                                            switch (EditStatus)
                                                            {
                                                                case 1:
                                                                    potList[editing].Mass = "1Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    Console.Clear();
                                                                    editNotification();
                                                                    break;
                                                                case 2:
                                                                    potList[editing].Mass = "1.5Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 3:
                                                                    potList[editing].Mass = "2.5Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case 4:
                                                                    edit_status = true;
                                                                    break;
                                                                default:
                                                                    invalidNotification();
                                                                    break;
                                                            }
                                                        }
                                                        catch (System.Exception e)
                                                        {
                                                            invalidNotification();
                                                        }
                                                    }
                                                    break;
                                                case 3:
                                                    edit_while = true;
                                                    break;
                                                default:
                                                    invalidNotification();
                                                    break;
                                            }
                                        }
                                        catch (System.Exception e)
                                        {
                                            invalidNotification();
                                        }
                                    }
                                }
                                else
                                {
                                    invalidNotification();
                                }
                            }
                            catch (System.Exception e)
                            {
                                invalidNotification();
                            }
                            break;
                        case 4:
                            productList();
                            Console.WriteLine("Choose the product you want to delete:");
                            int choiceDelete;
                            try
                            {
                                choiceDelete = int.Parse(Console.ReadLine());

                                bool PanChoice = false;
                                bool PotChoice = false;
                                // chose and choice
                                int choseEdit = (choiceDelete - 1);
                                if (choseEdit < panList.Count)
                                {
                                    for (int i = 0; i < panList.Count; i++)
                                    {
                                        if (choseEdit == i)
                                        {
                                            PanChoice = true;
                                            editing = i;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    choseEdit = choseEdit - panList.Count;
                                    for (int i = 0; i < potList.Count; i++)
                                    {
                                        if (choseEdit == i)
                                        {
                                            PotChoice = true;
                                            editing = i;
                                            break;
                                        }
                                    }
                                }
                                if (PanChoice)
                                {
                                    panList.Remove(panList[editing]);
                                    deleteNotification();
                                }
                                if (PotChoice)
                                {
                                    potList.Remove(potList[editing]);
                                    deleteNotification();
                                }
                            }
                            catch (System.Exception e)
                            {
                                invalidNotification();
                            }
                            break;
                        case 5:
                            productList();
                            Console.WriteLine("Choose the product you want to test:");
                            int choiceTest;
                            try
                            {
                                choiceTest = int.Parse(Console.ReadLine());

                                bool PanChoice = false;
                                bool PotChoice = false;
                                // chose and choice
                                int choseEdit = (choiceTest - 1);
                                if (choseEdit < panList.Count)
                                {
                                    for (int i = 0; i < panList.Count; i++)
                                    {
                                        if (choseEdit == i)
                                        {
                                            PanChoice = true;
                                            editing = i;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    choseEdit = choseEdit - panList.Count;
                                    for (int i = 0; i < potList.Count; i++)
                                    {
                                        if (choseEdit == i)
                                        {
                                            PotChoice = true;
                                            editing = i;
                                            break;
                                        }
                                    }
                                }
                                if (PanChoice)
                                {
                                    if (!string.IsNullOrEmpty(panList[editing].Size) && !string.IsNullOrEmpty(panList[editing].Mass))
                                    {
                                        bool panTest = false;
                                        while (!panTest)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("|                   TESTING                  |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("| 1. Increase the temperature.               |");
                                            Console.WriteLine("| 2. Lower the temperature.                  |");
                                            Console.WriteLine("| 3. Test fry meat                           |");
                                            Console.WriteLine("| 4. Back                                    |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("");
                                            Console.WriteLine("Please choose one");
                                            int testing;
                                            try
                                            {
                                                testing = int.Parse(Console.ReadLine());

                                                switch (testing)
                                                {
                                                    case 1:
                                                        double firstTemperature = 0;
                                                        double secondTemperature = 0;
                                                        double checkValid;
                                                        bool loop = false;
                                                        while (!loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|    Testing with Increase the temperature   |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("Input your first temperature: ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());
                                                                firstTemperature = checkValid;
                                                                loop = true;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        while (loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Input your second temperature: ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());
                                                                secondTemperature = checkValid;
                                                                loop = false;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        Console.WriteLine("");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("The time Increase the temperature with power is 600W: ");
                                                        Console.WriteLine(changeToMinute(Math.Round(panList[editing].increaseTemperatrue(firstTemperature, secondTemperature))));
                                                        Console.ReadLine();
                                                        break;
                                                    case 2:
                                                        loop = false;
                                                        firstTemperature = 0;
                                                        secondTemperature = 0;
                                                        while (!loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|    Testing with Decrease the temperature   |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("Input your first temperature: ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());
                                                                firstTemperature = checkValid;
                                                                loop = true;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        while (loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Input your second temperature: ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());

                                                                secondTemperature = checkValid;
                                                                loop = false;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        Console.WriteLine("The time decrease the temperature: ");
                                                        Console.WriteLine(changeToMinute(Math.Round(panList[editing].decreaseTemperatrue(firstTemperature, secondTemperature))));
                                                        Console.ReadLine();
                                                        break;
                                                    case 3:
                                                        loop = false;
                                                        double meatMass = 0;
                                                        double fitMass = 0;
                                                        while (!loop)
                                                        {
                                                            if (panList[editing].Size == "20cm")
                                                            {
                                                                fitMass = 300.0;
                                                            }
                                                            if (panList[editing].Size == "24cm")
                                                            {
                                                                fitMass = 400.0;
                                                            }
                                                            if (panList[editing].Size == "28cm")
                                                            {
                                                                fitMass = 500.0;
                                                            }
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|               Testing fry meat             |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("Input your meat mass (g): ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());
                                                                meatMass = checkValid;
                                                                loop = true;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        Console.WriteLine("The time to finish with " + meatMass + "g with size pan = " + panList[editing].Size + " :");
                                                        Console.WriteLine(changeToMinute(Math.Round(panList[editing].fryMeat(meatMass, fitMass))));
                                                        Console.ReadLine();
                                                        break;
                                                    case 4:
                                                        panTest = true;
                                                        break;
                                                    default:
                                                        invalidNotification();
                                                        break;
                                                }
                                            }
                                            catch (System.Exception e)
                                            {
                                                invalidNotification();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("+------------------------------------------------------+");
                                        Console.WriteLine("|  Your product must have full information to testing  |");
                                        Console.WriteLine("+------------------------------------------------------+");
                                        Console.ReadLine();
                                    }
                                }
                                if (PotChoice)
                                {
                                    if (!string.IsNullOrEmpty(potList[editing].Size) && !string.IsNullOrEmpty(potList[editing].Mass))
                                    {
                                        bool potTest = false;
                                        while (!potTest)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("|                   TESTING                  |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("| 1. Increase the temperature.               |");
                                            Console.WriteLine("| 2. Lower the temperature.                  |");
                                            Console.WriteLine("| 3. Test boiling meat                       |");
                                            Console.WriteLine("| 4. Back                                    |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("");
                                            Console.WriteLine("Please choose one");
                                            int testing;
                                            try
                                            {
                                                testing = int.Parse(Console.ReadLine());

                                                switch (testing)
                                                {
                                                    case 1:
                                                        double firstTemperature = 0;
                                                        double secondTemperature = 0;
                                                        double checkValid;
                                                        bool loop = false;
                                                        while (!loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|    Testing with Increase the temperature   |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("Input your first temperature: ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());
                                                                firstTemperature = checkValid;
                                                                loop = true;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        while (loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Input your second temperature: ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());

                                                                secondTemperature = checkValid;
                                                                loop = false;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        Console.WriteLine("The time Increase the temperature with power is 600W: ");
                                                        Console.WriteLine(changeToMinute(Math.Round(potList[editing].increaseTemperatrue(firstTemperature, secondTemperature))));
                                                        Console.ReadLine();
                                                        break;
                                                    case 2:
                                                        loop = false;
                                                        firstTemperature = 0;
                                                        secondTemperature = 0;
                                                        while (!loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|    Testing with Decrease the temperature   |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("Input your first temperature: ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());
                                                                firstTemperature = checkValid;
                                                                loop = true;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        while (loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Input your second temperature: ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());

                                                                secondTemperature = checkValid;
                                                                loop = false;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        Console.WriteLine("The time to decrese the temperature: ");
                                                        Console.WriteLine(changeToMinute(Math.Round(potList[editing].decreaseTemperatrue(firstTemperature, secondTemperature))));
                                                        Console.ReadLine();
                                                        break;
                                                    case 3:
                                                        loop = false;
                                                        double meatMass = 0;
                                                        double fitMass = 0;
                                                        while (!loop)
                                                        {
                                                            if (potList[editing].Size == "20cm")
                                                            {
                                                                fitMass = 800.0;
                                                            }
                                                            if (potList[editing].Size == "24cm")
                                                            {
                                                                fitMass = 1000.0;
                                                            }
                                                            if (potList[editing].Size == "28cm")
                                                            {
                                                                fitMass = 1100.0;
                                                            }
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|            Testing boiling meat            |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("Input your meat mass (g): ");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());
                                                                meatMass = checkValid;
                                                                loop = true;
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        Console.WriteLine("The time to finish with " + meatMass + "g " + "with size pot = " + potList[editing].Size + " :");
                                                        Console.WriteLine(changeToMinute(Math.Round(potList[editing].boilingMeat(meatMass, fitMass))));
                                                        Console.ReadLine();
                                                        break;
                                                    case 4:
                                                        potTest = true;
                                                        break;
                                                    default:
                                                        invalidNotification();
                                                        break;
                                                }
                                            }
                                            catch (System.Exception e)
                                            {
                                                invalidNotification();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("+------------------------------------------------------+");
                                        Console.WriteLine("|  Your product must have full information to testing  |");
                                        Console.WriteLine("+------------------------------------------------------+");
                                        Console.ReadLine();
                                    }
                                }
                            }
                            catch (System.Exception e)
                            {
                                invalidNotification();
                            }
                            break;
                        case 6:
                            exit = true;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("+--------------------------------------------+");
                            Console.WriteLine("|                SEE YOU AGAIN               |");
                            Console.WriteLine("+--------------------------------------------+");
                            break;
                        default:
                            invalidNotification();
                            break;
                    }
                }
                catch (System.Exception e)
                {
                    invalidNotification();
                }
            }
            void productList()
            {
                if (panList.Count == 0 && potList.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("+------------------------------------------------------+");
                    Console.WriteLine("|      You must have at least one product to show      |");
                    Console.WriteLine("+------------------------------------------------------+");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("------------------- Product List--------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("+---------------------------------------------------+");
                    Console.WriteLine("|  Num  |  Product  |  Material  |  Size  |  Mass   |");
                    Console.WriteLine("+---------------------------------------------------+");
                    int numTest = 1;
                    for (int i = 0; i < panList.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(panList[i].Name))
                        {
                            Console.WriteLine("|  " + (numTest) + "    |  " + panList[i].Name + "      |  " + panList[i].Material +
                            "      |  " + panList[i].Size + whiteSpace(panList[i].Size) + "  |  " + panList[i].Mass + whiteSpace(panList[i].Mass) + "    |");
                            Console.WriteLine("+---------------------------------------------------+");
                            numTest++;
                        }
                    }
                    for (int i = 0; i < potList.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(potList[i].Name))
                        {
                            Console.WriteLine("|  " + (numTest) + "    |  " + potList[i].Name + "      |  " + potList[i].Material +
                            "      |  " + potList[i].Size + whiteSpace(potList[i].Size) + "  |  " + potList[i].Mass + whiteSpace(potList[i].Mass) + "    |");
                            Console.WriteLine("+---------------------------------------------------+");
                            numTest++;
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
            void invalidNotification()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|               INVALID CHOICE               |");
                Console.WriteLine("+--------------------------------------------+");
                Console.ReadLine();
            }
            void deleteNotification()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|              DELETE SUCCESS                |");
                Console.WriteLine("+--------------------------------------------+");
                Console.ReadLine();
            }
            void editNotification()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|                 EDIT SUCCESS               |");
                Console.WriteLine("+--------------------------------------------+");
                Console.ReadLine();
            }
            void createNotification()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|               Create successful            |");
                Console.WriteLine("+--------------------------------------------+");
                Console.ReadLine();
            }
            string whiteSpace(string value)
            {
                string space = "";
                if (value == null)
                {
                    space = space + "    ";
                }
                else
                {
                    return space;
                }
                return space;
            }
            string changeToMinute(double value)
            {
                double minute = value / 60;
                double second = value % 60;
                return Math.Round(minute) + " minute + " + Math.Round(second) + " second";
            }
        }
    }
}
