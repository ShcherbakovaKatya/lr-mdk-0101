using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

            double deliverycost = SuperFunctions.DeliveryCost(cost, distance, time);
            double extratime = SuperFunctions.ExtraTime(time, deliverycost);

            Console.WriteLine($"Стоимость доставки: {deliverycost + extratime} руб.");
            Console.WriteLine($"Итого к оплате: {SuperFunctions.AllCost(cost, deliverycost, extratime)} руб.");
        }
    }
}
