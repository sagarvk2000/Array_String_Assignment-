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
            int[] arr1 = new int[5];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0,count1 =0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                    arr1[i] = arr[i];
                    Console.WriteLine("the negative no are = " +arr1[i]);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count1++;
                    Console.WriteLine("Positive no are= " + arr[i]);
                }
            }
            Console.WriteLine("The count of -ve no ="+count);
            Console.WriteLine("The count of +ve no =" + count1);
        }
    }
}
