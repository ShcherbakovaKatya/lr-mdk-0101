using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3_0101
{
    internal class Ordering
    {
        enum OrderStatus
        {
            Success,        
            Empty,          
            NotEnoughStock  
        }

        public class OrderLine
        {
            private Dish dish_;
            private int quantity_;

            public OrderLine(Dish dish, int quantity)
            {
                dish_ = dish;
                quantity_ = quantity;
            }

            public Dish Dish
            {
                get { return dish_; }
            }

            public int Quantity
            {
                get { return quantity_; }
                set { quantity_ = value; }   
            }

            public int GetCost()
            {
                return dish_.Price * quantity_;
            }
        }

        public class Order
        {
            private List<OrderLine> lines_;
            private int total_;

            public Order()
            {
                lines_ = new List<OrderLine>();
                total_ = 0;
            }

            public List<OrderLine> Lines
            {
                get { return lines_; }
            }

            public int Total
            {
                get { return total_; }
                set { total_ = value; }
            }

            public void AddDish(Dish dish, int quantity)
            {
                foreach (OrderLine line in lines_)
                {
                    if (line.Dish.Id == dish.Id)
                    {
                        line.Quantity += quantity;
                        return;
                    }
                }
                lines_.Add(new OrderLine(dish, quantity));
            }


            public int CalculateTotal()
            {
                int sum = 0;
                foreach (OrderLine line in lines_)
                {
                    sum += line.GetCost();
                }
                total_ = sum;
                return total_;
            }
        }
    }
}
