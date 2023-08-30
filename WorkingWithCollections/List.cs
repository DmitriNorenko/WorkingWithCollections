using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using WorkingWithCollections;
using static System.Net.Mime.MediaTypeNames;

namespace WorkingWithCollections
{
    public static class List
    {
        static List<string> words = new List<string>();
        static int Count = 0;

        static string Text = File.ReadAllText(@"/Users/dima/Downloads/text.txt");
        static string noPunctuationText = new string(Text.Where(c => !char.IsPunctuation(c)).ToArray());

        static string[] arrayWords = noPunctuationText.Split(" ");
        public static void ReadList()
        {
            words.AddRange(arrayWords);

            foreach (string word in words)
            {
                Count++;
                Console.WriteLine(word);
            }
            Console.WriteLine("\n Слов: " + Count);
        }
        public static void SearchWord()
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (string word in arrayWords)
            {
                if (words.ContainsKey(word))
                {
                    words[word] += 1;
                }
                else
                {
                    words.Add(word, 1);
                }
            }
            // foreach (string word in words.Keys)
            // {
            //    if (words[word] >1000)
            //  {
            //     Console.WriteLine(word);
            //  }
            // }

            string Str = "";
            int k = 0;

            foreach (var kk in words.OrderByDescending(x => x.Value))
            {
                Str += " " + kk.Key + " " + kk.Value.ToString() + "\n";
                k++;
                if (k == 10) break;
            }

            Console.WriteLine("\n 10 самых повторяющихся слов: \n" + Str);
        }
    }
}
