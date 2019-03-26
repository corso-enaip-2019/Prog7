using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Anagrammi
{
    class Allenamento : IWordsRepository 

    {

        public void Run()
        {
            Console.WriteLine("Scrivi una parola e io ti restituisco tutti gli anagrammi possibili: ");

            string sourceWord = Console.ReadLine();

            foreach (string a in GetAnagrams())
            {
                if (IsAnagram(sourceWord, a))
                {
                    Console.WriteLine(a);
                }
                
            }

        }

        public List<string> GetAnagrams()
        {
            string path = @"C:\Users\triprog-7\source\repos\corso-enaip-2019\src\Anagrams\Anagrams\Repositories\660000_parole_italiane.txt";

            string [] readText = File.ReadAllLines(path);

            List<string> ReadText = readText.ToList();

            return ReadText;
        }

        public bool IsAnagram(string sourceWord, string candidateAnagram)
        {          
            if (string.Concat(sourceWord.OrderBy(c => c)) == string.Concat(candidateAnagram.OrderBy(c => c)) )
            { 
                return true;
            }
            else return false;
        }

        public string GetRandomWord()
        {
            Random anagram = new Random();

            int i = anagram.Next();

            List<string> anagrammi = GetAnagrams();

            return anagrammi[i];
        }


    }

        
    
}
