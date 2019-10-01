using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvKlasser
{
    class Program
    {
        static void Main(string[] args)
        {
            BookClass info = new BookClass();
            info.PrintInfo();

            Console.WriteLine("I have failed");

            Console.ReadKey();
        }
    }
}
