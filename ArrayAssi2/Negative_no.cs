            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.WAP to print all negative elements in an array and also count total number of negative elements in an array.
namespace ArrayAssi2
{
    internal class Negative_no
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                    Console.Write(" " + arr[i] );
                }
            }
            Console.WriteLine($"Count of Negative Numbers is = {count}");
        }
    }
}
