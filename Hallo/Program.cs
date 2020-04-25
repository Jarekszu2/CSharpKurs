using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hallo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string name = args[0];
            Console.WriteLine("Cześć " + name);

            Console.WriteLine();
            foreach (var item in args)
            {
                Console.WriteLine("Cześć " + item);
            }

            Console.WriteLine();
            Console.WriteLine("Koniec");

            Console.ReadKey();
        }
    }
}
