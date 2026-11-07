using System;


namespace Наследование
{
    class Functions
    {
        static public Product CreateProduct(string name, double price, int amount)
        {
            Product item = new Product();

            item.SetName(name);
            item.SetPrice(price);
            item.SetAmount(amount);

            return item;
        }
        static public Product CreateFood(string name, double price, int amount)
        {
            Product item = new Product();
            item = new Food();
            item.SetName(name);
            item.SetPrice(price);
            item.SetAmount(amount);

            return item;
        }
        static public Product CreateClothes(string name, double price, int amount)
        {
            Product item = new Product();
            item = new Clothes();
            item.SetName(name);
            item.SetPrice(price);
            item.SetAmount(amount);

            return item;
        }
    }
}
