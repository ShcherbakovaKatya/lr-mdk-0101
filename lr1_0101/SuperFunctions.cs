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
            double result = 150;
            if (cost >= 2000)
            {
                return 0;
            }

            if (distance > 3)
            {
                result = 150 + ((distance - 3) * 50);
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
