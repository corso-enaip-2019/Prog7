using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffeteria
{
    interface Catalogo
    {
        void Menu()
        {
            Dictionary<string, double> Menu = new Dictionary<string, double>
            {
                { latte , prLatte },
                { cioccolata , prCioccolata },
                { sambuca , prSambuca },
                { grappa , prGrappa }
            };
        }
    }
}
