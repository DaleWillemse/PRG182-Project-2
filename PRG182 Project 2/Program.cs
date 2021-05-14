using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG182_Project_2
{
    class Program
    {
        enum mainMenu
        {
            Breakfast = 1,
            Burgers,
            Pizza,
            Kids,
            Drinks,
            Checkout,
            Exit
        }

        public List<string> order = new List<string>(); // Stores current order.
        public int runningTotal = 0; // Running total of order.
          
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("1. Breakfast \n2. Burgers \n3. Pizza \n4. Kids\n5. Drinks \n6. Checkout\n7. Exit");
                int option = int.Parse(Console.ReadLine());
                mainMenu main =(mainMenu)option;
                switch (main)
                {
                    case mainMenu.Breakfast:
                        menuChoice(option);
                        break;
                    case mainMenu.Burgers:
                        menuChoice(option);
                        break;
                    case mainMenu.Pizza:
                        menuChoice(option);
                        break;
                    case mainMenu.Kids:
                        menuChoice(option);
                        break;
                    case mainMenu.Drinks:
                        menuChoice(option);
                        break;
                    case mainMenu.Checkout: // After checkout , everything needs to reset.
                        break;
                    case mainMenu.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invaild entry");
                        break;
                }
            }
        }
        static int menuChoice(int userChoice)
        {
            int choice = userChoice;

            return choice;
        }
    }
}