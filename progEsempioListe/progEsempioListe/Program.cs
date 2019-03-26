using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progEsempioListe
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public void  List()
        {
            List<string> stringhe = new List<string>();
        }

        public void queie()
        {
            Queue<string> codaStringhe = new Queue<string>();
            codaStringhe.Enqueue("uno");
            string nextElement = codaStringhe.Peek();
            nextElement = codaStringhe.Dequeue();
        }

        public void stack()
        {
            Stack<int> stackInteri = new Stack<int>();
            stackInteri.Push(1);
            int first = stackInteri.Peek();
            first = stackInteri.Pop();
        }

    }
}
