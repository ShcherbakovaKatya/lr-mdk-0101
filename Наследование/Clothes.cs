using System;


namespace Наследование
{
    public class Clothes : Product
    {
        public override int FindDiscount()
        {
            if (amount_ >= 5 && amount_ <= 10)
            {
                return 15;
            }

            if (amount_ > 10)
            {
                return 25;
            }

            return base.FindDiscount();
        }
    }
}
