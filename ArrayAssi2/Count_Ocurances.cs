using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to count occurrences of a character in given string.
namespace ArrayAssi2
{
    public class Count_Ocurances
    {
        static void Main(string[] args)
        {
            string str = "hello to all";

            Console.WriteLine("Enter a character =");
            char word = Convert.ToChar(Console.ReadLine());
            
            char[] ch = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if(ch[i] == word)
                {
                    count++;
                    Console.WriteLine(ch[i]);
                }                
            }
            Console.WriteLine(count);
        }
    }   
}
