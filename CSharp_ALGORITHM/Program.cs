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
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string Capital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = "";
            string message = "THis is just a test, and it rotates each letter by 13 forward";
            char[] another = message.ToCharArray();

            for (int i = 0; i < another.Length; i++)
            {
                if (!Char.IsLetter(another[i]))
                {
                    result += another[i];
                }
                else if (letters.Contains(another[i]))
                {
                    int index = (letters.IndexOf(another[i]) + 13) % 26;
                    result += letters[index];
                }
                else
                {
                    int index = (Capital.IndexOf(another[i]) + 13) % 26;
                    result += Capital[index];
                }
            }
            Console.WriteLine(result);

        }
    }
}
