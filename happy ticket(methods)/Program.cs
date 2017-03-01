using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_ticket_methods_
{
    class Program
    {
        static int EnterTheNumber(int numberOfTicket)
        {
            Console.WriteLine("Enter your number of ticket");
            numberOfTicket = Convert.ToInt32(Console.ReadLine());
            return numberOfTicket;
        }
        static int NumberOfSymbolsInTicket(int num)
        {
            int numberOfSmbols = 0;

            while (num > 0)
            {
                int num1 = num % 10;
                numberOfSmbols = numberOfSmbols + 1;
                num = num / 10;
            }
            return numberOfSmbols;

        }
        static int Count(int numOfDigits, int numOfTicket)
        {
            int copy = numOfDigits / 2;
            int num1 = numOfTicket % (int)Math.Pow(10, copy);
            int sum1 = While(num1);
            return sum1;
        }
        static int Count1(int numOfDigits, int numOfTicket)
        {
            int copy = numOfDigits / 2;
            int num2 = numOfTicket / (int)Math.Pow(10, copy);
            int sum2 = While(num2);
            return sum2;
        }
        static int Uncount(int numOfDigits, int numOfTicket)
        {
            int copy = numOfDigits / 2;
            int num1 = numOfTicket % (int)Math.Pow(10, copy);
            int sum1 = Count(numOfDigits, numOfTicket);
            return sum1;
        }
        static int Uncount1(int numOfDigits, int numOfTicket)
        {
            int copy = numOfDigits / 2;
            int num2 = numOfTicket / (int)Math.Pow(10, copy);
            num2 = num2 % 10;
            int sum2 = Count(numOfDigits, numOfTicket);
            return sum2;
        }
        static int While(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int num1 = num % 10;
                sum = sum + num1;
                num = num / 10;
            }
            return sum;
        }
        static bool sravnenie(int sum1, int sum2)
        {
            if (sum1 == sum2)
            {
                return true;
            }
            else return false;
        }
        
        static void Main(string[] args)
        {
            int temp=0;
            int numberOfTicket = EnterTheNumber(temp);
            int numberOfDigits = NumberOfSymbolsInTicket(numberOfTicket);
            if (numberOfDigits % 2 == 0)
            {
                int sum1 = Count(numberOfDigits, numberOfTicket);
                int sum2 = Count1(numberOfDigits, numberOfTicket);

                if (sravnenie(sum1, sum2))
                {
                    Console.WriteLine("Счасливый");
                }
                else
                {
                    Console.WriteLine("Несчастливый");
                }
            }
            else
            {
                int sum1 = Uncount(numberOfDigits, numberOfTicket);
                int sum2 = Uncount1(numberOfDigits, numberOfTicket);

                if (sum1 == sum2)
                {
                    Console.WriteLine("Счасливый");
                }
                else
                {
                    Console.WriteLine("Несчастливый");
                }
            }
        }
    }
}