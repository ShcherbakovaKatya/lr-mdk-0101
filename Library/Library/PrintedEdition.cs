using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PrintedEdition
    {
        private string type_;
        private string name_;
        private int year_;
        private string author_;
        private int count_;

        public string GetType() { return type_; }
        public string GetName() { return name_; }
        public int GetYear() { return year_; }
        public string GetAuthor() { return author_; }
        public int GetCount() { return count_; }
        public void SetCount(int count) { count_ = count; }
        public PrintedEdition(string type, string name, int year, string author, int count)
        {
            type_ = type;
            name_ = name;
            year_ = year;
            author_ = author;
            count_ = count;
        }
        public static bool Find(List<PrintedEdition> list)
        {
            List<PrintedEdition> searchList = new List<PrintedEdition>();
            bool toOrder = false;

            while (true)
            {
                Console.WriteLine("Введите автора или тип печатного издания('Конец' - закончить поиск, 'Заказ' - перейти к оформлению заказа): ");
                string typeOrAuthor = Console.ReadLine();

                bool found = false;


                if (typeOrAuthor == "Конец") break;
                if (typeOrAuthor == "Заказ")
                {
                    toOrder = true;
                    break;
                }

                foreach (PrintedEdition item in list)
                {
                    if (item.GetAuthor().Contains(typeOrAuthor) || item.GetType() == typeOrAuthor)
                    {
                        Console.WriteLine($"{item.GetType()}, {item.GetName()}, {item.GetYear()}, {item.GetAuthor()}, {item.GetCount()}");
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("У нас такого нет :( ");
                }
            }
            return toOrder;
        }

    }
}
