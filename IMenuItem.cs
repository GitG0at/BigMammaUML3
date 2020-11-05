using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
   
    public enum SortType { yes, no, maybe}
    public enum MenuType { Pizza, Pasta, Topping, SoftDrink, AlcoholicDrink }
    public interface IMenuItem
    {
        int Number { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        MenuType Type { get; set; }
        bool IsVegan { get; set; }
        bool IsOrganic { get; set; }
        string PrintInfo();
    }

}
