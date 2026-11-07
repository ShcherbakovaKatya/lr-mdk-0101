using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Program
    {
        static void Main(string[] args)
        {

            Product jeans = Functions.CreateClothes("Джинсы", 3300, 7);
            Product shirt = Functions.CreateClothes("Рубашка", 1200, 11);
            Product bread = Functions.CreateFood("Хлеб", 80, 21);
            Product milk = Functions.CreateFood("Молоко", 140, 160);
            Product eggs = Functions.CreateFood("Яйца", 110, 302);
            Product soap = Functions.CreateProduct("Мыло", 200, 3);

            List<Product> products = new List<Product>();
            products.Add(jeans);
            products.Add(shirt);
            products.Add(bread);
            products.Add(milk);
            products.Add(eggs);
            products.Add(soap);

            foreach (Product item in products)
            {
                double summ = item.GetPrice() * item.GetAmount();
                double summDiscount = summ - summ * item.FindDiscount() / 100;
                Console.WriteLine($"Название товара: {item.GetName()}. Цена за единицу: {item.GetPrice()}. Колличество проданного: {item.GetAmount()}. {item.FindDiscount()}% скидка на товар. Сумма без скидки {summ}. С учетом скидки {summDiscount}");


            }
            
        }
    }
}
