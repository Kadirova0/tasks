
using System;

class Program
{
    static void Main()
    {

        string input = "CodeAcademy is a good place to study";

        int wordCount = CountWords(input);
        Console.WriteLine("Total number of words: " + wordCount);
    }

    static int CountWords(string input)
    {
     
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
