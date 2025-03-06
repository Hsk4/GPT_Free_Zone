using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPT_Free_Zone
{
    internal class Consonents_Vowels
    {
        public static void ConsonentsandVowels()
        {
            char[] vowel = { 'a' , 'e' , 'i' , 'o' , 'u'};
            Console.WriteLine("Enter a word");
            string input = Console.ReadLine().ToLower();

            int totalConsonents = 0;
            int totalVowel = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool isVowel = false; 
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (input[i] == vowel[j])
                    {
                        isVowel = true;
                        totalVowel++;
                        break;

                    }
                }
                if (!isVowel && char.IsLetter(input[i]))
                {
                    totalConsonents++;
                }
               

            }
            Console.WriteLine($"there are {totalVowel} vowels");
            Console.WriteLine($"there are {totalConsonents} consonents");
            Console.ReadLine();

        }
    }
}
