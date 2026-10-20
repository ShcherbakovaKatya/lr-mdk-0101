using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lr3_0101.Ordering;

namespace lr3_0101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dish> menu = Function.CreateMenu();

            Function.Print(menu);

            Order order = Function.GetOrder(menu);
            OrderStatus status = Function.CheckStock(order);

            if (status == OrderStatus.Success)
            {
                Function.ApplyOrder(order);
                Console.WriteLine($"Стоимость заказа: {order.CalculateTotal()} руб.");
            }
            Function.PrintFinalStock(menu);
        }
    }
}
