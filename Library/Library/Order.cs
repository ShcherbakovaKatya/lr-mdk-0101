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

    }
}
