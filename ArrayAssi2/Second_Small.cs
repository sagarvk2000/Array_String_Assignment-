using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssi2
{
    public class Second_Small
    {
        static void Main(string[] args)
        {
                int[] arr = { 33,3,45,55,77,88 };

            int small = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]<small)
                {
                    small = arr[i];
                }
            }
            int sec_small = arr[4];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]!=small && arr[i]<sec_small)
                {
                    sec_small = arr[i];
                }
            }
            Console.WriteLine("Second smallest no is="+sec_small);
        }        
    }
}
