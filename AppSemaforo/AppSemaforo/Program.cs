using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSemaforo
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controllo = new Controller();

            controllo.CambiaStato();
        }
    }
}
