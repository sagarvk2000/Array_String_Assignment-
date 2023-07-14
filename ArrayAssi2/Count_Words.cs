using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to count total number of words in a string.
namespace ArrayAssi2
{
    public class Count_Words
    {
        static void Main(string[] args)
        {
            string str = "my name is xyz";

            char[] ch = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < ch.Length; i++)
            {
               count++;

            }
            Console.WriteLine(count);
        }
    }
}
