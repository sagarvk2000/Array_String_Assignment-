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
            // string str1 = "bat";
            // string str2 = "tab";
            Console.WriteLine("Enter two Words");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            char[] ch1 = str1.ToCharArray();
            Array.Sort(ch1);
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch2);

            string NewWord1 = new string(ch1);
            string NewWord2 = new string(ch2);

            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not anagram");
            }
        }

        //public class Anagram
        //{
        //    public bool areAnagram(string firstString, string secondString)
        //    {
        //        if (firstString.Length != secondString.Length)
        //        {
        //            return false;
        //        }
        //        //Convert string to character array  
        //        char[] firstCharsArray = firstString.ToLower().ToCharArray();
        //        char[] secondCharsArray = secondString.ToLower().ToCharArray();
        //        //Sort array  
        //        Array.Sort(firstCharsArray);
        //        Array.Sort(secondCharsArray);
        //        //Check each character and position.  
        //        for (int i = 0; i < firstCharsArray.Length; i++)
        //        {
        //            if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //    static void Main(string[] args)
        //    {
        //        string firstString, secondString;
        //        //Gets words from user.  
        //        Console.WriteLine("Enter first string");
        //        firstString = Console.ReadLine();
        //        Console.WriteLine("Enter second string");
        //        secondString = Console.ReadLine();
        //        Anagram anagram = new Anagram();
        //        //Check if words are anagram  
        //        if (anagram.areAnagram(firstString, secondString) == true)
        //        {
        //            Console.WriteLine("Both string are anagram string.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Both string are not anagram string.");
        //        }
        //        Console.ReadLine();
        //    }
        //}

    }
}

