using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PrintedEdition> list = CsvAction.CsvRead("LibraryInformation.csv");
        }
    }
}
