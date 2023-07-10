 using System;
namespace string_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
            static void Main()
            {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);
                int consonantCount = CountConsonants(input);

                Console.WriteLine("Number of vowels: " + vowelCount);
                Console.WriteLine("Number of consonants: " + consonantCount);
            }

            static int CountVowels(string input)
            {
                int count = 0;
                string vowels = "Hello World";

                foreach (char ch in input)
                {
                    if (vowels.Contains(ch))
                    {
                        count++;
                    }
                }

                return count;
            }

            static int CountConsonants(string input)
            {
                int count = 0;
                string consonants = "Hello World";

                foreach (char ch in input)
                {
                    if (consonants.Contains(ch))
                    {
                        count++;
                    }
                }

                return count;
            }
        }

    }
