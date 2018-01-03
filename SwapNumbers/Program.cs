using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter number for variable a : ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for variable b : ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entered Variables and their values : \n" + "A : " +a.ToString()+"\n"+"B : "+b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Variables after swapping : \n"+"A : "+Math.Abs(a)+ "\nB : "+Math.Abs(b));
            Console.ReadLine();
        }
    }
}