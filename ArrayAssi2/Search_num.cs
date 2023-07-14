using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.WAP to search for a given number in an array and accordingly print the index if exists
namespace ArrayAssi2
{
    public class Search_num
    {
        static void Main(string[] args)
        {
            //    int[] arr = new int[5];
            //    Console.WriteLine("Enter numbers");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine("Enter search number =");
            //    int sn = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] == sn)
            //        {
            //            Console.WriteLine("The number is found ="+arr[i]);
            //        }
            //    }
            //    Console.WriteLine("The number is not found....");


            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter a number =");
            int search = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    Console.WriteLine("Found ="+i);
                    
                }
            }
            //Console.WriteLine("Number Not Found");
        }
    }
}
