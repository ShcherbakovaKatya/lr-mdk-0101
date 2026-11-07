using System;


namespace Наследование
{
    public class Clothes : Product
    {
        public override int FindDiscount()
        {
            int discount = 0;

            if (amount_ >= 5 && amount_ <= 10)
            {
                discount = 15;
            }

            if (amount_ > 10)
            {
                discount = 25;
            }

            return discount;
        }
    }
}
