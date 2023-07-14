using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//check two strings anagram or not
namespace ArrayAssi2
{
    public class Anagram
    {
        static void Main(string[] args)
        {
            string str1 = "bat";
            string str2 = "tab";

            char[] ch1 = str1.ToCharArray();
            Array.Sort(ch1);
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch2);




        }
    }
}
