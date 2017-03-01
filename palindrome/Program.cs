using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a six-digit number");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num;
            int sumOfNumber = 0;
            while (num1 > 0)
            {
                int num2 = num1 % 10;
                sumOfNumber = sumOfNumber + 1;
                num1 = num1 / 10;
            }
            if (sumOfNumber % 6 != 0)
            {
                Console.WriteLine("Enter another number");
                return;
            }
            num1 = num % 1000;
            string s = null;
            while (num1>0)
            {
                int num2 = num1 % 10;
                string s1 = num2.ToString();
                s = s + s1;
                num1 = num1 / 10;
                
            }
            int s2=Convert.ToInt32(s);
            int num3 = num / 1000;
            if (s2 == num3)
            {
                Console.WriteLine("It is a palindrome");
            }
            else Console.WriteLine("It is not a palindrome");
        }
    }
}
