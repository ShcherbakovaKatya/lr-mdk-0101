using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr1_0101
{
    class SuperFunctions
    {
        public static int Input()
        {
            while (true)
            {
                string a = Console.ReadLine();
                bool isValid1 = int.TryParse(a, out int number) && number > 0;
                if (isValid1)
                {
                    return number;
                }
                else
                {
                    Console.Write("Ошибка попробуй еще раз");
                }
            }

        }

        public static double DeliveryCost(int cost, int distance, int time)
        {
            double result = 0;
            if (cost < 2000)
            {
                if (distance < 3)
                {
                    result = 150;
                }
                else
                {
                    result = 150 + ((distance - 3) * 50);
                }
                if (time == 12 || time == 13 || time == 14 || time == 18 || time == 19 || time == 20)
                {
                    result = result + result * 0.3;
                }
            }
            else
            {
                result = 0;
            }
            return result;
        }
        public static double AllCost(int cost,double deliverycost)
        {
            double result = cost + deliverycost;
            return result;
        }
    }
}
