using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeevil_longestword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a sentence.");
            string sentence = Console.ReadLine();
            string[] sentenceArray = sentence.Split();
            string longestWord = "";
            int mostLetters = 0;
            foreach (string word in sentenceArray)
            {
                if(word.Length >= mostLetters)
                {
                    longestWord = word;
                    mostLetters = word.Length;
                }

            }
            Console.WriteLine(longestWord);
        }
    }
}
    