using System;


namespace Наследование
{
    class Functions
    {
        static public Product CreateProduct(string name, double price, int amount, string type)
        {
            Product item = new Product();
            if (type == "Food")
                item = new Food();
            if (type == "Clothes")
                item = new Clothes();
            item.SetName(name);
            item.SetPrice(price);
            item.SetAmount(amount);

            return item;
        }
    }
}
