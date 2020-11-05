using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class Beverage_SoftDrink : MenuItem
    {

        public override string PrintInfo()
        {   // Denne metode printer formateret ud.
            return
                $"Number {Number} \tName {Name} \n\tDescription {Description} Price {Price} MenuType {Type} IsVegan {IsVegan} IsOrganic {IsOrganic}";
        }

        public Beverage_SoftDrink(int number, string name, string description, double price, bool isVegan, bool isOrganic) 
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = MenuType.SoftDrink;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
        }
    
    }
}
