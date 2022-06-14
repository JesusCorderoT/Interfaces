using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IFigura[] fi = new IFigura[2] { new Cuadrado(42,31), new Triangulo(53, 21) };

            foreach (var item in fi)
            {
                Console.WriteLine($"{item.ToString()} Area:");
            }
            Console.ReadKey();



        }
    }
}
