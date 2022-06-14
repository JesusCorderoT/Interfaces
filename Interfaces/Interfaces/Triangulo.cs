using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Triangulo : IFigura
    {


        private decimal _h = 0;
   
        public Triangulo(decimal a, decimal b) 
        {

            this.a = a;
            this.b = b;
            _h = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble((a * a) - ((b * b) / 4))));

        }
        public decimal a { get; set; }
        public decimal b { get; set; }
        public decimal h { get { return _h; } }
        public decimal Area()
        {
            return b * h / 2;
        }

        public decimal Perimetro()
        {
            return (2 * a) + b;
        }
    }
}
