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
            int a, b, c;
            int[] number = new int[3];
           
            for (int i = 0; i < 3; i++)
            {
                string messaggio = $"scrivi il lato {i+1}";

                number[i] = AskandCecknumber(messaggio);
            }

            a = number[0];
            b = number[1];
            c = number[2];

            if (triangle(a, b, c))
            {

                Console.WriteLine("This number identify a triangle");
            }
            else
            {
                Console.WriteLine("This number not identify a triangle, try with:");

            do
            {
                int m = Math.Max(Math.Max(number[0], number[1]), number[2]);
                int index = Array.IndexOf(number, m);
                number[index]--;
                
            }
            while (triangle(number[0], number[1], number[2]));
           
           
              Console.WriteLine($"{ number[0]} , { number[1]} , { number[2]}");

            }

            Console.ReadLine();
        }
        static int AskandCecknumber(string message)
        {

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

        static bool triangle(int a, int b, int c)
        {

            bool sumOK = (a + b > c && b + c > a && a + c > b);
            bool diffOK = a > Math.Abs(b - c) && b > Math.Abs(a - b) && c > Math.Abs(a - c);

            return sumOK && diffOK;

        }
    }
}
    

   

       

      

    

