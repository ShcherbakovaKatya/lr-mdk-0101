using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr1_0101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость заказа (руб.):");
            int cost = SuperFunctions.Input();
            Console.WriteLine("Введите расстояние доставки (км): ");
            int distance = SuperFunctions.Input();
            Console.WriteLine("Введите время заказа (час): ");
            int time = SuperFunctions.Input();

            Console.WriteLine($"Стоимость доставки: {SuperFunctions.DeliveryCost(cost, distance, time)} руб.");
            Console.WriteLine($"Итого к оплате: {SuperFunctions.AllCost(cost, SuperFunctions.DeliveryCost(cost, distance, time))} руб.");
        }
    }
}
