using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class MenuRepository
    {
        List<MenuContent> _listOfMenuItems = new List<MenuContent>();


        public void AddItemToMenu(MenuContent content)
        {
            _listOfMenuItems.Add(content);
        }
        public List<MenuContent> GetMenuItems()
        {
            return _listOfMenuItems;
        }
        public void RemoveItemFromList(MenuContent content)
        {
            _listOfMenuItems.Remove(content);
        }
    }
}
