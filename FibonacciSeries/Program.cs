using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number limit :");
            int limit = Convert.ToInt32(Console.ReadLine()) ;
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write(a+","+b);
            for (int i = 0; i < limit; i++)
            {               
                c = a + b;
                Console.Write(","+c);
                a = b;
                b = c;
            }
            Console.Read();
        }
    }
}
