using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Anagrammi
{
    class Sfida : IWordsRepository 
    {

        public void Run()
        {
            string parola = GetRandomWord();

            Console.WriteLine($"scrivi un anagramma di questa parola : {parola}");

            string anagram = Console.ReadLine();

            if (IsAnagram(parola, anagram))
            {
                Console.WriteLine($"bravo la prola scritta è un' anagramma di {parola}");
            }
            else
            {
                Console.WriteLine($"mi dispiace questa parola non e' un' anagramma di {parola}");
            }

            
        }

        public List<string> GetAnagrams()
        {
            string path = @"C:\Users\triprog-7\source\repos\corso-enaip-2019\src\Anagrams\Anagrams\Repositories\660000_parole_italiane.txt";

            string[] readText = File.ReadAllLines(path);

            List<string> ReadText = readText.ToList();

            return ReadText;
        }

        public bool IsAnagram(string sourceWord, string candidateAnagram)
        {
            if (string.Concat(sourceWord.OrderBy(c => c)) == string.Concat(candidateAnagram.OrderBy(c => c)))
            {
                return true;
            }
            else return false;
        }

        public string GetRandomWord()
        {
            Random anagram = new Random();

            int i = anagram.Next(660000);

            return GetAnagrams()[i];
        }
    }
}
