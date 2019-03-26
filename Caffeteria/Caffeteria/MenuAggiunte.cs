using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffeteria
{
    class MenuAggiunte
    {
        Dictionary<string, double> menu;
        string latte = "latte";
        string cioccolata = "cioccolata";
        string sambuca = "sambuca";
        string grappa = "grappa";

        double prLatte;
        double prCioccolata;
        double prSambuca;
        double prGrappa;


        public MenuAggiunte()
        {
            Menu = new Dictionary<string, double>
            {
                { latte , prLatte },
                { cioccolata , prCioccolata },
                { sambuca , prSambuca },
                { grappa , prGrappa }

        };
        }


        public Dictionary<string, double> Menu { get; }


    }
}
