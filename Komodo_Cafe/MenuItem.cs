using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Komodo_Cafe.Respository
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string IngredientList { get; set; }
        public double Price { get; set; }
        
        public List<Menu> MenuList;

        public Menu()
        {
        }

        public Menu
            (
            int mealNumber,
            string mealName,
            string description,
            string ingredientList,
            double price
            )
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            IngredientList = ingredientList;
            Price = price;
        }

    }

}

