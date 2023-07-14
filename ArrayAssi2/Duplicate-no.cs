using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6.WAP to find and count total number of duplicate elements in an array.
namespace ArrayAssi2
{
    public class Duplicate_no
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8] { 2, 5, 6, 9, 2, 7, 3, 2 };
           /* int[] arr = new int[8];
            for (int i = 0; i < 8; i++)
            {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
            } */
            int count = 0,k=0;
           int[] Dupli = new int[4];   
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {                       
                        Dupli[k++] = arr[i];
                        count++;
                        Console.WriteLine(" "+arr[i]);
                    }
                }
            }
            Console.WriteLine(count);
            //foreach (var item in Dupli)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
        }
    }
}
