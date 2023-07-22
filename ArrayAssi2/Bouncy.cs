using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssi2
{
    public class Bouncy
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int num = a; int prevDigit = num % 10;
            num = num / 10;
            bool increasing = true; bool decreasing = true;

            while (num > 0)
            {
                int currentDigit = num % 10;
                if (currentDigit < prevDigit)
                {
                    decreasing = false;
                }
                else if (currentDigit > prevDigit)
                {
                    increasing = false;
                }
                prevDigit = currentDigit;
                num = num / 10;
            }
            if (increasing)
            {
                Console.WriteLine("Increasing");
            }
            else if (decreasing)
            {
                Console.WriteLine("Decreasing");
            }
            else
            {
                Console.WriteLine("Bouncy");
            }
        }
    }
}
