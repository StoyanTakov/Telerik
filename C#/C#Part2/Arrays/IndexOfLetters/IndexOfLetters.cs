using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexOfLetters
    {

        static void Main()
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(i + 65);
            }

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    string toLowerLetter = alphabet[j].ToString().ToLower();
                    if (word[i] == alphabet[j] || word[i].ToString() == toLowerLetter)
                    {
                        {
                            int number = j;
                            Console.WriteLine(number);
                        }
                    }
                }
            }
        }
    }
}