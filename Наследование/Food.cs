using System;


namespace Наследование
{
    public class Food : Product
    {
        public override int FindDiscount()
        {
            int discount = 0;

            if (amount_ >= 20 && amount_ <= 150)
            {
                discount += 10;
            }
            if (amount_ >= 150 && amount_ <= 300)
            {
                discount += 30;
            }
            if (amount_ > 300)
            {
                discount += 50;
            }

            return discount;
        }
    }
}
