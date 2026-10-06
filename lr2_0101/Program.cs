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
            Print(menus);
            GetDish(menus);
        }
        static Menu CreateDish(int id, string name, int price, int amount)
        {
            Menu Dish = new Menu() { id_ = id, name_ = name, price_ = price, amount_ = amount };
            return Dish;
        }
        static void Print(List<Menu> menus)
        {
            foreach (Menu menu in menus)
                Console.WriteLine($"{menu.id_}. {menu.name_} - {menu.price_} руб., {menu.amount_} порц.");
        }
        static List<Menu> GetDish(List<Menu> menus)
        {
            List<Menu> Order = new List<Menu>();
            
            while(true)
            {
                Console.Write("Введите номер блюда (0 — конец заказа):");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num > 5)
                    {
                        Console.WriteLine("Ошибка введите еще раз");
                    }
                    else 
                    {
                        if (num == 0) break;
                        Console.Write("Введите количество:");
                        int b = Convert.ToInt32(Console.ReadLine());

                        foreach (Menu dish in menus)
                            if (dish.id_ == num && dish.amount_ >= b)
                            {
                                Order.Add(dish);
                            }
                    }
                }
               
            }
            return Order;
        }
    }
}
