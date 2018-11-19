using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class ProgramUI
    {
        MenuRepository _menuRepo = new MenuRepository();

        public void Run()
        {
            RunHomePage();
        }

        public void RunHomePage()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome To Komodo Kafe Menu Editor. Please choose and action:" +
                    "\n1. Add Items to Menu" +
                    "\n2. See Current Menu" +
                    "\n3. Remove Items from Menu" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddItemsToMenu();
                        break;
                    case 2:
                        Console.Clear();
                        PrintMenu();
                        Console.ReadLine();
                        break;
                    case 3:
                        RemoveItemsFromMenu();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Thanks! See You Soon!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("I'm sorry, that is not a valid choice.");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void AddItemsToMenu()
        {
            Console.Clear();
            MenuContent newContent = new MenuContent();
            Console.WriteLine("What number do you wish to assign This meal?");
            newContent.MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the name of this meal?");
            newContent.MealName = Console.ReadLine();

            Console.WriteLine("\nPlease provide a description of the meal");
            newContent.Description = Console.ReadLine();

            Console.WriteLine("\nPLease add a list of ingredients used in the dish.");
            newContent.Ingredients = Console.ReadLine();

            _menuRepo.AddItemToMenu(newContent);
        }
        public void PrintMenu()
        {
            List<MenuContent> menuList = _menuRepo.GetMenuItems();
            foreach (MenuContent menuContent in menuList)
            {
                Console.WriteLine($"Meal #: {menuContent.MealNumber}" +
                    $"\nMeal Name: {menuContent.MealName}" +
                    $"\nDescription:{menuContent.Description}" +
                    $"\nIngredients: {menuContent.Ingredients}");
            }

        }
        public void RemoveItemsFromMenu()
        {
            List<MenuContent> menu = _menuRepo.GetMenuItems();

            int meal;

            Console.WriteLine("Please Enter The Meal Number of the Meal you'd like deleted");
            bool isMeal = int.TryParse(Console.ReadLine(), out meal);
            if (isMeal)
            {
                foreach (MenuContent content in menu.ToList())
                {
                    if (meal == content.MealNumber)
                    {
                        _menuRepo.RemoveItemFromList(content);
                    }

                }
            }

        }

    }
}
