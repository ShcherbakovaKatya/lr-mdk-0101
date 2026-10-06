using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2_0101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu borsch = CreateDish(1,"борщ", 85, 30);
            Menu cutlet = CreateDish(2, "котлета", 240, 25);
            Menu mash = CreateDish(3, "пюре", 60, 35);
            Menu compote = CreateDish(4, "компот", 45, 40);
            Menu salat = CreateDish(5, "салат", 120, 18);
            List <Menu> menus = new List<Menu>() { borsch, cutlet, mash, compote, salat};
        }
        static Menu CreateDish(int id, string name, int price, int amount)
        {
            Menu Dish = new Menu() { id_ = id, name_ = name, price_ = price, amount_ = amount };
            return Dish;
        }




    }
}
