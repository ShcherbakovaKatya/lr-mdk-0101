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

            Product jeans = Functions.CreateProduct("Джинсы", 3300, 7, TypeProduct.Clothes);
            Product shirt = Functions.CreateProduct("Рубашка", 1200, 11, TypeProduct.Clothes);
            Product bread = Functions.CreateProduct("Хлеб", 80, 21, TypeProduct.Food);
            Product milk = Functions.CreateProduct("Молоко", 140, 160, TypeProduct.Food);
            Product eggs = Functions.CreateProduct("Яйца", 110, 302, TypeProduct.Food);
            Product soap = Functions.CreateProduct("Мыло", 200, 3, TypeProduct.None);

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
