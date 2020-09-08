using System;
using System.Collections.Generic;

namespace CSharp_ALGORITHM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question
            //Trolls are attacking your comment section!

            //A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

            //Your task is to write a function that takes a string and return a new string with all vowels removed.

            //For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
            string result =Disemvowel("This website is for losers LOL!");
            Console.WriteLine(result);
        }
        public static string Disemvowel(string str)
        {
            string vowels = "aeiouAEIOU";
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!vowels.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            return result;
        }
    }
}
