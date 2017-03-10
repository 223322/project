using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_number
{
    class Program
    {
        static int MaxFirst(int a, int b)
        {
            int temp = Math.Max(a, 2*b);
            return temp;
        }
        static int MaxSecond(int a, int b)
        {
            int temp = Math.Max(2*a-b, b);
            return temp;
        }
        static void Main(string[] args)
        {
            // z = max(a, 2b) + max(2a - b, b)
            Console.WriteLine("Enter first number");
            int tempForConsole_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int tempForConsole_b = Convert.ToInt32(Console.ReadLine());
            int tempForMethod1 = MaxFirst(tempForConsole_a, tempForConsole_b);
            int tempForMethod2 = MaxSecond(tempForConsole_a, tempForConsole_b);
            int z = tempForMethod1 + tempForMethod2;
            Console.WriteLine(z);

        }
    }
}
