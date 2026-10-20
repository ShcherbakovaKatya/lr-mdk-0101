using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3_0101
{
    internal class Function
    {
        public static List<Dish> CreateMenu()
        {
            List<Dish> menu = new List<Dish>();
            menu.Add(new Dish(1, "борщ", 85, 30));
            menu.Add(new Dish(2, "котлета", 240, 25));
            menu.Add(new Dish(3, "пюре", 60, 35));
            menu.Add(new Dish(4, "компот", 45, 40));
            menu.Add(new Dish(5, "салат", 120, 18));
            return menu;
        }

        public static void Print(List<Dish> menu)
        {
            foreach (Dish dish in menu)
                Console.WriteLine($"{dish.Id}. {dish.Name} - {dish.Price} руб., {dish.Amount} порц.");
        }
    }
}
