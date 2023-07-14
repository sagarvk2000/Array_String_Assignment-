using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.WAP to put even and odd elements of array in two separate arrays.
namespace ArrayAssi2
{
    public class Even_odd
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] odd = new int[5];
            int[] even = new int[5];

            int j = 0; int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even[j++] = array[i];
                }
                else
                {
                    odd[k++] = array[i];
                }
            }
            foreach (var item in even)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            foreach (var item in odd)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

    }
}

