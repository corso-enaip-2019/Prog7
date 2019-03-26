using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Entities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Umano io = new Umano(true, "Martino");

            Bambino figlio1 = new Bambino();
            

            //io.Mangia("colazione", 3);
            if(!io.HoDigerito)
            {
                if (io.Indigestione(true))
                {
                    io.FaiCacca();
                }
            }

            io.Mangia();

            Stack<Umano> pilaUmani = new Stack<Umano>();
            List<Umano> listaUmani = new List<Umano>();

            listaUmani.RemoveAll(x => x.Nome == "Martino");



        }
    }
}
