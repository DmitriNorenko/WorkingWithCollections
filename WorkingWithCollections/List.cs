using System;
using System.Collections.Generic;
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
        public static void ReadList()
        {
            string Text = File.ReadAllText(@"/Users/dima/Downloads/text.txt");
            var noPunctuationText = new string(Text.Where(c => !char.IsPunctuation(c)).ToArray());

            string[] arrayWordds = noPunctuationText.Split(' ');

            words.AddRange(arrayWordds);

            foreach (string word in words)
            {
                Count++;
                Console.WriteLine(word);
            }
            Console.WriteLine(Count);
        }
    }
}
