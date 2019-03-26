using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSemaforo
{
    class Controller
    {


        Semaforo semafori1A = new Semaforo();
        Semaforo semafori2A = new Semaforo();
        Semaforo semafori1B = new Semaforo();
        Semaforo semafori2B = new Semaforo();


        string verde = "verde";
        string arancione = "arancione";
        string rosso = "rosso";

       

        public bool VuoiContinuare()
        {
            
            
                bool continua;
                Console.WriteLine("vuoi continuare?");
                String decisione = Console.ReadLine();
                if (decisione == "si")
                {
                    continua = true;
                }
                else
                {
                    continua = false;
                }
                return continua;
            
        }

        public void CambiaStato()
        {
            bool continua = true;
            while (continua)
            {
                for (int j = 0; j < 50; j++)
                {
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (i > 0 && i < 6)
                            {
                                // semafori1A, semafori2A verde
                                // semafor1B, semafori2B rosso
                                Console.WriteLine(verde);
                                Console.WriteLine(rosso);
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else
                            {
                                // semafori1A, semafori2A rosso
                                // semafor1B, semafori2B verde
                                Console.WriteLine(rosso);
                                Console.WriteLine(verde);
                                Console.WriteLine();
                                Console.WriteLine();
                            }

                        }

                    }

                }
                continua = VuoiContinuare();
            }
            Console.ReadLine();

        }
   
    }

}








        

