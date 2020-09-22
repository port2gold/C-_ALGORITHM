using System;
using System.Collections.Generic;

namespace CSharp_ALGORITHM
{
    class Program
    {
        static void Main(string[] args)
        {
            //ROMAN NUMERAL DECODER
            //Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.
            //You don't need to validate the form of the Roman numeral.

            //Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, 
            //starting with the leftmost digit and skipping any 0s.So 1990 is rendered "MCMXC"(1000 = M, 900 = CM, 90 = XC) 
            //and 2008 is rendered "MMVIII"(2000 = MM, 8 = VIII).The Roman numeral for 1666, "MDCLXVI", uses each letter in 
            //descending order.

            //Example:


            //RomanDecode.Solution("XXI")-- should return 21
            //Help:

            //Symbol Value
            //I          1
            //V          5
            //X          10
            //L          50
            //C          100
            //D          500
            //M          1,000

            string roman = "CMXL";
            var dict = new Dictionary<string, int>();
            dict.Add("I", 1);
            dict.Add("V", 5);
            dict.Add("X", 10);
            dict.Add("L", 50);
            dict.Add("C", 100);
            dict.Add("D", 500);
            dict.Add("M", 1000);
            dict.Add("IV", 4);
            dict.Add("IX", 9);
            dict.Add("XL", 40);
            dict.Add("XC", 90);
            dict.Add("CM", 900);
            dict.Add("CD", 500);



            int result = 0;
            var oddone = new string[] { "IV", "IX", "XL", "XC", "CM", "CD" };
            for (int i = 0; i < oddone.Length; i++)
            {
                if (roman.Contains(oddone[i]))
                {
                    roman = roman.Replace(oddone[i], "");
                    result += dict[oddone[i]];
                }
            }
            for (int i = 0; i < roman.Length; i++)
            {
                result += dict[roman[i].ToString()];
            }
            Console.WriteLine(result);
        }






    }
}
