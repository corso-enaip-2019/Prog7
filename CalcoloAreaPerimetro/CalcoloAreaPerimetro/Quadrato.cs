using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloAreaPerimetro
{
    class Quadrato : IFiguraGeometrica
    {
        double _lato;
        

        public Quadrato(double lato)
        {
            _lato = lato;
        }

        public double Lato { get { return _lato; } set { _lato = value; } }


        public double calcoloPerimetro()
        {
            return Lato * 4;;
        }

        public double  CalcoloArea()
        {
            return Math.Pow(Lato, 2) ;
        }
    }
}
