using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Functions
    {
        public static int[] CreateArr()
        {
            Console.WriteLine("Сколько элементов в массиве: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            return arr;

        }
        public static int[] FillArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите элемент массива: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
    }
}
