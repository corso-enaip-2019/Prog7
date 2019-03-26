using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        /// <summary>
        /// Verifica se il testo passato contiene un numero coerente di parentesi di apertura e chiusura "{","[","{"
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>





        static bool ceckBrackets(char[] text) {

            List<char> aperte = new List<char>();
            List<char> chiuse = new List<char>();
            for (int i = 0; i < text.Length; i++) {
                if (text[i].Equals("(") || text[i].Equals("[") || text[i].Equals("{"))
                {
                    aperte.Add(text[i]);
                }
            }
            for (int i = text.Length-1; i>=0; i--) {

                if (text[i].Equals(")") || text[i].Equals("]") || text[i].Equals("}"))
                {
                    chiuse.Add(text[i]);
                }
            }
            int indiceN;
            for (int i = 0; i < text.Length; i++)
            {
                if ((aperte[i] == '(' && chiuse[i] == ')') || (aperte[i] == '[' && chiuse[i] == ']') || (aperte[i] == '{' && chiuse[i] == '}'))

                {
                    return true;

                }

                else
                {
                    indiceN = i;

                    return false;
                }


        }


            static int indNoncorrisp(int indiceN)

            {
                for (int i = 0; i < text.Length; i++) {
                    if (aperte [i] == )
                        }
            }


        ( ( ) [ ( ) ] [ ] ) )
        ( ( [ ( [ 
        ) ) ] ] )

            
        

        public static 

        public void stack()
        {
            Stack<int> stackInteri = new Stack<int>();
            stackInteri.Push(1);
            int first = stackInteri.Peek();
            first = stackInteri.Pop();
        }

    }
}
