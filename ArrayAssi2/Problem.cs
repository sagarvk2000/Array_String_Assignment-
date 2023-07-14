using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wap that prints the numbers from 1 to 20. but for multiples of 3 print "OneX" instead of number and for multiples
// of 5 print "tel" for numbers which are multiple of 3 and 5 print "OneXTel"
namespace ArrayAssi2
{
    public class Problem
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("OneXTel");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("OneX");
                }
                else if (i%5==0)
                {
                    Console.WriteLine("Tel");
                }
                
                else
                {
                    Console.WriteLine(i);
                }
           
            }
            
        }
        }
    }

