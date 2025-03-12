using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPT_Free_Zone
{
    internal class letterFrequencyCounter
    {
        public static void FrequencyCounter()
        {

            Console.WriteLine("Enter your sentence ");
            string input = Console.ReadLine().ToLower();

            int[] frequncies = new int[26];
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    int index = input[i] - 'a';
                    frequncies[index]++;
                }
                
            }

            Console.WriteLine("\n letter frequency");
            for (int i = 0; i < 26; i++)
            {
                if (frequncies[i]>0)
                {

                Console.WriteLine($"{(char)(i + 'a')} : {frequncies[i]}");
                }
            }
            Console.ReadLine();
        }

    }
}
