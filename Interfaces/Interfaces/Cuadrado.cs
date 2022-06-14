using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces 
{
    public class Cuadrado : IFigura
    {
        public decimal a { get; set; }
        public decimal b { get; set; }

        private decimal _a = 0;

        public Cuadrado(decimal a, decimal b)
        {

            this.a = a; 
            this.b = b;
            _a = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(a * b) / 2));

        }

        public decimal Area()
        {
            return b * a / 2;
        }

        public decimal Perimetro()
        {
            return a + a;

        }

    }
}
