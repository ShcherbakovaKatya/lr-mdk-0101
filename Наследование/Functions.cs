using System;


namespace Наследование
{
    class Functions
    {
        static public Product CreateProduct(string name, double price, int amount, TypeProduct type)
        {
            Product item = new Product();
            if (type == TypeProduct.Food)
                item = new Food();
            if (type == TypeProduct.Clothes)
                item = new Clothes();
            item.SetName(name);
            item.SetPrice(price);
            item.SetAmount(amount);

            return item;
        }
    }
}
