using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IFigura
    {
         decimal a { get; set; }
         decimal b { get; set; }


        void Area();
        void Perimetro();
        



    }
}
