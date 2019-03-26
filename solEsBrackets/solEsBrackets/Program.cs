using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solEsBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool ok = ceckBrackets(@"
                namespace Brackets
                {
                    class Program
                    {
                        static void Main(string] args)
                        {
                            bool ok = CheckBrackets("")
                            Console.ReadLine();
                        }
                        static bool CheckBrackets(string text)
                        {
                        }
                    }
                }", out int errorRow, out int errorColumn);

            string strOk = ok ? "OK" : $ "KO : row, { errorRow} Column{ errorColumn}";
            Console.WriteLine($"Text is {strOk}");

            Console.ReadLine();
        }


        static List<char> openingBrackets = new List<char>(){'(','[','{'};
        static List<char> closingBrackets = new List<char>(){')', ']', '}'};

        static bool ceckBrackets(string text, out int errorRow, out int errorColumn)
        {
            bool result;
            Stack<char> brackets = new Stack<char>();

            int currentRow = 0;
            int currentColumn = 0;




            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (openingBrackets.Contains(currentChar))
                {
                    brackets.Push(currentChar);
                }

                else if (closingBrackets.Contains(currentChar))
                {
                    if (brackets.Count == 0)
                    {
                        errorRow = 0;
                        errorColumn = 0;
                        return false;
                    }

                    if (brackets.Peek() == corrispondingOpeningBracket(currentChar))
                    {

                        brackets.Pop();
                    }
                    else
                    {
                        errorColumn = currentColumn;
                        errorRow = currentRow;
                        return false;
                    }
                    const int newLine = 10;
                    
                    if (currentChar == newLine)
                    {
                        currentRow++;
                        currentColumn = 1;
                    }
                    else
                    {
                        currentColumn++;

                    }
                }

            }
            errorColumn = currentColumn;
            errorRow = currentRow;
            return brackets.Count == 0;
            
            


            



        }
        static char corrispondingOpeningBracket(char closingBracket)
        {
            int closingIndex = closingBrackets.IndexOf(closingBracket);
            return openingBrackets[closingIndex];

            char correspondingOpeningBracket = ' ';
            if (closingBracket == ')')
                correspondingOpeningBracket = '(';
            else if (closingBracket == ']')
                correspondingOpeningBracket = '[';
            else if (closingBracket == '}')
                correspondingOpeningBracket = '{';

            return correspondingOpeningBracket;
        }




    }
}

