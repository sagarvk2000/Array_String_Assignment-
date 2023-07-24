using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssi2
{
    public class Sechighest
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 ,4,5};

            int max = arr[0];
            int max2 = arr[4];
                       
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max2 = max;
                    max = arr[i];
                }
            }
            
            Console.WriteLine(max2);
        }
    }
}
