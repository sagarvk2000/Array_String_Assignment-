using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssi2
{
    public class Duplicate_word
    {
        static void Main(string[] args)
        {
            //string str = "hello everyone hello";
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            int count;

            string[] words = str.Split(' ');

            Console.WriteLine("duplicate word");

            for (int i = 0; i < words.Length; i++)
            {
                count = 1;
                for (int j = i+1; j < words.Length; j++)
                {
                    if(words[i]==words[j])
                    {
                        count++;
                        words[j] = "0";
                    }
                }
                if(count > 1 && words[i] != "0")
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
