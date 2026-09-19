using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов в массиве: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];

            for (int i = 0; i<a; i++)
            {
                Console.WriteLine("Введите элемент массива: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int n in arr)
                Console.Write(n + " ");
        }
    }
}
