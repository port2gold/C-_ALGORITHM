using System;

namespace CSharp_ALGORITHM
{
    class Program
    {
        static void Main(string[] args)
        {

            //ROT13 is a simple letter substitution cipher that replaces a 
            //letter with the letter 13 letters after it in the alphabet. 
            //ROT13 is an example of the Caesar cipher.

            //Create a function that takes a string and returns the string ciphered with Rot13.
            //If there are numbers or special characters included in the string, they should be
            //returned as they are.Only letters from the latin/ english alphabet should be shifted, 
            //like in the original Rot13Question
            //string letters = "abcdefghijklmnopqrstuvwxyz";
            //string Capital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string result = "";
            //string message = "THis is just a test, and it rotates each letter by 13 forward";
            //char[] another = message.ToCharArray();

            //for (int i = 0; i < another.Length; i++)
            //{
            //    if (!Char.IsLetter(another[i]))
            //    {
            //        result += another[i];
            //    }
            //    else if (letters.Contains(another[i]))
            //    {
            //        int index = (letters.IndexOf(another[i]) + 13) % 26;
            //        result += letters[index];
            //    }
            //    else
            //    {
            //        int index = (Capital.IndexOf(another[i]) + 13) % 26;
            //        result += Capital[index];
            //    }
            //}
            //Console.WriteLine(result);


            //Question - Not Very Secure
            //In this example you have to validate if a user input string is alphanumeric.
            //The given string is not nil / null / NULL / None, so you don't have to check that.

            //The string has the following conditions to be alphanumeric:

            //At least one character("" is not valid)
            //Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
            //No whitespaces / underscore

            //using System;
            //using System.Text.RegularExpressions;
            //public class Kata
             //{
            //public static bool Alphanumeric(string str)
            //{
              //  Console.WriteLine(str);
                // your code here

        //        bool another = !string.IsNullOrEmpty(str);
        //        bool result = isAlphaNumeric(str);
        //        return result && another;
        //    }
        //    public static Boolean isAlphaNumeric(string strToCheck)
        //    {
        //        Regex rg = new Regex("[^a-zA-Z0-9]");

        //        //if has non AlpahNumeric char, return false, else return true.
        //        return rg.IsMatch(strToCheck) == true ? false : true;
        //    }
        //}

    }
    }
}
