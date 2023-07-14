using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to find first occurrence of a character in a given string
namespace ArrayAssi2
{
    public class First_Occurance
    {
        static void Main(string[] args)
        {
            string str = "hello to all";

            Console.WriteLine("Enter a character");
            char fword =Convert.ToChar(Console.ReadLine());

            char[] ch=str.ToCharArray();
            int a=0;
            for (int i = 0; i < ch.Length; i++)
            {
                if(ch[i] == fword)
                {
                    a = 1;
                    Console.WriteLine(i);
                    break;
                }
            }
            if(a==0)
            Console.WriteLine("The character not found...");
        }
    }
}
