using _01_Komodo_Cafe.Respository;
using Komodo_Cafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe.UI
{
    public class ProgramUI
    {
        private readonly MenuItemRepository _menu = new MenuItemRepository();
        public void Run()
        {
            SeedContent();
            ShowMenu();
        }


        private void ShowMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "Please make a selection:\n" +
                    "1.Display Menu\n" +
                    "2.Add a menu item\n" +
                    "3.Remove a menu item\n");
                string userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        DisplayAllMenu();
                        break;
                    case "2":
                        AddNewMenuItem();
                        break;
                    case "3":
                        DeleteMenuItem();
                        break;
                    default:
                        Console.WriteLine("Please make a valid selection.");
                        WaitForKeyPress();
                        break;
                }

            }
        }

        private void DisplayAllMenu()
        {
            Console.Clear ();
            Console.WriteLine("All menu items:");
            List<Menu> mainmenu = _menu.GetAllContents();
            foreach (Menu item in mainmenu)
            {
                DisplayMenuListItem(item);
            }
            WaitForKeyPress();
        }
        private void DisplayMenuListItem(Menu menu)
        {
            Console.WriteLine
                (
                $"{menu.MealNumber}\n" +
                $"{ menu.MealName}\n " +
                $"{ menu.Description}\n" +
                $"{menu.IngredientList}\n" +
                $"{menu.Price}\n" +
                $"____________________________");
        }
        private void AddNewMenuItem()
        {
            Console.Clear();
            Menu menu = new Menu();
            Console.WriteLine("Please enter the new meal number: ");
            int mealNumber = Convert.ToInt32(Console.ReadLine());
            menu.MealNumber = mealNumber;

            Console.WriteLine("Please enter the meal name: ");
            string mealName = Console.ReadLine();
            menu.MealName = mealName;

            Console.WriteLine("Please enter the meal description: ");
            string description = Console.ReadLine();
            menu.Description = description;

            Console.WriteLine("Please enter the ingredient list: ");
            string ingredients = Console.ReadLine();
            menu.IngredientList = ingredients;

            Console.WriteLine("Lastly, please enter the price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            menu.Price = price;

            _menu.AddMenuItem(menu);
            Console.WriteLine("Meal Added!");
            WaitForKeyPress();
        }

        private void DeleteMenuItem()
        {
            Console.Clear();
            Console.WriteLine("Which menu item would you like to delete?");

            int index = 0;
            List<Menu> list = _menu.GetAllContents();
            foreach (Menu item in list)
            {
                Console.WriteLine($"{index + 1}.");
                DisplayMenuListItem(item);
                index++;
            }
            string optionString = Console.ReadLine();
            int option = Convert.ToInt32(optionString);
            Menu itemToDelete = list[option - 1];

            Console.WriteLine("Are you sure you want to delete this menu item? (y/n)");
            DisplayMenuListItem(itemToDelete);
            if (Console.ReadLine() == "y")
            {
                _menu.DeleteMenuItem(itemToDelete);
                Console.WriteLine("Menu item deleted!");
            }
            else
            {
                Console.WriteLine("Canceled");
            }
            WaitForKeyPress();

        }

        private void WaitForKeyPress()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void SeedContent()
        {
            Menu burger = new Menu();
            burger.MealNumber = 1;
            burger.MealName ="Burger";
            burger.Description ="Yummy Hamburger with pickles";
            burger.IngredientList ="Burger, pickles";
            burger.Price = 5.99;
            _menu.AddMenuItem(burger);

            Menu fries = new Menu();
            fries.MealNumber = 2;
            fries.MealName ="Fries";
            fries.Description ="Yummy Salted Fries";
            fries.IngredientList ="Potatoes, Salt";
            fries.Price = 3.99;
            _menu.AddMenuItem(fries);

        }
    }
}
