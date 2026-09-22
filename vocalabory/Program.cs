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

            Dictionary<string, int> PeopleInHour = new Dictionary<string, int>()
            {
                { "10.00-12.00", 7},
                { "12.00-15.00", 10},
                { "15.00-18.00", 7},
                { "18.00-21.00", 10}
            };

            int max = PeopleInHour["10.00-12.00"];
            int min = PeopleInHour["10.00-12.00"];

            List <string> PeriodsMax = new List<string>();
            List<string> PeriodsMin = new List<string>();

            foreach (KeyValuePair<string, int> person in PeopleInHour)
                if (person.Value > max)
                {
                    max = person.Value;
                    PeriodsMax.Add(person.Key);
                }

            foreach (KeyValuePair<string, int> person in PeopleInHour)
                if (person.Value <= min)
                {
                    min = person.Value;
                    PeriodsMin.Add(person.Key);
                }

            Console.WriteLine("Период с максимальной посещаемостью: ");
            foreach (var Hours in PeriodsMax)
            {
                Console.Write(Hours + " ");
            }

            Console.WriteLine("\nПериод с минимальной посещаемостью: ");
            foreach (var Hours in PeriodsMin)
            {
                Console.Write(Hours + " ");
            }

        }
    }
}
