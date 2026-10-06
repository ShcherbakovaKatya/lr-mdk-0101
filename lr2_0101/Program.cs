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
            Menu borsch = CreateDish(1, "борщ", 85, 30);
            Menu cutlet = CreateDish(2, "котлета", 240, 25);
            Menu mash = CreateDish(3, "пюре", 60, 35);
            Menu compote = CreateDish(4, "компот", 45, 40);
            Menu salat = CreateDish(5, "салат", 120, 18);

            List<Menu> menus = new List<Menu>() { borsch, cutlet, mash, compote, salat };

            Print(menus);

            Dictionary<string, int> order = GetDish(menus);

            PrintFinalStock(menus);

            Console.ReadKey();
        }

        static Menu CreateDish(int id, string name, int price, int amount)
        {
            return new Menu() { id_ = id, name_ = name, price_ = price, amount_ = amount };
        }

        static void Print(List<Menu> menus)
        {
            foreach (Menu menu in menus)
                Console.WriteLine($"{menu.id_}. {menu.name_} - {menu.price_} руб., {menu.amount_} порц.");
        }

        static Dictionary<string, int> GetDish(List<Menu> menus)
        {
            Dictionary<string, int> order = new Dictionary<string, int>();

            while (true)
            {
                Console.Write("Введите номер блюда (0 — конец заказа): ");
                if (int.TryParse(Console.ReadLine(), out int num) && num <= 5)
                {
                    if (num == 0) break;

                    Menu selected = null;
                    foreach (Menu dish in menus)
                        if (dish.id_ == num)
                        {
                            selected = dish;
                            break;
                        }

                    Console.Write("Введите количество: ");
                    if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
                    {
                        Console.WriteLine("Некорректное количество.");
                    }

                    if (selected.amount_ < quantity)
                    {
                        Console.WriteLine("У нас нет столько порций!");
                    }

                    selected.amount_ -= quantity;

                    order[selected.name_] = quantity;
                }
                else Console.WriteLine("Блюда с таким номером не существует.");
            }

            return order;
        }

        static void PrintFinalStock(List<Menu> menu)
        {
            Console.Write("Остатки порций: ");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.Write($"{menu[i].name_} {menu[i].amount_}");
                if (i < menu.Count - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}