using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Move zeros to beginning or end of array. 
//e.g. if given array is { 2, 10, 0, 5, 3, 0, 4, 1 } then output array should be 
//a. { 0,0,2,10,5,3,4,1} 
//b. { 2,10,5,3,4,1,0,0}
namespace ArrayAssi2
{
    public class Problem4
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i+1; j < arr.Length-1; j++)
            //    {
            //        if (arr[j] == 0)
            //        {
            //            int temp = 0;
            //            temp=arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }         
            //}
            //foreach (var item in arr)
            //{
            //    Console.Write(item+" ");
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i-1; j < i; j++)
                {
                    if (arr[i]==0)
                    {
                        int temp = 0;
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}
