using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
    public class CsvAction
    {
        public static List<PrintedEdition> CsvRead(string filePath)
        {
            List<PrintedEdition> result = new List<PrintedEdition>();

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            { 
                string[] parts = line.Split(';');

                PrintedEdition printedEdition = new PrintedEdition(parts[0], parts[1], Convert.ToInt32(parts[2]), parts[3], Convert.ToInt32(parts[4]));

                result.Add(printedEdition);
            }
            return result;
        }
    }
}
