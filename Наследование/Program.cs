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
            Product jeans = new Product();
            jeans = new Clothes();
            jeans.SetName("Джинсы");
            jeans.SetPrice(3300);
            jeans.SetAmount(7);

            Product shirt = new Product();
            shirt = new Clothes();
            shirt.SetName("Рубашка");
            shirt.SetPrice(1200);
            shirt.SetAmount(11);

            Product bread = new Product();
            bread = new Food();
            bread.SetName("Хлеб");
            bread.SetPrice(80);
            bread.SetAmount(21);

            Product milk = new Product();
            milk = new Food();
            milk.SetName("Молоко");
            milk.SetPrice(140);
            milk.SetAmount(160);

            Product eggs = new Product();
            eggs = new Food();
            eggs.SetName("Яйца");
            eggs.SetPrice(110);
            eggs.SetAmount(302);

            Product soap = new Product();
            soap.SetName("Мыло");
            soap.SetPrice(200);
            soap.SetAmount(3);

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
