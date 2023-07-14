using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to check whether given string is palindrome or not.
namespace ArrayAssi2
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string str=Console.ReadLine();
            
            string str1=string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                str1 = str1 + str[i];
            }
                if(str == str1)
                {
                    Console.WriteLine("palindrome");
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                }   
            }
        }
    }

