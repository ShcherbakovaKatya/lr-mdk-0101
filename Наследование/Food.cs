using System;


namespace Наследование
{
    public class Food : Product
    {
        public override int FindDiscount()
        {
            if (amount_ >= 20 && amount_ < 150)
            {
                return 10;
            }
            if (amount_ >= 150 && amount_ <= 300)
            {
                return 30;
            }
            if (amount_ > 300)
            {
                return 50;
            }
            else
                return base.FindDiscount();
        }
    }
}
