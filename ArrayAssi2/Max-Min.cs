using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.WAP to find the maximum and minimum value in an array.
namespace ArrayAssi2
{
    public class Max_Min
    {
        static void Main(string[] args)
        {
            int max,min;
            int[] arr=new int[5];  // = new int[8] {55,66,2,9,46,98,7,88};

            //or
            Console.WriteLine("Enter numbers =");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0]; //assume 55
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Max ={max} and min ={min}");
        }
    }
}
