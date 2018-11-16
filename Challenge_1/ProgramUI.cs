using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class ProgramUI
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
                        PrintMenu();
                        break;
                    case 3:
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
            MenuContent newContent = new MenuContent();
            Console.WriteLine("What number do you wish to assign This meal?");
            newContent.MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the name of this meal?");
            newContent.MealName = Console.ReadLine();

            Console.WriteLine("\nPlease provide a description of the meal");
            newContent.Description = Console.ReadLine();

            Console.WriteLine("\nPLease add a list of ingredients used in the dish.");
            newContent.Ingredients = AddIngredients();
            
        }
        public void AddIngredients()
        {
            Ingredients newItem = new Ingredients();
        }
            
    }
}
