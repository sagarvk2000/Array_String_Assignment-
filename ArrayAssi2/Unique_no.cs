using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//print unique numbers in array
namespace ArrayAssi2
{
    public class Unique_no
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 5, 6 };
            //int[] arr = new int[5];
            //Console.WriteLine("Enter array elements");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        a = 1;
                        break;
                    }
                }
                if (a == 0)
                    Console.WriteLine(arr[i]);
            }
        }
    }
}
