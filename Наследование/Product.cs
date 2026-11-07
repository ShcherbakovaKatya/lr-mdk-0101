using System;

namespace Наследование
{
    public class Product
    {
        protected string name_;
        protected double price_;
        protected int amount_;
        public void SetName(string name)
        {
            name_ = name;
        }

        public string GetName()
        {
            return name_;
        }

        public void SetPrice(double price)
        {
            price_ = price;
        }
        public double GetPrice()
        {
            return price_;
        }

        public void SetAmount(int amount)
        {
            amount_ = amount;
        }

        public int GetAmount()
        {
            return amount_;
        }

        public virtual int FindDiscount()
        {
            int discount = 0;
            return discount;
        }
    }
}
