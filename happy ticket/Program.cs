using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_ticket
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Enter your numer of ticket");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num;
            int sumOfNumber = 0;
            while(num1>0)
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
            int num4 = num / 1000;
            int sumOfPart = 0;
            int sumOfPart2 = 0;
            while(num1>0)
            {
                int num2 = num1 % 10;
                int num3 = num4 % 10;
                sumOfPart = sumOfPart + num2;
                sumOfPart2 = sumOfPart2 + num3;
                num1 = num1 / 10;
                num4 = num4 / 10; 
            }
            if (sumOfPart == sumOfPart2)
            {
                Console.WriteLine("You have a happy ticket!");
            }
            else Console.WriteLine("The ticket is not happy");
        }
    }
}
