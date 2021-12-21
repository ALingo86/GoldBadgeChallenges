using _01_Komodo_Cafe.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe
{
    public class MenuItemRepository
    {
        protected readonly List<Menu> _menu = new List<Menu>();
        //create
        public bool AddMenuItem(Menu menu)

        {
            int startingCount = _menu.Count;
            _menu.Add(menu);
            bool wasAdded = (_menu.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //read

        public List<Menu> GetAllContents()
        {
            return _menu;
        }




        //update - **Not needed**



        //delete

        public bool DeleteMenuItem(Menu menu)
        {
            bool deleteResult = _menu.Remove(menu);
            return deleteResult;
        }
    }
}
