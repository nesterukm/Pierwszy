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
            Console.WriteLine("Cześć");

        private static void Greeting()
        {
            Console.Write("Podaj Imię:");
            string name = Console.ReadLine();
            Console.WriteLine("Cześć " + name);
        }
    }
}
