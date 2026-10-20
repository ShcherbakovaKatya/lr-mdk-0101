using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lr2_0101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dish> menu = CreateMenu();

            Print(menu);

            Dictionary<string, int> order = GetDish(menu);

            Console.WriteLine($"Стоимость заказа: {CalculateTotal(order, menu)} руб.");
            PrintFinalStock(menu);

            Console.ReadKey();
        }

        public static List<Dish> CreateMenu()
        {
            Dish borsch = new Dish() { id_ = 1, name_ = "борщ", price_ = 85, amount_ = 30 };
            Dish cutlet = new Dish() { id_ = 2, name_ = "котлета", price_ = 240, amount_ = 25 };
            Dish mash = new Dish() { id_ = 3, name_ = "пюре", price_ = 60, amount_ = 35 };
            Dish compote = new Dish() { id_ = 4, name_ = "компот", price_ = 45, amount_ = 40 };
            Dish salat = new Dish() { id_ = 5, name_ = "салат", price_ = 120, amount_ = 18 };

            List<Dish> menu = new List<Dish>() { borsch, cutlet, mash, compote, salat };
            return menu;
        }

        static void Print(List<Dish> menu)
        {
            foreach (Dish dish in menu)
                Console.WriteLine($"{dish.id_}. {dish.name_} - {dish.price_} руб., {dish.amount_} порц.");
        }

        static Dictionary<string, int> GetDish(List<Dish> menu)
        {
            Dictionary<string, int> order = new Dictionary<string, int>();

            while (true)
            {
                Console.Write("Введите номер блюда (0 — конец заказа): ");
                if (int.TryParse(Console.ReadLine(), out int num) && num <= 5)
                {
                    if (num == 0) break;

                    Dish selected = null;
                    foreach (Dish dish in menu)
                        if (dish.id_ == num)
                        {
                            selected = dish;
                            break;
                        }

                    Console.Write("Введите количество: ");
                    if (int.TryParse(Console.ReadLine(), out int quantity) || quantity > 0)
                    {
                        if (quantity <= selected.amount_)
                        {
                            order[selected.name_] = quantity;
                            Console.WriteLine("Добавлено в заказ");
                            selected.amount_ -= quantity;
                        }
                        else Console.WriteLine("У нас нет столько порций!");
                    }


                }
                else Console.WriteLine("Блюда с таким номером не существует.");
            }

            return order;
        }

        static void PrintFinalStock(List<Dish> menu)
        {
            Console.Write("Остатки порций: ");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.Write($"{menu[i].name_} {menu[i].amount_}");
                if (i < menu.Count - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }

        static int CalculateTotal(Dictionary<string, int> order, List<Dish> menu)
        {
            int total = 0;
            foreach (var item in order)
            {
                foreach (var dish in menu)
                {
                    if (dish.name_ == item.Key)
                    {
                        total += dish.price_ * item.Value;
                        break;
                    }
                }
            }
            return total;
        }
    }
}