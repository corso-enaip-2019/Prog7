using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloAreaPerimetro
{
    class Program
    {

        

        static void Main(string[] args)
        {
            
            List<IFiguraGeometrica> figure = new List<IFiguraGeometrica> { new Quadrato(10), new Rettangolo(10, 20), new Cerchio(10) } ;
            
            foreach (var figura in figure)
            {
                string perimDescr = figura is Cerchio ? "la sua circonferenza è " : "il suo perimetro è ";

                Console.Write($"{perimDescr}{figura.calcoloPerimetro()}");

                Console.WriteLine( "  "+figura.CalcoloArea());

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
