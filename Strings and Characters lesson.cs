using System;
using System.Text;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine(ConcatenateStrings("Hello, ", "world!"));

            Console.WriteLine(GreetUser("Alex", 25));

            Console.WriteLine(GetStringInfo("Hello World"));

            Console.WriteLine(GetFirstFiveCharacters("Programming"));

            string[] words = { "I", "love", "C#", "very", "much" };
            StringBuilder sentence = BuildSentence(words);
            Console.WriteLine(sentence.ToString());

            string result = ReplaceWords("Hello world", "world", "universe");
            Console.WriteLine(result);
        }

        // ================== Задание 1 ==================
       
        static string ConcatenateStrings(string first, string second)
        {
            return first + second;
        }

        // ================== Задание 2 ==================
      
        static string GreetUser(string name, int age)
        {
            return $"Hello, {name}!\nYou are {age} years old.";
        }

        // ================== Задание 3 ==================
      
        static string GetStringInfo(string input)
        {
            return
                $"Length: {input.Length}\n" +
                $"Upper case: {input.ToUpper()}\n" +
                $"Lower case: {input.ToLower()}";
        }

        // ================== Задание 4 ==================
      
        static string GetFirstFiveCharacters(string input)
        {
            return input.Substring(0, 5);
        }

        // ================== Задание 5 ==================
       
        static StringBuilder BuildSentence(string[] words)
        {
            StringBuilder builder = new StringBuilder();

            foreach (string word in words)
            {
                builder.Append(word).Append(" ");
            }

            return builder;
        }

        // ================== Задание 6 ==================
       
        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }
    }
}