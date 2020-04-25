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

            Console.WriteLine();
            Console.WriteLine();

            valueTypes();

            Console.WriteLine();
            for (;;)
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void valueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo, pijesz kawę.");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś nie poprawny wiek.");
            }
            else
            {
                Console.WriteLine("Możemy zaoferować Ci mleko.");
            }
        }

        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imie: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Witaj, " + name2);
        }
    }
}
