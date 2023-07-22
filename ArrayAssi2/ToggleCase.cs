using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssi2
{
    public class ToggleCase
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = "";
           
            char [] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if(char.IsUpper(ch[i]))
                {
                    str1 = str1 + char.ToLower(ch[i]);
                }
                else if(char.IsLower(ch[i]))
                {
                    str1 = str1 + char.ToUpper(ch[i]);
                }
            }
            Console.WriteLine(str1);           
        }
    }
}
