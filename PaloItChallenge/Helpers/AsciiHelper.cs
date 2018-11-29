using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace PaloItChallenge.Helpers
{
    public static class AsciiHelper
    {
        public static int SumAsciiValuesInString(string input)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(input);
            int sum = asciiBytes.Select(x => (int)x).Sum();
            return sum;
        }

        public static string ConvertNumToBinaryString(int num)
        {
            const int radix = 2;
            string binaryNum = Convert.ToString(num, radix);
            return binaryNum;
        }

        public static int GetMaxNumOfConsecutiveZeros(string binaryNum)
        {
            bool isValidBinary = Regex.IsMatch(binaryNum, "^[01]+$");
            if (isValidBinary)
            {
                const string splitChar = "1";
                string[] groupsOfConsecutiveZeros = binaryNum.Split(new string[] { splitChar }, StringSplitOptions.None);
                string largestGroupOfConsecutiveZeros = groupsOfConsecutiveZeros.OrderByDescending(s => s.Length).First();
                return largestGroupOfConsecutiveZeros.Length;
            }
            else
            {
                throw new ArgumentException($"{binaryNum} is not valid binary.");
            }
        }
    }
}