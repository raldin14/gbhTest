using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gbhTest8Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////Part 8/////////////////////////////
            
            string word;// = "civic";
            string pal = "";
            string yesNo = "y";
            
            while (yesNo != "n")
            {
                Console.Write("Entre una palabra: ");
                word = Console.ReadLine();

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    pal += word[i];
                }
                if (pal.Equals(word))
                {
                    Console.WriteLine("La palabra {0} Es un palindrome", word);
                }
                else
                {
                    Console.WriteLine("La palabra {0} No es Plindrome", word);
                }

                Console.Write("Desea continuar?: y/n: ");
                yesNo = Console.ReadLine();
            }
            Console.WriteLine("Fin del palindrome.");
            Console.ReadLine();
        }
    }
}
