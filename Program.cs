using System;
using System.Globalization;

namespace string_task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "java";
            input = input.ToUpper();
            Console.WriteLine();


            static string ReverseStringToUpper(string input)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray).ToUpper();
                return reversed;
            }
        }
    }
}