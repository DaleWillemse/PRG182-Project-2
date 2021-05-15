// Dale Willemse
// Albrecht Ohsiek

using System;
using System.Collections.Generic;

namespace PRG182_Project_2
{
    public class Cart
    {
        public List<string> name_item = new List<string>();
        public List<float> price_item = new List<float>();
    }

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

        public int runningTotal = 0; // Running total of order.
          
        static void Main(string[] args)
        {
        
            Cart order = new Cart();  // newCart initialized from class
            // Clears order sheet           
            cart_clear(order);

            // variables
            string name_item = null;
            float cost_item = 0f;


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

        static void cart_add(Cart order, string name_item, float cost_item)
        {
            order.name_item.Add(name_item);
            order.price_item.Add(cost_item);
        }

        static void cart_clear(Cart order)
        {
            order.name_item.Clear();
            order.price_item.Clear();
        }

        static void cart_view(Cart order)
        {
            int length_order = order.name_item.Count;

            Console.WriteLine("\n-------- Order --------");

            // Displays items in order
            for (int i = 0; i < length_order; i++)
            {
                Console.WriteLine("{0} \t {1}", order.name_item[i], order.price_item[i]);
            }

        }

    }
}