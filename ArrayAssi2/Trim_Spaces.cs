using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to trim leading white space characters in a string.
namespace ArrayAssi2
{
    public class Trim_Spaces
    {
        static void Main(string[] args)
        {
            string str = "   hello to all";

            str = str.Trim();
            Console.WriteLine(str);
        }
    }
}
