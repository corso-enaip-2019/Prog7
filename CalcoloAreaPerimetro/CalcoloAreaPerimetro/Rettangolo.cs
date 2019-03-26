using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloAreaPerimetro
{
    class Rettangolo : IFiguraGeometrica
    {
        double _base;
        double _altezza;

        public Rettangolo(double Base, double altezza)
        {
            _base = Base;
            _altezza = altezza;
        }

      

        public double calcoloPerimetro()
        {
            return ( _base + _altezza ) * 2;;
        }

        public double CalcoloArea()
        {
            return _base * _altezza;;
        }
    }
}
