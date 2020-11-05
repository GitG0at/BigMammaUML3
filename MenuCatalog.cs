using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    
   
    public class MenuCatalog : IMenuCatalog
    {
        private List<IMenuItem> Items;
        public int Count
        {
            get { return Items.Count; }
        }
        public MenuCatalog()
        {
            Items = new List<IMenuItem>();
        }
        public void Add(IMenuItem aMenuItems)
        {
            Items.Add(aMenuItems);
        }

        public void Delete(int number)
        {
            IMenuItem MI = Search(number);
            if (MI == null) return;
            Items.Remove(MI);
        }
        public void Delete(IMenuItem aMenuItems)
        {
            Items.Remove(aMenuItems);
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {

            List<IMenuItem> _items = new List<IMenuItem>();

            foreach (IMenuItem item in Items)
            {
                if (item.IsOrganic && item.Type == type)
                    _items.Add(item);
            }

            return _items;
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> _items = new List<IMenuItem>();

            foreach (IMenuItem item in Items)
            {
                if (item.IsVegan && item.Type == type)
                    _items.Add(item);
            }

            return _items;
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            if (Items.Count < 1) return null;
            IMenuItem _item = Items[0];
            foreach (IMenuItem item in Items)
            {
                if (item.Price > _item.Price)
                    _item = item;
            }

            return _item;
        }

        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem item in Items)
            {
                if (item.Type == MenuType.AlcoholicDrink || item.Type == MenuType.SoftDrink)
                    Console.WriteLine(item.PrintInfo());
            }
        }

        public void PrintPizzasMenu()
        {
            foreach (IMenuItem item in Items)
            {
                if (item.Type == MenuType.Pizza )
                    Console.WriteLine(item.PrintInfo());
            }
        }

        public void PrintToppingsMenu()
        {
            foreach (IMenuItem item in Items)
            {
                if (item.Type == MenuType.Topping)
                    Console.WriteLine(item.PrintInfo());
            }
        }

        public IMenuItem Search(int number)
        {
            foreach (IMenuItem item in Items)
            {
                if (item.Number == number)
                    return item;
            }
            return null;
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            IMenuItem _item = Search(number);
            if (_item == null)
                return;

            _item.Name = theMenuItem.Name;
            _item.Price = theMenuItem.Price;
            _item.IsOrganic = theMenuItem.IsOrganic;
            _item.IsVegan = theMenuItem.IsVegan;
            _item.Description = theMenuItem.Description;
            _item.Type = theMenuItem.Type;
        }
 
        public bool SortGroupTo(MenuType mType, int Startnumber, SortType isOrganic = SortType.maybe, SortType isVegan = SortType.maybe)
        {
            if (Startnumber >= Count)
                return false;

            bool succses = false;
            List<IMenuItem> _items = new List<IMenuItem>();
            int cnt = Startnumber;
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].IsVegan && isVegan == SortType.no)
                    continue;
                if (_items[i].IsOrganic && isOrganic == SortType.no)
                    continue;

                if (_items[i].Type != mType )
                    continue;

                _items[i].Number = cnt++;
                succses = true;
            }
           

            return succses;
        }
    }
}
