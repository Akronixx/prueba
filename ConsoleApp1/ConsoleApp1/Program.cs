using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lol;
            Console.WriteLine("Hola como te llamas?");
            lol= Console.ReadLine();
            Console.WriteLine($"Bienvenido {lol}");
            Console.WriteLine("Desea agregar algo más?");
        }
    }
}
