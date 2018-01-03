using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence(max 80 characters)");
            string statement = Console.ReadLine();
            int lengthOfStatement = statement.Length;
            char[] reverseStatement= new char[lengthOfStatement];
            foreach (var alpha in statement)
            {
                lengthOfStatement--;
                reverseStatement[lengthOfStatement] = alpha;
            }

            Console.WriteLine("entered sentence in reverse: ");
            string s = new string(reverseStatement);
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
