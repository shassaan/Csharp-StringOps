using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace interview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3("");
            var list = RemoveAnagrams(new List<string> { "this", "siht" ,"he","are","this"});
            Console.WriteLine(string.Join(",", list));
        }

        static void RemoveDuplicate()
        {
            string str = "People".ToLower();
            var dictionary = new Dictionary<char, int>();
            foreach (var ch in str)
            {
                if (dictionary.ContainsKey(ch))
                    continue;
                dictionary.Add(ch, str.Where(c => c == ch).Count());
            }

            Console.WriteLine(string.Join("", dictionary.Keys));
        }

        static void SecondMax()
        {
            var list = new List<int>
            {2,4,3,1,5};//{1,2,3,5,5}
            list.RemoveAll(n => n == list.Max());
            Console.WriteLine(list.Max());

        }

        static int CountVowels(string stringContainingVowels)
        {
            return stringContainingVowels.Where(c => new char[] { 'a', 'e', 'i', 'o', 'u' }.Contains(c))
            .Count();
        }

        static bool ContainsVowels(string stringContainingVowels)
        {
            var vowelsRegex = "$[A-za-z]{1,}[Aa]{1,}[Ee]{1,}[Ii]{1,}[Oo]{1,}[Uu]{1,}^";
            return Regex.IsMatch(stringContainingVowels, vowelsRegex);
        }

        static string ReverseSentence(string sentence)
        {
            var words = sentence.Split(' ');
            var reversedWords = words.Reverse();
            return string.Join(" ", reversedWords);
        }


        static List<string> RemoveAnagrams(List<string> stringsList)
        {
            var dict = new Dictionary<string, string>();
            var listAns = new List<string>();

            foreach (var str in stringsList)
            {
                string currentString = str;

                currentString = sort(currentString);

                if (!dict.ContainsKey(currentString))
                {
                    dict.Add(currentString, "");
                    listAns.Add(str);
                }
            }


            return listAns;
        }

        static String sort(String inputString)
        {
             
            char[] tempArray = inputString.ToCharArray();

             
            Array.Sort(tempArray);

             
            return String.Join("", tempArray);
        }


        private static bool AreAnagrams(string text1, string text2)
        {
            var ch1 = text1.ToLower().ToCharArray();
            var ch2 = text2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            var val1 = new string(ch1);
            var val2 = new string(ch2);

            if (val1 == val2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
