using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssi2
{
    public class Unique
    {       
        static void Main(string[] args)
        {
            int[] items = { 6, 7, 8, 9, 7, 8, 6, 9, 7, 8 };
            int n = items.Length;

            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.WriteLine(items[i]);
                }
            }
            Console.ReadLine();
        }     
    }
}
