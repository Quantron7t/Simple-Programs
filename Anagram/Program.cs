using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two word to check if it is Anagram :\nword 1 - ");
            string wordOne = Console.ReadLine();
            Console.WriteLine("word 2 -");
            string wordTwo = Console.ReadLine();
            
            char[] a = wordOne.ToLower().ToCharArray();
            char[] b = wordTwo.ToLower().ToCharArray();

            Array.Sort(a);
            Array.Sort(b);
            string s1 = new string(a);
            string s2 = new string(b);

            if (s1 == s2)
            {
                Console.WriteLine("the words {0} and {1} are anagram", wordOne, wordTwo);
            }
            else
            {
                Console.WriteLine("the words {0} and {1} are not anagram", wordOne, wordTwo);
            }
            Console.Read();
        }
    }
}
