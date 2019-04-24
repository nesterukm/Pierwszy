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
            //string name = args[0];

            Console.Write("Cześć jak ma sz imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Cześć "+name);

            Console.Write("Podaj wiek: ");

            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Jesteś pełnoletni!");
            }
            else
            {
                Console.WriteLine("Gnojek");
            }
            Console.WriteLine("");

            Console.ReadLine();
            

        }
    }
}
