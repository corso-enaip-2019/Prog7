using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSolution
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Scrivi tre numeri interi:");

            int a = AskandCecknumber("Scrivi il primo lato");
            int b = AskandCecknumber("Scrivi il primo lato");
            int c = AskandCecknumber("Scrivi il primo lato");


            if (a + b > c && b + c > a && a + c > b && a > Math.Abs(b - c) && b > Math.Abs(a - b) && c > Math.Abs(a - c))
            {

                Console.WriteLine("I numeri appena scritti rappresentano un triangolo");

            }

            else
            {

                Console.WriteLine("I numeri appena scritti non rapresentano un triangolo");
            }


            Console.ReadLine();
        }
        static int AskandCecknumber(string message) {

            int convertedValue;
            Console.WriteLine(message);
            String input = Console.ReadLine();
            bool conversionOK = int.TryParse(input, out convertedValue);
            if (!conversionOK)
                Console.WriteLine("l'input non e'valido");
            if (convertedValue <= 0)
                Console.WriteLine("il valore deve essere positivo");

            return convertedValue;
    }
        }
        
}
