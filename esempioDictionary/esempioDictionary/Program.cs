using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esempioDictionary
{
    class Program
    {
        public static object Response { get; private set; }

        static void Main(string[] args)
        {

            List<string> num = new List<string>();
            List<string> numLett = new List<string>();

            Dictionary<List<string>, List<string>> prova = new Dictionary<List<string>, List<string>>();

            prova.Add(num, numLett);


            foreach (KeyValuePair<List<string>, List<string>> cod in prova)
            {
                Console.WriteLine(cod.Key);

            }
            Console.ReadLine();
        }
    }
}
