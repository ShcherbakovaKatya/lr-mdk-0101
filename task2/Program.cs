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
            int[] arr = Functions.CreateArr();
            Functions.FillArr(arr);
            int max = arr.Max();
            int maxIndex = Array.IndexOf(arr, arr.Max());
            Console.Write($"Максимальное число в массиве - {max}. Его индекс - {maxIndex}");
        }
    }
}
