using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG182_Project_2
{
    class Program
    {
        enum MainMenu
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
                MainMenu main =(MainMenu)option;
                switch (main)
                {
                    case MainMenu.Breakfast:
                        MenuChoice(option);
                        break;
                    case MainMenu.Burgers:
                        MenuChoice(option);
                        break;
                    case MainMenu.Pizza:
                        MenuChoice(option);
                        break;
                    case MainMenu.Kids:
                        MenuChoice(option);
                        break;
                    case MainMenu.Drinks:
                        MenuChoice(option);
                        break;
                    case MainMenu.Checkout: // After checkout , everything needs to reset.
                        break;
                    case MainMenu.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invaild entry");
                        break;
                }
            }
        }
        static int MenuChoice(int userChoice)
        {
            int choice = userChoice;

            return choice;
        }
    }
}