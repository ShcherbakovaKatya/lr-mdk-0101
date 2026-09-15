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
            int a = SuperFunctions.Input();
            int b = SuperFunctions.Input2();
            int c = SuperFunctions.Input3();
            Console.WriteLine($"Стоимость доставки: {SuperFunctions.DeliveryCost(a, b, c)} руб.");
        }
    }
}
