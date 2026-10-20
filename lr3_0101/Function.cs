using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lr3_0101.Ordering;

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

        public static int ReadNumber(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                int value;
                if (int.TryParse(input, out value) && value >= min && value <= max)
                    return value;
                Console.WriteLine("Ошибка ввода. Повторите попытку.");
            }
        }

        public static Order GetOrder(List<Dish> menu)
        {
            Order order = new Order();

            while (true)
            {
                int id = ReadNumber("Введите номер блюда (0 — конец заказа): ", 0, 5);
                if (id == 0)
                    break;

                int quantity = ReadNumber("Введите количество: ", 0, 10000000);
                Dish dish = menu[id - 1];
                order.AddDish(dish, quantity);
            }
            return order;
        }
    }
}
