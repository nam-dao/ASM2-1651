using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                string choiceMenu1;
                choiceMenu1 = Console.ReadLine();
                if (Regex.IsMatch(choiceMenu1, "[0-9]") && choiceMenu1 != "0")
                {
                    switch (choiceMenu1)
                    {
                        case "1":
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
                                string choiceMenu2;
                                choiceMenu2 = Console.ReadLine();
                                if (Regex.IsMatch(choiceMenu2, "[0-9]") && choiceMenu2 != "0")
                                {
                                    switch (choiceMenu2)
                                    {
                                        case "1":
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
                                                string choiceMenu3;
                                                choiceMenu3 = Console.ReadLine();
                                                if (Regex.IsMatch(choiceMenu3, "[0-9]") && choiceMenu3 != "0")
                                                {
                                                    switch (choiceMenu3)
                                                    {
                                                        case "1":
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
                                                        case "2":
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
                                                        case "3":
                                                            backToLevel2 = true;
                                                            break;
                                                        default:
                                                            invalidNotification();
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    invalidNotification();
                                                }
                                            }
                                            break;
                                        case "2":
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
                                                string choiceMenu3;
                                                choiceMenu3 = Console.ReadLine();
                                                if (Regex.IsMatch(choiceMenu3, "[0-9]") && choiceMenu3 != "0")
                                                {
                                                    switch (choiceMenu3)
                                                    {
                                                        case "1":
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
                                                        case "2":
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
                                                        case "3":
                                                            backToLevel2_1 = true;
                                                            break;
                                                        default:
                                                            invalidNotification();
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    invalidNotification();
                                                }
                                            }
                                            break;
                                        case "3":
                                            backToLevel1 = true;
                                            break;
                                        default:
                                            invalidNotification();
                                            break;
                                    }
                                }
                                else
                                {
                                    invalidNotification();
                                }
                            }
                            break;
                        case "2":
                             productList();
                            Console.ReadLine();
                            break;
                        case "3":
                            productList();
                            Console.WriteLine("Choose the product you want to edit:");
                            string choiceEdit;
                            choiceEdit = Console.ReadLine();


                            if (Regex.IsMatch(choiceEdit, "[0-9]") && choiceEdit != "0")
                            {
                                //logic choose the product list
                                bool PanChoice = false;
                                bool PotChoice = false;
                                // chose and choice
                                int choseEdit = (int.Parse(choiceEdit) - 1);
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
                                        string choiceEditItem;
                                        choiceEditItem = Console.ReadLine();
                                        if (Regex.IsMatch(choiceEditItem, "[0-9]") && choiceEditItem != "0")
                                        {
                                            switch (choiceEditItem)
                                            {
                                                case "1":
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
                                                        string kitchenToolEdit;
                                                        kitchenToolEdit = Console.ReadLine();
                                                        if (Regex.IsMatch(choiceEditItem, "[0-9]") && choiceEditItem != "0")
                                                        {
                                                            switch (kitchenToolEdit)
                                                            {
                                                                case "1":
                                                                    panList[editing].Size = "20cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "2":
                                                                    panList[editing].Size = "24cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "3":
                                                                    panList[editing].Size = "28cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "4":
                                                                    edit_size = true;
                                                                    break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            invalidNotification();
                                                        }
                                                    }
                                                    break;
                                                case "2":
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
                                                        string EditStatus;
                                                        EditStatus = Console.ReadLine();
                                                        if (Regex.IsMatch(EditStatus, "[0-9]") && EditStatus != "0")
                                                        {
                                                            switch (EditStatus)
                                                            {
                                                                case "1":
                                                                    panList[editing].Mass = "1Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "2":
                                                                    panList[editing].Mass = "1.5Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "3":
                                                                    panList[editing].Mass = "2.5Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "4":
                                                                    edit_status = true;
                                                                    break;
                                                            }
                                                        }
                                                    }
                                                    break;
                                                case "3":
                                                    edit_while = true;
                                                    break;
                                                default:
                                                    invalidNotification();
                                                    break;
                                            }
                                        }
                                        else
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
                                        string choiceEditItem;
                                        choiceEditItem = Console.ReadLine();
                                        if (Regex.IsMatch(choiceEditItem, "[0-9]") && choiceEditItem != "0")
                                        {
                                            switch (choiceEditItem)
                                            {
                                                case "1":
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
                                                        string kitchenToolEdit;
                                                        kitchenToolEdit = Console.ReadLine();
                                                        if (Regex.IsMatch(choiceEditItem, "[0-9]") && choiceEditItem != "0")
                                                        {
                                                            switch (kitchenToolEdit)
                                                            {
                                                                case "1":
                                                                    potList[editing].Size = "20cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "2":
                                                                    potList[editing].Size = "24cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "3":
                                                                    potList[editing].Size = "28cm";
                                                                    edit_size = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "4":
                                                                    edit_size = true;
                                                                    break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            invalidNotification();
                                                        }
                                                    }
                                                    break;
                                                case "2":
                                                    bool edit_status = false;
                                                    while (!edit_status)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|                  EDIT MASS                 |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("| 1. 1Kg                                     |");
                                                        Console.WriteLine("| 1. 1.5Kg                                   |");
                                                        Console.WriteLine("| 3. 2.5Kg                                   |");
                                                        Console.WriteLine("| 4. Back                                    |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Please choose one");
                                                        string EditStatus;
                                                        EditStatus = Console.ReadLine();
                                                        if (Regex.IsMatch(EditStatus, "[0-9]") && EditStatus != "0")
                                                        {
                                                            switch (EditStatus)
                                                            {
                                                                case "1":
                                                                    potList[editing].Mass = "1Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    Console.Clear();
                                                                    editNotification();
                                                                    break;
                                                                case "2":
                                                                    potList[editing].Mass = "1.5Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "3":
                                                                    potList[editing].Mass = "2.5Kg";
                                                                    edit_status = true;
                                                                    edit_while = true;
                                                                    editNotification();
                                                                    break;
                                                                case "4":
                                                                    edit_status = true;
                                                                    break;
                                                            }
                                                        }
                                                    }
                                                    break;
                                                case "3":
                                                    edit_while = true;
                                                    break;
                                                default:
                                                    invalidNotification();
                                                    break;
                                            }
                                        }
                                        else
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

                            break;
                        case "4":
                            productList();
                            Console.WriteLine("Choose the product you want to delete:");
                            string choiceDelete;
                            choiceDelete = Console.ReadLine();
                            if (Regex.IsMatch(choiceDelete, "[0-9]") && choiceDelete != "0")
                            {
                                bool PanChoice = false;
                                bool PotChoice = false;
                                // chose and choice
                                int choseEdit = (int.Parse(choiceDelete) - 1);
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
                            break;
                        case "5":
                            productList();
                            Console.WriteLine("Choose the product you want to test:");
                            string choiceTest;
                            choiceTest = Console.ReadLine();
                            if (Regex.IsMatch(choiceTest, "[0-9]") && choiceTest != "0")
                            {
                                bool PanChoice = false;
                                bool PotChoice = false;
                                // chose and choice
                                int choseEdit = (int.Parse(choiceTest) - 1);
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
                                            Console.WriteLine("| 3. Back                                    |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("");
                                            Console.WriteLine("Please choose one");
                                            string testing;
                                            testing = Console.ReadLine();
                                            if (Regex.IsMatch(testing, "[0-9]") && testing != "0")
                                            {
                                                switch (testing)
                                                {
                                                    case "1":
                                                        double firstTemperature;
                                                        double secondTemperature;
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|    Testing with Increase the temperature   |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("Input your first temperature: ");
                                                        firstTemperature = double.Parse(Console.ReadLine());
                                                        Console.WriteLine("Input your second temperature: ");
                                                        secondTemperature = double.Parse(Console.ReadLine());
                                                        Console.WriteLine("The time Increase the temperature with power is 600W: ");
                                                        Console.WriteLine(Math.Round(panList[editing].increaseTemperatrue(firstTemperature, secondTemperature)) + " second");
                                                        Console.ReadLine();
                                                        break;
                                                    case "2":
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|    Testing with Decrease the temperature   |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("Input your first temperature: ");
                                                        firstTemperature = double.Parse(Console.ReadLine());
                                                        Console.WriteLine("Input your second temperature: ");
                                                        secondTemperature = double.Parse(Console.ReadLine());
                                                        Console.WriteLine("The time decrease the temperature: ");
                                                        Console.WriteLine(Math.Round(panList[editing].decreaseTemperatrue(firstTemperature, secondTemperature)) + " second");
                                                        Console.ReadLine();
                                                        break;
                                                    case "3":
                                                        panTest = true;
                                                        break;
                                                    default:
                                                        invalidNotification();
                                                        break;
                                                }
                                            }
                                            else
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
                                            Console.WriteLine("| 3. Back                                    |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("");
                                            Console.WriteLine("Please choose one");
                                            string testing;
                                            testing = Console.ReadLine();
                                            if (Regex.IsMatch(testing, "[0-9]") && testing != "0")
                                            {
                                                switch (testing)
                                                {
                                                    case "1":
                                                        double firstTemperature;
                                                        double secondTemperature;
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|    Testing with Increase the temperature   |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("Input your first temperature: ");
                                                        firstTemperature = double.Parse(Console.ReadLine());
                                                        Console.WriteLine("Input your second temperature: ");
                                                        secondTemperature = double.Parse(Console.ReadLine());
                                                        Console.WriteLine("The time Increase the temperature with power is 600W: ");
                                                        Console.WriteLine(Math.Round(potList[editing].increaseTemperatrue(firstTemperature, secondTemperature)) + " second");
                                                        Console.ReadLine();
                                                        break;
                                                    case "2":
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|    Testing with Decrease the temperature   |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("Input your first temperature: ");
                                                        firstTemperature = double.Parse(Console.ReadLine());
                                                        Console.WriteLine("Input your second temperature: ");
                                                        secondTemperature = double.Parse(Console.ReadLine());
                                                        Console.WriteLine("The time to decrese the temperature: ");
                                                        Console.WriteLine(Math.Round(potList[editing].decreaseTemperatrue(firstTemperature, secondTemperature)) + " second");
                                                        Console.ReadLine();
                                                        break;
                                                    case "3":
                                                        potTest = true;
                                                        break;
                                                    default:
                                                        invalidNotification();
                                                        break;
                                                }
                                            }
                                            else
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
                            break;
                        case "6":
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
                else
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
        }
    }
}
