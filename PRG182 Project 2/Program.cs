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
        enum Menu { Breakfast = 1, Burgers, Pizza, Kids, Drinks, Checkout, Exit = 0 }
        enum Breakfast { Breakfastspecial = 1, Hashbrownandeggs, Sundayspecial, Toast, Back=0 }
        enum Burgers { Cheeseburger = 1, Baconburger, Chickenburger, Back=0 }
        enum Pizza { Tikkachicken = 1, Pepperoni, Margarita, Back=0 }
        enum Kids { Chips = 1, Sandwhich, Russians, Back=0 }
        enum Drinks { Coke = 1, Fanta, Sprite, Water, Back=0 }

        public int runningTotal = 0; // Running total of order.

        static void Main(string[] args)
        {

            Cart order = new Cart();  // new Cart initialized from class           
            cart_clear(order); // Clears order 

            menuMain(order);
            
        }

        public static void menuMain(Cart order)
        {
            bool exit = false;

            while (exit == false)
            {
                bool exit_sub_menu = false;
                while (exit_sub_menu != true)
                {
                    cart_view(order);
                    Console.WriteLine("\n1. Breakfast \n2. Burgers \n3. Pizza \n4. Kids\n5. Drinks \n6. Checkout\n0. Exit");

                    int option = int.Parse(Console.ReadLine());
                    Menu main = (Menu)option;
                    switch (main)
                    {
                        case Menu.Breakfast:
                            exit_sub_menu = menu_breakfast(order);
                            break;
                        case Menu.Burgers:
                            exit_sub_menu = menu_burger(order);
                            break;
                        case Menu.Pizza:
                            exit_sub_menu = menu_pizza(order);
                            break;
                        case Menu.Kids:
                            exit_sub_menu = menu_kids(order);
                            break;
                        case Menu.Drinks:
                            exit_sub_menu = menu_drinks(order);
                            break;
                        case Menu.Checkout: // After checkout , everything needs to reset.
                            cart_view(order);

                            Console.WriteLine("\n1. Continue Shopping\n2. Checkout");
                            int choice = int.Parse(Console.ReadLine());
                            if (choice == 1)
                            {
                                break;
                            }
                            else if (choice == 2)
                            {
                                cart_view(order);
                                Console.WriteLine("\nYour order will be with you soon!");
                                cart_clear(order);
                                Console.ReadKey();
                            }
                            break;
                        case Menu.Exit:
                            exit = true;
                            exit_sub_menu = true;
                            break;
                        default:
                            Console.WriteLine("Invaild entry");
                            break;
                    }
                }
            }
        }

        public static bool menu_breakfast(Cart order)
        {
            bool exit = false;

            while (exit == false)
            {
                cart_view(order);

                Console.WriteLine("Breakfast Menu");
                Console.WriteLine("\n1. Breakfast Special\tR30\n2. Hashbrown and Eggs\tR25\n3. Sunday Special\tR35\n4. Toast\t\tR10\n0. Back");
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
            return exit;
        }

        public static bool menu_burger(Cart order)
        {
            bool exit = false;

            while (exit == false)
            {
                cart_view(order);

                Console.WriteLine("Burger Menu");
                Console.WriteLine("\n1. Cheeseburger\t\tR20\n2. Baconburger\t\tR25\n3. Chickenburger\tR10\n0. Back");
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

            return exit;
        }

        public static bool menu_pizza(Cart order)
        {
            bool exit = false;

            while (exit == false)
            {
                cart_view(order);

                Console.WriteLine("Pizza Menu");
                Console.WriteLine("\n1. Tikka Chicken\tR30\n2. Pepperoni\t\tR25\n3. Margarita\t\tR20\n0. Back ");
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

            return exit;
        }

        public static bool menu_kids(Cart order)
        {
            bool exit = false;

            while (exit == false)
            {
                cart_view(order);

                Console.WriteLine("Kids Menu");
                Console.WriteLine("\n1. Chips\tR10\n2. Sandwhich\tR15\n3. Russians\tR10\n0. Back");
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

            return exit;
        }

        public static bool menu_drinks(Cart order)
        {
            bool exit = false;

            while (exit == false)
            {
                cart_view(order);

                Console.WriteLine("Drinks Menu");
                Console.WriteLine("\n1. Coke\t\tR5\n2. Fanta\tR5\n3. Sprite\tR5\n4. Water\tR10\n0. Back");
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

            return exit;
        }

        public static void cart_add(Cart order, string name_item, float cost_item)
        {
            order.name_item.Add(name_item);
            order.price_item.Add(cost_item);
        }

        public static void cart_clear(Cart order)
        {
            order.name_item.Clear();
            order.price_item.Clear();
        }

        public static void cart_view(Cart order)
        {
            Console.Clear();    // Clears console

            int length_order = order.name_item.Count;
            float totalCost = 0f; // To keep track of total.

            Console.WriteLine("----------- Order ----------");

            // Displays items in order
            for (int i = 0; i < length_order; i++)
            {
                Console.WriteLine("{0,-15} \t R{1}", order.name_item[i], order.price_item[i]);  //{0, -15} to allaign all the nembers and R = Rand
                totalCost += order.price_item[i];
            }
            Console.WriteLine("\nTotal = R{0}", totalCost); // Display total. 
            Console.WriteLine("----------------------------");
        }
    }
}
