using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = null;
            Console.WriteLine("Enter your number");
            int oldNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number system");
            int oldSystem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new number system");
            int newSystem= Convert.ToInt32(Console.ReadLine()); 
            int oldNum1 = oldNum;
            while (oldNum1 != 0)
            {
                int figure = oldNum1 % 10;
                if (figure >= oldSystem)
                {
                    Console.WriteLine("Enter another number");
                    return;
                }
                oldNum1 = oldNum1 / 10;
            }
            oldNum1 = oldNum;
            int oldNum1To10 = 0;
            int mnog = 0;
            while (oldNum1 != 0)
            {
                int figure = oldNum1 % 10;
                oldNum1To10 = (int)(oldNum1To10 + figure * (Math.Pow(oldSystem, mnog)));
                oldNum1 = oldNum1 / 10;
                mnog = mnog + 1;
            }
            Console.WriteLine(oldNum1To10);
            int newSystem1 = newSystem;
            int newNum = oldNum1To10;
            string s1 = null;
            while (newNum > 0)
            {
                if (newNum > newSystem1)
                {
                    int newNum1 = newNum / newSystem1;
                    string s2 = newNum1.ToString();
                    s1 = s2 + s1;
                    newNum = newNum - newSystem1 * newNum1;
                }
                else
                {
                    s1 = s1 + newNum;
                    newNum = Convert.ToInt32(s1);
                    Console.WriteLine(newNum);
                    return;
                }
            }
        }
    }
}
