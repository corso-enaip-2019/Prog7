using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentClasse
{

    class Program
    {
        private static bool continua;
        List<Student> listaStudenti = new list<Student>(Console.ReadLine());

        static void Main(string[] args)
        {
            Console.Write("Scrivi il nome di uno studente: ");
           
            bool continua = true;
            while (continua)
            {
                Console.WriteLine("Vuoi aggiungere uno studente?");
                string risposta = Console.ReadLine();
                if (risposta == "no")
                {
                    continua = false;

                }

                else
                {
                    Console.WriteLine("Nome studente: ");
                    Student studente = new Student(Console.ReadLine());
                    listaStudenti.Add(studente.Name);

                }
            }

            stampaLista();

            void stampaLista()
        {
            foreach(var studente in listaStudenti)
            {
                Console.WriteLine(studente);
            }
                
            Console.ReadLine();
        }
       
        }
            
        
    }
}
