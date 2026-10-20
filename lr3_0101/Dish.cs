using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3_0101
{
    class Dish
    {
        private int id_;
        private string name_;
        private int price_;
        private int amount_;

        public Dish(int id, string name, int price, int amount)
        {
            id_ = id;
            name_ = name;
            price_ = price;
            amount_ = amount;
        }

        public int Id
        {
            get { return id_; }
        }

        public string Name
        {
            get { return name_; }
        }

        public int Price
        {
            get { return price_; }
        }

        public int Amount
        {
            get { return amount_; }
            set { amount_ = value; } 
        }
    }
}
