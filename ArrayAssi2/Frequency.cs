using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Check the frequency of no
namespace ArrayAssi2
{
    public class Frequency
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[8];
            //int[] frq = new int[8];
            //Console.WriteLine("Enter array Elements =");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    frq[i] = -1;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 1;
            //    for (int j = i+1; j < arr.Length; j++)
            //    {                   
            //        if (arr[i]==arr[j])
            //        {
            //            count++;
            //            frq[j] = 0;
            //        }
            //    }
            //    if(frq[i] != 0)
            //    {
            //        frq[i]=count;
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (frq[i] != 0)
            //    {
            //        Console.WriteLine($"{arr[i]} Occurs {frq[i]} times");
            //    }
            //}


            int[] arr = new int[6];
            int[] arr2 = new int[6];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*Console.WriteLine("Enter a number =");
            int a = Convert.ToInt32(Console.ReadLine());*/
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr2[i])
                    {
                        count++;
                        arr2[i] = arr[i];
                    }
                    

                }              
            }
            
        }
    }
}
