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
                Console.Write("Введите стоимость заказа (руб.):");
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

        public static int Input2()
        {
            while (true)
            {
                Console.Write("Введите расстояние доставки (км): ");
                string a = Console.ReadLine();
                bool isValid = int.TryParse(a, out int number) && number > 0;
                if (isValid)
                {
                    return number;
                }
                else
                {
                    Console.Write("Ошибка попробуй еще раз");
                }
            }
        }
        public static int Input3()
        {
            while (true)
            {
                Console.Write("Введите время заказа (час): ");
                string a = Console.ReadLine();
                bool isValid = int.TryParse(a, out int number) && number > 0;
                if (isValid)
                {
                    return number;
                }
                else
                {
                    Console.Write("Ошибка попробуй еще раз");
                }
            }
        }
        public static double DeliveryCost(int a, int b, int c)
        {
            double amount = 0;
            double result = 0;
            if (a < 2000)
            {
                if (b < 3)
                {
                    result = 150;
                }
                else
                {
                    result = 150 + ((b - 3) * 50);
                }
                if (c == 12 || c == 13 || c == 14 || c == 18 || c == 19 || c == 20)
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
        
    }
}
