using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vocalabory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> people = new Dictionary<string, int>()
            //{
            //    { "Смирнов", 20},
            //    { "Козлов", 26}
            //};

            //people.Add("Лобанов", 33);
            //people.Add("Иванов", 18);


            ////foreach (KeyValuePair<string, int> person in people)
            ////    Console.WriteLine($"Фамилия: {person.Key}. Возраст: {person.Value}");

            //people.Remove("Иванов");

            //bool flag = people.ContainsKey("Будейко");
            //if (!flag) 
            //{ 
            //    people.Add("Будейко", 67); 
            //}

            //people["Лобанов"] = 38;
            //people["Павлов"] = 23;

            //int Kozlov = people["Козлов"];
            //Console.WriteLine($"Возраст Козлова = {Kozlov}");

            //foreach (KeyValuePair<string, int> person in people)
            //    Console.WriteLine($"Фамилия: {person.Key}. Возраст: {person.Value}");

            Dictionary<int, int> PeopleInHour = new Dictionary<int, int>()
            {
                {7, 7},
                {8, 10},
                {9, 12},
                {10, 12},
                {11, 12},
                {12, 7},
                {13, 6},
                {14, 3},
                {15, 2},
                {16, 2},
                {17, 1},
                {18, 3},
            };

            int max = PeopleInHour[7];
            int min = PeopleInHour[7];

            List <int> PeriodsMax = new List<int>();
            List<int> PeriodsMin = new List<int>();


            foreach (KeyValuePair<int, int> person in PeopleInHour)
                if (person.Value > max)
                {
                    max = person.Value;
                }
            foreach (KeyValuePair<int, int> person in PeopleInHour)
                if (person.Value == max)
                {
                    PeriodsMax.Add(person.Key);
                }


            foreach (KeyValuePair<int, int> person in PeopleInHour)
                if (person.Value <= min)
                {
                    min = person.Value;
                }
            foreach (KeyValuePair<int, int> person in PeopleInHour)
                if (person.Value == min)
                {
                    PeriodsMin.Add(person.Key);
                }

            Console.WriteLine("Период с максимальной посещаемостью: ");

            Console.WriteLine("\nПериод с минимальной посещаемостью: ");

        }
    }
}
