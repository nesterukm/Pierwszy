using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwszy
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt: " + maxInt);
            Console.WriteLine("minInt: " + minInt);
            Console.WriteLine("maxLong: " + maxLong);
            Console.WriteLine("minLong: " + minLong);
        }

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void Age()
        {
            Console.Write("Podaj wiek:: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);


            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jesteś pełnoletni");
            }
            else if (result == false)
            {
                //Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("wprowadź prawidłowe dane!");
            }
            else
            {
                Console.WriteLine("Jest yulko mleko");
            }
        }

        private static void Greeting()
        {
            Console.Write("Podaj Imię:");
            string name = Console.ReadLine();
            Console.WriteLine("Cześć " + name);
        }
    }
}
