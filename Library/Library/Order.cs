using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Order
    {
        public static List<PrintedEdition> GetOrder(List<PrintedEdition> list)
        {
            List<PrintedEdition> order = new List<PrintedEdition>();
            while (true)
            {
                Console.WriteLine("Введите название, чтобы добавить в заказ('Конец' - завершить заказ): ");
                string edition = Console.ReadLine();

                if (edition == "Конец") break;
                bool found = false;

                foreach (PrintedEdition item in list)
                {
                    if (item.GetName() == edition)
                    {
                        if (item.GetCount() > 0)
                        {
                            Console.WriteLine("Добавлено в заказ!");
                            item.SetCount(item.GetCount() - 1);
                            order.Add(item);
                        }
                        else
                        {
                            Console.WriteLine("Нет в наличии");
                        }
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("У нас нет такой книги");
                }

            }

            return order;
        }
        public static int GetDiscount(List<PrintedEdition> order)
        {
            int discount = 0;

            if ((order.Count(item => item.GetType() == "Журнал") >= 3)) discount = 15;

            if ((order.Count(item => item.GetType() == "Книга") >= 2) && (order.Count(item => item.GetType() == "Учебник") > 0)) discount = 50;

            return discount;
        }

        public static void PrintOrder(List<PrintedEdition> order)
        {
            Console.WriteLine("\nВАШ ЗАКАЗ:");
            foreach (PrintedEdition item in order)
                Console.WriteLine($"{item.GetType()}, {item.GetName()}, {item.GetYear()}, {item.GetAuthor()}");
            Console.WriteLine($"\nВаша скидка: {Order.GetDiscount(order)}%");

        }
    }
}
