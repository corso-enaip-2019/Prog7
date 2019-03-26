using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esempioClasse
{
    class Program
    {

        class bulb
        {
            int _consumption;
            int _lumen;

            bool _turnedOn;

            void turnOn()
            {
                _turnedOn = true;
            }

            void turnOf()
            {
                _turnedOn = false;
            }

        }
        
    }
}
