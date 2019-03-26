using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrammi
{
    class Program
    {
        public void AskforString() { }
        public void writeMessage() { }


        static void Main(string[] args)
        {
            var allenamento = new Allenamento();
            var sfida = new Sfida();

            bool run = true;

            while (run)
            {
                PrintMenu();
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.C:
                        ClearScreen();
                        break;
                    case ConsoleKey.S:
                        sfida.Run();
                        break;
                    case ConsoleKey.A:
                        allenamento.Run();
                        break;
                    case ConsoleKey.Escape:
                        run = false;
                        break;
                }
            }

            Console.ReadKey();
        }
        private static void ClearScreen()
        {
            Console.Clear();
        }

        private static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("GIOCO DEGLI ANAGRAMMI:");
            Console.WriteLine();
            Console.WriteLine("Scegli la modalità di gioco: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sida (S)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Allenamento (A)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Escape per uscire");
            Console.WriteLine("C per pulire la console");
            Console.WriteLine();
        }
       


    }
}

