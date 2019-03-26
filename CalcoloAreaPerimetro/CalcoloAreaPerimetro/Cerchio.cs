using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloAreaPerimetro 
{
    class Cerchio : IFiguraGeometrica
    {
        double _raggio;
        double _circonferenza;

        public Cerchio(double raggio)
        {
            _raggio = raggio;
        }

        public double _Circonferenza { get { return _circonferenza; } set { _circonferenza = value; } }

        public  double CalcoloArea()
        {
            return Math.PI * Math.Pow(_raggio, 2);
        }

        public  double calcoloPerimetro()
        {
            return 2 * Math.PI * _raggio;
        }
    }
}
