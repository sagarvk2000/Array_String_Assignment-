using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. WAP to replace all negative value with its immediate left elements square.
//Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9]
//Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49]
namespace ArrayAssi2
{
    public class Problem2
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    int a = i - 1;
                    arr[i] = arr[a]*arr[a];
                }
                Console.WriteLine(arr[i]);
            }
        }
    }
}
