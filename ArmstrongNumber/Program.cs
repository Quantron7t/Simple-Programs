using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number sequence");
            string numbers = Console.ReadLine();
            int lengthOfNumber = numbers.Length;
            double armstrongNumber=0;
            
            foreach (var number in numbers)
            {
                int n = Convert.ToInt32(number.ToString());
                armstrongNumber = armstrongNumber + Math.Pow(n,3);
            }

            if (armstrongNumber.ToString()==numbers)
            {
                Console.WriteLine(numbers + " is an armstrong number.");
            }
            else
            {
                Console.WriteLine(numbers + " is not an armstrong number.");
            }

            Console.ReadLine();
        }
    }
}
