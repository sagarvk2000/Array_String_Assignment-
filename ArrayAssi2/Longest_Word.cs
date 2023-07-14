using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to find longest word in the given sentence
namespace ArrayAssi2
{
    public class Longest_Word
    {
        static void Main(string[] args)
        {
            string str1 = "hello to everyone";

            string [] str2 = str1.Split(new[] {" "},StringSplitOptions.None);
            int count = 0;
            string word = string.Empty;

            foreach (string s in str2)
            {
                if(s.Length > count)
                {
                    count = s.Length;
                    word = s;
                }
            }
            Console.WriteLine("Longest word is="+word+"\nlength ="+count);
        }
    }
}
