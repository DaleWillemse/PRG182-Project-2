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
        // All enum menus used.
        enum MainMenu { Breakfast = 1, Burgers, Pizza, Kids, Drinks, Checkout, Exit }
        enum Breakfast { Breakfastspecial = 1, Hashbrownandeggs, Sundayspecial, Toast, Back }
        enum Burgers { Cheeseburger = 1, Baconburger, Chickenburger, Back }
        enum Pizza { Tikkachicken = 1, Pepperoni, Margarita, Back }
        enum Kids { Chips = 1, Sandwhich, Russians, Back }
        enum Drinks { Coke = 1, Fanta, Sprite, Water, Back }

        public int runningTotal = 0; // Running total of order.

        static void Main(string[] args)
        {

            Cart order = new Cart();  // new Cart initialized from class           
            cart_clear(order); // Clears order 

            bool exit = false;
            while (exit == false)
            {
                Console.Clear();
                Console.WriteLine("1. Breakfast \n2. Burgers \n3. Pizza \n4. Kids\n5. Drinks \n6. Checkout\n7. Exit");
                cart_view(order);
                int option = int.Parse(Console.ReadLine());
                MainMenu main = (MainMenu)option;
                switch (main)
                {
                    case MainMenu.Breakfast:
                        MenuChoice(order, option);
                        break;
                    case MainMenu.Burgers:
                        MenuChoice(order, option);
                        break;
                    case MainMenu.Pizza:
                        MenuChoice(order, option);
                        break;
                    case MainMenu.Kids:
                        MenuChoice(order, option);
                        break;
                    case MainMenu.Drinks:
                        MenuChoice(order, option);
                        break;
                    case MainMenu.Checkout: // After checkout , everything needs to reset.
                        Console.Clear();
                        cart_view(order);
                        Console.WriteLine("1. Add more\n2. Checkout");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            break;
                        }
                        else if (choice == 2)
                        {
                            cart_clear(order);
                            Console.Clear();
                            Console.WriteLine("Your order will be with you soon!");
                            Console.ReadKey();
                        }
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
        static void MenuChoice(Cart order, int userChoice)
        {
            bool exit = false;
            switch (userChoice)
            {
                case 1: // Breakfast menu.

                    while (exit == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Breakfast Menu");
                        Console.WriteLine("1. Breakfast Special\tR30\n2. Hashbrown and Eggs\tR25\n3. Sunday Special\tR35\n4. Toast\t\tR10\n5. Back");
                        int option = int.Parse(Console.ReadLine());
                        Breakfast choice = (Breakfast)option;
                        switch (choice)
                        {
                            case Breakfast.Breakfastspecial:
                                cart_add(order, "Breakfast Special", 30);
                                break;
                            case Breakfast.Hashbrownandeggs:
                                cart_add(order, "Hashbrown and Eggs", 25);
                                break;
                            case Breakfast.Sundayspecial:
                                cart_add(order, "Sunday Special", 35);
                                break;
                            case Breakfast.Toast:
                                cart_add(order, "Toast", 10);
                                break;
                            case Breakfast.Back:
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Invaild entry");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;
                case 2: // Burger menu.
                    while (exit == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Burger Menu");
                        Console.WriteLine("1. Cheeseburger\t\tR20\n2. Baconburger\t\tR25\n3. Chickenburger\tR10\n4. Back");
                        int option = int.Parse(Console.ReadLine());
                        Burgers choice = (Burgers)option;
                        switch (choice)
                        {
                            case Burgers.Cheeseburger:
                                cart_add(order, "Cheeseburger", 20);
                                break;
                            case Burgers.Baconburger:
                                cart_add(order, "Baconburger", 25);
                                break;
                            case Burgers.Chickenburger:
                                cart_add(order, "Chickenburger", 10);
                                break;
                            case Burgers.Back:
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Invaild entry");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;
                case 3: // Pizza menu.
                    while (exit == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Pizza Menu");
                        Console.WriteLine("1. Tikka Chicken\tR30\n2. Pepperoni\t\tR25\n3. Margarita\t\tR20\n4. Back ");
                        int option = int.Parse(Console.ReadLine());
                        Pizza choice = (Pizza)option;
                        switch (choice)
                        {
                            case Pizza.Tikkachicken:
                                cart_add(order, "Tikka Chicken", 30);
                                break;
                            case Pizza.Pepperoni:
                                cart_add(order, "Pepperoni", 25);
                                break;
                            case Pizza.Margarita:
                                cart_add(order, "Margarita", 20);
                                break;
                            case Pizza.Back:
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Invaild entry");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;
                case 4: // Kids menu.
                    while (exit == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Kids Menu");
                        Console.WriteLine("1. Chips\tR10\n2. Sandwhich\tR15\n3. Russians\tR10\n4. Back");
                        int option = int.Parse(Console.ReadLine());
                        Kids choice = (Kids)option;
                        switch (choice)
                        {
                            case Kids.Chips:
                                cart_add(order, "Chips", 10);
                                break;
                            case Kids.Sandwhich:
                                cart_add(order, "Sandwhich", 15);
                                break;
                            case Kids.Russians:
                                cart_add(order, "Russains", 10);
                                break;
                            case Kids.Back:
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Invaild entry");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;
                case 5: // Drinks menu.
                    while (exit == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Drinks Menu");
                        Console.WriteLine("1. Coke\t\tR5\n2. Fanta\tR5\n3. Sprite\tR5\n4. Water\tR10\n5. Back");
                        int option = int.Parse(Console.ReadLine());
                        Drinks choice = (Drinks)option;
                        switch (choice)
                        {
                            case Drinks.Coke:
                                cart_add(order, "Coke", 5);
                                break;
                            case Drinks.Fanta:
                                cart_add(order, "Fanta", 5);
                                break;
                            case Drinks.Sprite:
                                cart_add(order, "Sprite", 5);
                                break;
                            case Drinks.Water:
                                cart_add(order, "Water", 10);
                                break;
                            case Drinks.Back:
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Invaild entry");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;
            }
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
            float totalCost = 0f; // To keep track of total.

            Console.WriteLine("\n-------- Order --------");

            // Displays items in order
            for (int i = 0; i < length_order; i++)
            {
                Console.WriteLine("{0,-15} \t R{1}", order.name_item[i], order.price_item[i]);
                totalCost += order.price_item[i];
            }
            Console.WriteLine("\nTotal = R{0}", totalCost); // Display total. 
        }
    }
}       
