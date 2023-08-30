using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    internal class LinkedList
    {
        static LinkedList<string> words = new LinkedList<string>();
        static int Count = 0;
        public static void ReadLinkedList()
        {
            string Text = File.ReadAllText(@"/Users/dima/Downloads/text.txt");
            var noPunctuationText = new string(Text.Where(c => !char.IsPunctuation(c)).ToArray());

            string[] arrayWordds = noPunctuationText.Split(' ');

            for (int i = 0; i < arrayWordds.Length; i++)
            {
                words.AddFirst(arrayWordds[i]);
            }

            foreach (string word in words)
            {
                Count++;
                Console.WriteLine(word);
            }
            Console.WriteLine(Count);
        }
    }
}