using System;
using System.Collections.Generic;

namespace CSharp_ALGORITHM
{
    class Program
    {
        static void Main(string[] args)
        {
           //Question
           //Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
           string result = PigIt("Pig latin is cool");
            Console.WriteLine(result);
        }
        public static string PigIt(string str)
        {
            string[] result = str.Split(' ');
            string newresult = "";
            for (int i = 0; i < result.Length; i++)
            {
                newresult += result[i].Substring(1, result[i].Length - 1) + result[i].Substring(0, 1) + "ay ";
            }
            return newresult.Trim();
        }
    }
}
