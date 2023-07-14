using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write two methods that return the average of an array with following headers.
// i. public static int average(int[] array)
//ii. public static double average(double[] array).
//iii.Write main and invoke the 2 methods.
namespace ArrayAssi2
{
    public  class ArrAvg
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter numbers =");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            double[] arr1 = new double[4];
            Console.WriteLine("Enter decimal numbers =");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToDouble(Console.ReadLine());
            }

            int res = average(arr);
            double res1 = average(arr1);
            Console.WriteLine("the integer avg is =" + res);
            Console.WriteLine("The decimal value avg is =" + res1);
        }


             public static int average(int[] array)
            {
                int average = 0; 
                int sum = 0;

                foreach (var num in array)
                {
                    sum = sum + num;
                }
                average = sum / array.Length;
                return average;
            }

             public static double average(double[] array)
            {               
                double sum = 0.0;

                foreach (var num in array)
                {
                    sum = sum +num;
                }
                double average = sum / array.Length;
                return average;
            }
        }
    }

