using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPT_Free_Zone
{
    internal class wordFrequencyCounter
    {
        public static void FrequencyCounter()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine().ToLower();

            // Remove common punctuation
            string cleanSentence = sentence.Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "");

            // Split into words
            string[] words = cleanSentence.Split(' ');

            // Frequency check
            for (int i = 0; i < words.Length; i++)
            {
                int count = 1;  // Start with 1 for the current word

                if (words[i] != "")  // Avoid empty strings
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            count++;
                            words[j] = "";  // Mark as counted by making it empty
                        }
                    }
                    Console.WriteLine($"{words[i]}: {count}");
                }
            }
            Console.ReadLine();
        }
    }
}
